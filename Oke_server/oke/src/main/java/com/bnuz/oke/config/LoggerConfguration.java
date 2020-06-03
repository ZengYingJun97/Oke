package com.bnuz.oke.config;

import com.bnuz.oke.interceptor.LoggerInterceptor;
import org.springframework.context.annotation.Configuration;
import org.springframework.web.servlet.config.annotation.InterceptorRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;

/**
 * LoggerConfguration
 *
 * @author handsome
 * @date 2020年 06月03日 17:49:52
 */
@Configuration
public class LoggerConfguration implements WebMvcConfigurer {

	/**
	 * 将拦截器配置到SpringBoot中
	 */
	@Override
	public void addInterceptors(InterceptorRegistry registry) {
		registry.addInterceptor(new LoggerInterceptor()).addPathPatterns("/**");
	}
}
