package com.bnuz.oke.controller;

import com.bnuz.oke.dto.OkeResult;
import com.bnuz.oke.dto.SessionData;
import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.enums.LoginStateEnum;
import com.bnuz.oke.enums.OkeStateEnum;
import com.bnuz.oke.service.CourseService;
import com.bnuz.oke.service.LoginService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.ResponseBody;

import javax.servlet.http.HttpSession;

/**
 * OkeController
 *
 * @author handsome
 * @date 2020年 05月22日 23:46:36
 */
@Controller
@RequestMapping("/oke")
public class OkeController {
	private Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private LoginService loginService;

	@Autowired
	private CourseService courseService;

	@Autowired
	private RedisTemplate redisTemplate;

	@RequestMapping(value = "/teacher/register",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<String> registerTeacher(@RequestBody Teacher teacher) {
		OkeResult<String> result;
		try {
			boolean isOk = loginService.registerTeacher(teacher);
			if (isOk) {
				result = new OkeResult<>(isOk, LoginStateEnum.SUCCESS_REGISTER.getStateInfo());
			} else {
				result = new OkeResult<>(isOk, LoginStateEnum.FAIL_REGISTER.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	@RequestMapping(value = "/teacher/login",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> loginTeacher(@RequestBody User user, HttpSession session) {
		OkeResult<SessionData> result;
		try {
			Teacher teacher = loginService.loginTeacher(user);
			if (teacher != null) {
				teacher.getUser().setPassword(null);
				SessionData sessionData = new SessionData(session.getId(), teacher);

				result = new OkeResult<>(true, sessionData);

				redisTemplate.opsForValue().set("sessionId:" + sessionData.getSessionId(), "teacher:" + teacher.getTeacherId());
				redisTemplate.opsForValue().set("teacher:" + teacher.getTeacherId(), teacher);
			} else {
				result = new OkeResult<>(false, LoginStateEnum.FAIL_LOGIN.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	@RequestMapping(value = "/student/register",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<String> registerStudent(@RequestBody Student student) {
		OkeResult<String> result;
		try {
			boolean isOk = loginService.registerStudent(student);
			if (isOk) {
				result = new OkeResult<>(isOk, LoginStateEnum.SUCCESS_REGISTER.getStateInfo());
			} else {
				result = new OkeResult<>(isOk, LoginStateEnum.FAIL_REGISTER.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	@RequestMapping(value = "/student/login",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> loginStudent(@RequestBody User user, HttpSession session) {
		OkeResult<SessionData> result;
		try {
			Student student = loginService.loginStudent(user);
			if (student != null) {
				student.getUser().setPassword(null);
				SessionData sessionData = new SessionData(session.getId(), student);

				result = new OkeResult<>(true, sessionData);

				redisTemplate.opsForValue().set("sessionId:" + sessionData.getSessionId(), "student:" + student.getStudentId());
				redisTemplate.opsForValue().set("student:" + student.getStudentId(), student);
			} else {
				result = new OkeResult<>(false, LoginStateEnum.FAIL_LOGIN.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}
}
