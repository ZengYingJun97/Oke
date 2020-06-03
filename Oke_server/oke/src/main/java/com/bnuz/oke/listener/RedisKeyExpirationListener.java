package com.bnuz.oke.listener;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.service.CourseService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.connection.Message;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.data.redis.listener.KeyExpirationEventMessageListener;
import org.springframework.data.redis.listener.RedisMessageListenerContainer;
import org.springframework.stereotype.Component;

import java.io.ByteArrayInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;

/**
 * RedisKeyExpirationListener
 *
 * @author handsome
 * @date 2020年 06月03日 12:35:57
 */

@Component
public class RedisKeyExpirationListener extends KeyExpirationEventMessageListener {

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
			ByteArrayInputStream in=new ByteArrayInputStream(pattern);
			ObjectInputStream sIn= null;
			try {
				sIn = new ObjectInputStream(in);
				Course course = (Course) sIn.readObject();
				redisTemplate.delete("courseStudent:" + course.getCourseNumber());
				courseService.endCourse(course);
			} catch (IOException | ClassNotFoundException e) {
				e.printStackTrace();
			}
		}
	}
}
