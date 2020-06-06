package com.bnuz.oke.controller;

import com.alibaba.fastjson.JSON;
import com.bnuz.oke.api.WebSocketServer;
import com.bnuz.oke.dto.*;
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

import java.util.ArrayList;
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
					redisTemplate.opsForValue().set("copyKey:course:" + courseRandom, course.getCourseNumber());
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
					redisTemplate.delete("copyKey:course:" + sessionData.getData());
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

					List<Student> studentList = redisTemplate.opsForList().range("courseStudent:" + course.getCourseNumber(), 0, -1);
					String jsonString = JSON.toJSONString(sessionData.getData());
					redisTemplate.opsForValue().set("answerQuestion:" + question.getQuestionId(), "0:0:" + studentList.size() );

					for (Student student: studentList) {
						WebSocketServer.sendInfo(jsonString, student.getStudentId() + "");
					}
					result = new OkeResult<>(true, question.getQuestionId() + "");
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
					redisTemplate.opsForValue().set("answerQuestion:" + studentAnswer.getQuestion().getQuestionId(), correct + ":" + sum + ":" + tmp[2]);
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
				String[] tmps = answerQuestion.split(":");
				AnswerData answerData = new AnswerData();
				int total = Integer.parseInt(tmps[2]);
				int correct = Integer.parseInt(tmps[0]);
				int error = Integer.parseInt(tmps[1]) - Integer.parseInt(tmps[0]);
				int unCommitted = total - Integer.parseInt(tmps[1]);

				answerData.setTotal(total);
				answerData.setCorrect(correct);
				answerData.setError(error);
				answerData.setUnCommited(unCommitted);

				SessionData<AnswerData> stringSessionData = new SessionData<>(sessionId, answerData);
				result = new OkeResult<>(true, stringSessionData);
			} catch (Exception e) {
				logger.info("e = {}", e);
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
					List<CourseRecordData> courseRecordList = courseService.getStudentRecord(sessionData.getData());
					SessionData<List<CourseRecordData> > listSessionData = new SessionData<>(sessionId, courseRecordList);
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
					for (int i = courseList.size() - 1; i >= 0; i--) {
						if (courseList.get(i).getCourseNumber().equals(course.getCourseNumber())) {
							courseList.remove(i);
							break;
						}
					}
					courseSessionData = new SessionData<>(sessionId, courseList);
					result = new OkeResult<>(true, courseSessionData);
				}
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 获得在线学生
	 * @date 2020/06/02 13:36:21
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */        
	@RequestMapping(value = "/course/student/online",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> getOnlineStudent(@RequestBody SessionData<String> sessionData) {
		OkeResult<SessionData> result;
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
					List<Student> studentList = redisTemplate.opsForList().range("courseStudent:" + course.getCourseNumber(), 0, -1);
					SessionData<List<Student>> listSessionData = new SessionData<>(sessionId, studentList);
					result = new OkeResult<>(true, listSessionData);
				} catch (Exception e) {
					result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
				}
			}
		}
		return result;
	}

	/**
	 * 老师发布投票
	 * @date 2020/06/03 11:49:49
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/vote/add",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> addVote(@RequestBody SessionData<VoteData> sessionData) {
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
					Vote vote = sessionData.getData().getVote();
					List<VoteChoice> voteChoiceList = sessionData.getData().getVoteChoiceList();
					vote.setCourse(course);
					courseService.addVote(vote, voteChoiceList);
					String studentVote = "";
					for (int i = 0; i < voteChoiceList.size(); i++) {
						if (i != 0) {
							studentVote += ":";
						}
						studentVote += "0";
					}
					List<Student> studentList = redisTemplate.opsForList().range("courseStudent:" + course.getCourseNumber(), 0, -1);
					String jsonString = JSON.toJSONString(sessionData.getData());
					redisTemplate.opsForValue().set("studentVote:" + vote.getVoteId(), studentVote + ":" + studentList.size(), 60 * 60 * 24, TimeUnit.SECONDS);

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
	 * 学生投票
	 * @date 2020/06/03 11:59:23
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/student/vote",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> studentVote(@RequestBody SessionData<VoteStudent> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				VoteStudent voteStudent = sessionData.getData();
				courseService.studentVote(voteStudent);
				synchronized (this) {
					String studentVote = (String) redisTemplate.opsForValue().get("studentVote:" + voteStudent.getVote().getVoteId());
					String[] tmp = studentVote.split(":");
					int index = voteStudent.getVoteChoice().getVoteChoiceType().indexOf(0) - 'A';
					int number = Integer.parseInt(tmp[index]) + 1;
					studentVote = "";
					for (int i = 0; i < tmp.length; i++) {
						if (i != 0) {
							studentVote += ":";
						}
						if (i == index) {
							studentVote += number;
						} else {
							studentVote += tmp[i];
						}
					}
					redisTemplate.opsForValue().set("studentVote:" + voteStudent.getVote().getVoteId(), studentVote, 60 * 60 * 24, TimeUnit.SECONDS);
				}

				result = new OkeResult<>(true, CourseStateEnum.SUCCESS_OP.getStateInfo());
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 学生投票情况(未匿名)
	 * @date 2020/06/03 12:06:15
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/vote/situation",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> voteSituation(@RequestBody SessionData<Vote> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				List<VoteStudent> voteStudentList =  courseService.getVoteStudentList(sessionData.getData());
				SessionData<List<VoteStudent>> listSessionData = new SessionData<>(sessionId, voteStudentList);
				result = new OkeResult<>(true, listSessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 学生投票情况(匿名)
	 * @date 2020/06/03 12:06:15
	 * @author handsome
	 * @param sessionData
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.dto.SessionData>
	 */
	@RequestMapping(value = "/course/vote/situation/anonymity",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> voteSituationAnonymity(@RequestBody SessionData<Vote> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				String studentVote = (String) redisTemplate.opsForValue().get("studentVote:" + sessionData.getData().getVoteId());
				List<Integer> ints = new ArrayList<>();
				String[] tmp = studentVote.split(":");
				for (String s: tmp) {
					ints.add(Integer.parseInt(s));
				}
				SessionData<List<Integer>> listSessionData = new SessionData<>(sessionId, ints);
				result = new OkeResult<>(true, listSessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}

	/**
	 * 学生的课程列表 
	 * @date 2020/06/06 16:04:31
	 * @author handsome
	 * @param 
	 * @return com.bnuz.oke.dto.OkeResult<com.bnuz.oke.entity.CourseRecord>
	 */        
	@RequestMapping(value = "/student/course/list",
			method = RequestMethod.POST,
			produces = {"application/json;charset=UTF-8"})
	@ResponseBody
	public OkeResult<SessionData> getCourseList(@RequestBody SessionData<Student> sessionData) {
		OkeResult<SessionData> result;
		String sessionId = sessionData.getSessionId();
		String value = (String) redisTemplate.opsForValue().get("session:" + sessionId);
		if (value == null) {
			result = new OkeResult<>(false, LoginStateEnum.INVALID_OP.getStateInfo());
		} else {
			try {
				List<CourseRecord> courseRecordList = courseService.getCourseList(sessionData.getData().getStudentId());
				SessionData<List> listSessionData = new SessionData<>(sessionId, courseRecordList);
				result = new OkeResult<>(true, listSessionData);
			} catch (Exception e) {
				result = new OkeResult<>(false, OkeStateEnum.EXCEPTION_SERVER.getStateInfo());
			}
		}
		return result;
	}
}
