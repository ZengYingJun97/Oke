package com.bnuz.oke.config;

import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.test.context.junit4.SpringRunner;

@RunWith(SpringRunner.class)
@SpringBootTest
class RedisConfigTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private RedisTemplate redisTemplate;

	@Test
	void redisTemplate() {
		String key = "handsome";
		String value = "曾庆望";
		redisTemplate.opsForValue().set(key, value);
		String nowValue = (String) redisTemplate.opsForValue().get(key);
		System.out.println(nowValue);
	}
}