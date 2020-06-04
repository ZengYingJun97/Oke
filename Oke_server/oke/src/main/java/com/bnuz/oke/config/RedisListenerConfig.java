package com.bnuz.oke.config;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.data.redis.connection.RedisConnectionFactory;
import org.springframework.data.redis.listener.RedisMessageListenerContainer;

/**
 * RedisListenerConfig
 *
 * @author handsome
 * @date 2020年 06月03日 12:33:56
 */
@Configuration
public class RedisListenerConfig {

	@Bean
	RedisMessageListenerContainer container(RedisConnectionFactory redisConnectionFactory){
		RedisMessageListenerContainer container = new RedisMessageListenerContainer();
		container.setConnectionFactory(redisConnectionFactory);
		return container;
	}
}