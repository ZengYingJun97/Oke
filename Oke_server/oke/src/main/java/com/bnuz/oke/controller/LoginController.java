package com.bnuz.oke.controller;

import com.bnuz.oke.dto.OkeResult;
import com.bnuz.oke.dto.SessionData;
import com.bnuz.oke.dto.UpdateUserData;
import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.enums.LoginStateEnum;
import com.bnuz.oke.enums.OkeStateEnum;
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
import java.util.concurrent.TimeUnit;

/**
 * OkeController
 *
 * @author handsome
 * @date 2020年 05月22日 23:46:36
 */
@Controller
@RequestMapping("/oke")
public class LoginController {
	private Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private LoginService loginService;

	@Autowired
	private RedisTemplate redisTemplate;

	/**
	 * 注册老师Controller
	 * @date 2020/05/24 23:34:18
	 * @author handsome
	 * @param teacher
	 * @return com.bnuz.oke.dto.OkeResult<java.lang.String>
	 */
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

	/**
	 * 登陆老师Controller
	 * @date 2020/05/24 23:34:34
	 * @author handsome
	 * @param user
 * @param session
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/teacher/login",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> loginTeacher(@RequestBody User user, HttpSession session) {
		OkeResult<SessionData> result;
		try {
			Teacher teacher = loginService.loginTeacher(user);
			if (teacher != null) {
				SessionData sessionData = new SessionData(session.getId(), teacher);

				redisTemplate.opsForValue().set("session:" + sessionData.getSessionId(), "teacher:" + teacher.getTeacherId(), 60 * 60 * 24, TimeUnit.SECONDS);
				redisTemplate.opsForValue().set("teacher:" + teacher.getTeacherId(), teacher, 60 * 60 * 24, TimeUnit.SECONDS);

				teacher.getUser().setPassword(null);

				result = new OkeResult<>(true, sessionData);
			} else {
				result = new OkeResult<>(false, LoginStateEnum.FAIL_LOGIN.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	/**
	 * 注册学生Controller
	 * @date 2020/05/24 23:34:45
	 * @author handsome
	 * @param student
	 * @return com.bnuz.oke.dto.OkeResult<java.lang.String>
	 */
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

	/**
	 * 登陆学生Controller
	 * @date 2020/05/24 23:35:09
	 * @author handsome
	 * @param user
	 * @param session
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/student/login",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> loginStudent(@RequestBody User user, HttpSession session) {
		OkeResult<SessionData> result;
		try {
			Student student = loginService.loginStudent(user);
			if (student != null) {
				SessionData sessionData = new SessionData(session.getId(), student);

				redisTemplate.opsForValue().set("session:" + sessionData.getSessionId(), "student:" + student.getStudentId(), 60 * 60 * 24, TimeUnit.SECONDS);
				redisTemplate.opsForValue().set("student:" + student.getStudentId(), student, 60 * 60 * 24, TimeUnit.SECONDS);

				student.getUser().setPassword(null);

				result = new OkeResult<>(true, sessionData);
			} else {
				result = new OkeResult<>(false, LoginStateEnum.FAIL_LOGIN.getStateInfo());
			}
		} catch (Exception e) {
			logger.info("exception = {}", e);
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	/**
	 * 修改老师信息Controller
	 * @date 2020/05/24 23:51:44
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/teacher/info/update",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> updateTeacher(@RequestBody SessionData<Teacher> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			Teacher teacher = sessionData.getData();
			try {
				teacher = loginService.updateTeacher(teacher);
				sessionData.setData(teacher);
				redisTemplate.opsForValue().set("teacher:" + teacher.getTeacherId(), teacher, 60 * 60 * 24, TimeUnit.SECONDS);
				result = new OkeResult<>(true, sessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 修改学生信息Controller
	 * @date 2020/05/24 23:51:44
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/student/info/update",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> updateStudent(@RequestBody SessionData<Student> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			Student student = sessionData.getData();
			try {
				student = loginService.updateStudent(student);
				sessionData.setData(student);
				redisTemplate.opsForValue().set("student:" + student.getStudentId(), student, 60 * 60 * 24, TimeUnit.SECONDS);
				result = new OkeResult<>(true, sessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 修改老师密码 
	 * @date 2020/05/25 11:19:30
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */        
	@RequestMapping(value = "/teacher/user/update",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> updateTeacherUser(@RequestBody SessionData<UpdateUserData> sessionData) {
		String username = sessionData.getData().getUser().getUsername();
		String oldPassword = sessionData.getData().getUser().getPassword();
		String newPassword = sessionData.getData().getNewPassword();

		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				Teacher teacher = (Teacher) redisTemplate.opsForValue().get("teacher:" + value);
				User user;
				if (teacher == null) {
					teacher = loginService.getTeacherByUsername(username);
					user = teacher.getUser();
					redisTemplate.opsForValue().set("teacher:" + teacher.getTeacherId(), teacher);
				} else {
					user = teacher.getUser();
				}

				if (user.getPassword().equals(oldPassword)) {
					user.setPassword(newPassword);
					boolean isOK = loginService.updateUser(user);
					if (isOK) {
						result = new OkeResult<>(true, LoginStateEnum.SUCCESS_UPDATE.getStateInfo());
						teacher.setUser(user);
						redisTemplate.opsForValue().set("teacher:" + teacher.getTeacherId(), teacher);
					} else {
						result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
					}
				} else {
					result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
				}
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 修改学生密码
	 * @date 2020/05/25 11:19:30
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/student/user/update",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> updateStudentUser(@RequestBody SessionData<UpdateUserData> sessionData) {
		String username = sessionData.getData().getUser().getUsername();
		String oldPassword = sessionData.getData().getUser().getPassword();
		String newPassword = sessionData.getData().getNewPassword();

		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				Student student = (Student) redisTemplate.opsForValue().get("student:" + value);
				User user;
				if (student == null) {
					student = loginService.getStudentByUsername(username);
					user = student.getUser();
					redisTemplate.opsForValue().set("student:" + student.getStudentId(), student);
				} else {
					user = student.getUser();
				}

				if (user.getPassword().equals(oldPassword)) {
					user.setPassword(newPassword);
					boolean isOK = loginService.updateUser(user);
					if (isOK) {
						result = new OkeResult<>(true, LoginStateEnum.SUCCESS_UPDATE.getStateInfo());
						student.setUser(user);
						redisTemplate.opsForValue().set("student:" + student.getStudentId(), student);
					} else {
						result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
					}
				} else {
					result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
				}
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 老师退出登陆
	 * @date 2020/05/25 11:19:30
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/teacher/logout",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> logoutTeacher(@RequestBody SessionData<Teacher> sessionData) {
		OkeResult<SessionData> result;
		String sessionId= sessionData.getSessionId();
		int teacherId = sessionData.getData().getTeacherId();
		try {
			redisTemplate.delete("session:" + sessionId);
			redisTemplate.delete("teacher:" + teacherId);
			result = new OkeResult<>(true, LoginStateEnum.SUCCESS_LOGOUT.getStateInfo());
		} catch (Exception e) {
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}

	/**
	 * 学生退出登陆
	 * @date 2020/05/25 11:19:30
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/student/logout",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> logoutStudent(@RequestBody SessionData<Student> sessionData) {
		OkeResult<SessionData> result;
		String sessionId= sessionData.getSessionId();
		int studentId = sessionData.getData().getStudentId();
		try {
			redisTemplate.delete("session:" + sessionId);
			redisTemplate.delete("student:" + studentId);
			result = new OkeResult<>(true, LoginStateEnum.SUCCESS_LOGOUT.getStateInfo());
		} catch (Exception e) {
			result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
		}
		return result;
	}
}
