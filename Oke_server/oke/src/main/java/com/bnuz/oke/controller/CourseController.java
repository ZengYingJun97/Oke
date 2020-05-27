package com.bnuz.oke.controller;

import com.alibaba.fastjson.JSON;
import com.bnuz.oke.api.WebSocketServer;
import com.bnuz.oke.dto.OkeResult;
import com.bnuz.oke.dto.QuestionData;
import com.bnuz.oke.dto.SessionData;
import com.bnuz.oke.entity.*;
import com.bnuz.oke.enums.CourseStateEnum;
import com.bnuz.oke.enums.LoginStateEnum;
import com.bnuz.oke.enums.OkeStateEnum;
import com.bnuz.oke.service.CourseService;
import com.bnuz.oke.uitls.RandomUitl;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.redis.core.RedisTemplate;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.concurrent.TimeUnit;

/**
 * CourseController
 *
 * @author handsome
 * @date 2020年 05月25日 23:26:43
 */
@Controller
@CrossOrigin
@RequestMapping("/oke")
public class CourseController {
	private Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private CourseService courseService;

	@Autowired
	private RedisTemplate redisTemplate;

	/**
	 * 开启课堂
	 * @date 2020/05/26 13:44:52
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/begin",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> beginCourse(@RequestBody SessionData<Course> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			value = (String) redisTemplate.opsForValue().get(("sessionCourse:" + sessionId));
			SessionData<String> stringSessionData;
			if (value == null) {
				Course course = sessionData.getData();
				try {
					course = courseService.beginCourse(course);
					String courseRandom = RandomUitl.getRandom();

					redisTemplate.opsForValue().set("sessionCourse:" + sessionId, "course:" + courseRandom, 60 * 60 * 24, TimeUnit.SECONDS);
					redisTemplate.opsForValue().set("course:" + courseRandom, course, 60 * 60 * 24, TimeUnit.SECONDS);

					stringSessionData = new SessionData<>(sessionId, courseRandom);
					result = new OkeResult<>(true, stringSessionData);
				} catch (Exception e) {
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			} else {
				stringSessionData = new SessionData<>(sessionId, value.substring(6));
				result = new OkeResult<>(true, stringSessionData);
			}
		}
		return result;
	}

	/**
	 * 结束课堂
	 * @date 2020/05/26 14:00:26
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */        
	@RequestMapping(value = "/course/end",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> endCourse(@RequestBody SessionData<String> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			Course course = (Course) redisTemplate.opsForValue().get("course:" + sessionData.getData());
			if (course == null) {
				result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
			} else {
				try {
					courseService.endCourse(course);
					redisTemplate.delete("sessionCourse:" + sessionId);
					redisTemplate.delete("course:" + sessionData.getData());
					redisTemplate.delete("courseStudent:" + course.getCourseNumber());
					result = new OkeResult<>(true, CourseStateEnum.SUCCESS_OP.getStateInfo());
				} catch (Exception e) {
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			}
		}
		return result;
	}

	/**
	 * 学生上课
	 * @date 2020/05/26 15:53:36
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/entry",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> entryCourse(@RequestBody SessionData<String> sessionData) {
		OkeResult<SessionData> result;
		sessionData.setData(sessionData.getData().toUpperCase());
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			Course course = (Course) redisTemplate.opsForValue().get("course:" + sessionData.getData());
			if (course == null) {
				result = new OkeResult<>(false, CourseStateEnum.NULL_COURSE.getStateInfo());
			} else {
				try {
					SessionData<Course> stringSessionData = new SessionData<>(sessionId, course);

					Student student = (Student) redisTemplate.opsForValue().get(value);
					CourseRecord courseRecord = new CourseRecord();
					courseRecord.setCourse(course);
					courseRecord.setStudent(student);

					CourseRecord hasRecord = courseService.getStudentRecordId(course, student);
					if (hasRecord == null) {
						courseService.onlineStudent(courseRecord);
						redisTemplate.opsForList().leftPush("courseStudent:" + course.getCourseNumber(), student);
					}
					result = new OkeResult<>(true, stringSessionData);
				} catch (Exception e) {
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			}
		}
		return result;
	}

	/**
	 * 老师发布题目
	 * @date 2020/05/26 16:25:45
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/question/add",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> addQuestion(@RequestBody SessionData<QuestionData> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			String courseRandom = (String) redisTemplate.opsForValue().get("sessionCourse:" + sessionId);
			if (courseRandom == null) {
				result = new OkeResult<>(false, CourseStateEnum.NULL_COURSE.getStateInfo());
			} else {
				try {
					Course course = (Course) redisTemplate.opsForValue().get(courseRandom);
					Question question = sessionData.getData().getQuestion();
					List<Option> optionList = sessionData.getData().getOptionList();
					question.setCourse(course);
					courseService.addQuestion(question, optionList);

					redisTemplate.opsForValue().set("answerQuestion:" + question.getQuestionId(), "0:0");

					List<Student> studentList = redisTemplate.opsForList().range("courseStudent:" + course.getCourseNumber(), 0, -1);
					String jsonString = JSON.toJSONString(sessionData.getData());

					for (Student student: studentList) {
						WebSocketServer.sendInfo(jsonString, student.getStudentId() + "");
					}
					result = new OkeResult<>(true, CourseStateEnum.SUCCESS_OP.getStateInfo());
				} catch (Exception e){
					logger.info("e = {}", e);
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			}
		}
		return result;
	}

	/**
	 * 学生回答问题
	 * @date 2020/05/26 17:10:25
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/question/answer",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> answerQuestion(@RequestBody SessionData<StudentAnswer> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				StudentAnswer studentAnswer = sessionData.getData();
				courseService.isTrueStudentAnswer(studentAnswer);
				synchronized (this) {
					String answerQuestion = (String) redisTemplate.opsForValue().get("answerQuestion:" + studentAnswer.getQuestion().getQuestionId());
					String[] tmp = answerQuestion.split(":");
					int correct = Integer.valueOf(tmp[0]);
					int sum = Integer.valueOf(tmp[1]) + 1;
					if (studentAnswer.getAnswerCorrect() == 1) {
						correct++;
					}
					redisTemplate.opsForValue().set("answerQuestion:" + studentAnswer.getQuestion().getQuestionId(), correct + ":" + sum);
				}

				result = new OkeResult<>(true, CourseStateEnum.SUCCESS_OP.getStateInfo());
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 获得学生答题情况
	 * @date 2020/05/26 17:38:04
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/question/answerlist",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> questionAnswer(@RequestBody SessionData<Question> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				String answerQuestion = (String) redisTemplate.opsForValue().get("answerQuestion:" + sessionData.getData().getQuestionId());
				SessionData<String> stringSessionData = new SessionData<>(sessionId, answerQuestion);
				result = new OkeResult<>(true, stringSessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 学生上课记录
	 * @date 2020/05/26 17:51:40
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/record/list",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> onlineStudentList(@RequestBody SessionData<Course> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			value = (String) redisTemplate.opsForValue().get("sessionCourse:" + sessionId);
			if (value == null) {
				try {
					List<CourseRecord> courseRecordList = courseService.getStudentRecord(sessionData.getData());
					SessionData<List<CourseRecord> > listSessionData = new SessionData<>(sessionId, courseRecordList);
					result = new OkeResult<>(true, listSessionData);
				} catch (Exception e) {
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			} else {
				result = new OkeResult<>(false, CourseStateEnum.COURSE_ONLINE.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 获得课程列表 
	 * @date 2020/05/26 20:21:58
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */        
	@RequestMapping(value = "/course/list",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> courseList(@RequestBody SessionData<Teacher> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				value = (String) redisTemplate.opsForValue().get("sessionCourse:" + sessionId);
				List<Course> courseList = courseService.getCourseByTeacherId(sessionData.getData().getTeacherId());
				SessionData<List<Course> > courseSessionData;
				if (value == null) {
					courseSessionData = new SessionData<>(sessionId, courseList);
					result = new OkeResult<>(true, courseSessionData);
				} else {
					String courseRandom = (String) redisTemplate.opsForValue().get("sessionCourse:" + sessionId);
					Course course = (Course) redisTemplate.opsForValue().get(courseRandom);
					courseSessionData = new SessionData<>(sessionId, courseList);
					result = new OkeResult<>(true, courseSessionData);
				}
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}
}
