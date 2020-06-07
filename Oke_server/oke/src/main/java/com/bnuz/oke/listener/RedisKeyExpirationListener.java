package com.bnuz.oke.listener;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.service.CourseService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.connection.Message;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.data.redis.listener.KeyExpirationEventMessageListener;
import org.springframework.data.redis.listener.RedisMessageListenerContainer;
import org.springframework.stereotype.Component;

/**
 * RedisKeyExpirationListener
 *
 * @author handsome
 * @date 2020年 06月03日 12:35:57
 */

@Component
public class RedisKeyExpirationListener extends KeyExpirationEventMessageListener {
	private final Logger logger = LoggerFactory.getLogger(RedisKeyExpirationListener.class);

	@Autowired
	private RedisTemplate redisTemplate;

	@Autowired
	private CourseService courseService;

	public RedisKeyExpirationListener(RedisMessageListenerContainer listenerContainer) {
		super(listenerContainer);
	}

	/**
	 * 针对redis数据失效事件，进行数据处理
	 * @date 2020/06/03 12:36:29
	 * @author handsome
	 * @param message
	 * @param pattern
	 * @return void
	 */
	@Override
	public void onMessage(Message message, byte[] pattern) {
		String expiredKey = message.toString();
		if(expiredKey.startsWith("course:")){
			logger.info("===========================课堂过期===============================");
			try {
				String courseNumber = (String) redisTemplate.opsForValue().get("copyKey:" + expiredKey);
				Course course = courseService.getCourseByCourseNumber(courseNumber);
				redisTemplate.delete("courseStudent:" + course.getCourseNumber());
				redisTemplate.delete("copyKey:" + expiredKey);
				courseService.endCourse(course);
				logger.info("courseNumber = {}", courseNumber);
				logger.info("系统强制下课成功");
			} catch (Exception e) {
				logger.info("系统强制下课失败");
				e.printStackTrace();
			}
			logger.info("================================================================");
		}
	}
}
