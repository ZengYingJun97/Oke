package com.bnuz.oke.controller;

import com.bnuz.oke.dto.OkeResult;
import com.bnuz.oke.dto.SessionData;
import com.bnuz.oke.entity.Mail;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.enums.CourseStateEnum;
import com.bnuz.oke.enums.LoginStateEnum;
import com.bnuz.oke.enums.OkeStateEnum;
import com.bnuz.oke.service.MailService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;

/**
 * MailController
 *
 * @author handsome
 * @date 2020年 06月09日 12:25:38
 */
@Controller
@CrossOrigin
@RequestMapping("/oke/mail")
public class MailController {
	private Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private MailService mailService;

	@Autowired
	private RedisTemplate redisTemplate;

	/**
	 * 发送邮件
	 * @date 2020/06/09 12:44:27
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/add",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> addMail(@RequestBody SessionData<Mail> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				boolean isOk = mailService.addMail(sessionData.getData());
				if (isOk) {
					result = new OkeResult<>(true, CourseStateEnum.SUCCESS_OP.getStateInfo());
				} else {
					result = new OkeResult<>(false, CourseStateEnum.Fail_OP.getStateInfo());
				}
			} catch (Exception e) {
				logger.info("e = {}", e);
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 已发送的邮件列表
	 * @date 2020/06/09 12:44:27
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/from/list",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> getMailFromList(@RequestBody SessionData<User> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				List<Mail> mailFrom = mailService.getMailByFromUsername(sessionData.getData().getUsername());
				SessionData<List<Mail>> listSessionData = new SessionData<>(sessionId, mailFrom);
				result = new OkeResult<>(true, listSessionData);
			} catch (Exception e) {
				logger.info("e = {}", e);
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 接收的邮件列表
	 * @date 2020/06/09 12:56:48
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/to/list",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> getMailToList(@RequestBody SessionData<User> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				List<Mail> mailFrom = mailService.getMailByToUsername(sessionData.getData().getUsername());
				SessionData<List<Mail>> listSessionData = new SessionData<>(sessionId, mailFrom);
				result = new OkeResult<>(true, listSessionData);
			} catch (Exception e) {
				logger.info("e = {}", e);
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}
}
