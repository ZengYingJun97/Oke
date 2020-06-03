package com.bnuz.oke.interceptor;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.web.servlet.HandlerInterceptor;
import org.springframework.web.servlet.ModelAndView;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import java.util.Date;

/**
 * LoggerInterceptor
 *
 * @author handsome
 * @date 2020年 06月03日 17:50:51
 */
public class LoggerInterceptor implements HandlerInterceptor {
	private final Logger logger = LoggerFactory.getLogger(LoggerInterceptor.class);

	@Override
	public boolean preHandle(HttpServletRequest request, HttpServletResponse response, Object handler)
			throws Exception {
		logger.info("===========================请求内容===============================");
		logger.info("time = {}", new Date());
		logger.info("url = {}", request.getRequestURL());
		logger.info("method = {}", request.getMethod());
		logger.info("ip = {}", request.getRemoteAddr());
		logger.info("=================================================================");
		long start = System.currentTimeMillis();
		request.setAttribute("START_TIME", start);
		return true;
	}

	@Override
	public void postHandle(HttpServletRequest request, HttpServletResponse response, Object handler,
						   ModelAndView modelAndView) throws Exception {
		logger.info("===========================响应内容===============================");
		logger.info("time = {}", new Date());
		logger.info("status = {}", response.getStatus());
		logger.info("=================================================================");
	}

	@Override
	public void afterCompletion(HttpServletRequest request, HttpServletResponse response, Object handler, Exception ex)
			throws Exception {
		String url  = request.getRequestURI();
		long start = (long) request.getAttribute("START_TIME");
		long end = System.currentTimeMillis();
		long costTime = end - start;
		logger.info("===========================花费时间===============================");
		logger.info("request finished | url : [{}], costTime : [{}] ms ", url, costTime);
		logger.info("=================================================================");
	}
}
