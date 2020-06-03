package com.bnuz.oke.service.impl;

import com.bnuz.oke.dao.*;
import com.bnuz.oke.dto.CourseRecordData;
import com.bnuz.oke.dto.VoteData;
import com.bnuz.oke.entity.*;
import com.bnuz.oke.service.CourseService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.transaction.interceptor.TransactionAspectSupport;

import java.util.Date;
import java.util.List;
import java.util.UUID;

/**
 * CourseServiceImpl
 *
 * @author handsome
 * @date 2020年 05月18日 23:48:52
 */
@Service
public class CourseServiceImpl implements CourseService {

	@Autowired
	private CourseDao courseDao;

	@Autowired
	private CourseRecordDao courseRecordDao;

	@Autowired
	private QuestionDao questionDao;

	@Autowired
	private OptionDao optionDao;

	@Autowired
	private StudentAnswerDao studentAnswerDao;

	@Autowired
	private VoteDao voteDao;

	@Autowired
	private VoteChoiceDao voteChoiceDao;

	@Autowired
	private VoteStudentDao voteStudentDao;

	@Override
	@Transactional
	public Course beginCourse(Course course) {
		String courseNumber = UUID.randomUUID().toString().replace("-", "").toUpperCase();
		course.setCourseNumber(courseNumber);
		int insertCount = courseDao.insertCourse(course);
		if (insertCount == 0) {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return null;
		}
		return courseDao.queryByNumber(courseNumber);
	}

	@Override
	public Course getCourseByCourseNumber(String courseNumber) {
		return courseDao.queryByNumber(courseNumber);
	}

	@Override
	public List<Course> getCourseByTeacherId(int teacherId) {
		return courseDao.queryByTeacherId(teacherId);
	}

	@Override
	@Transactional
	public boolean endCourse(Course course) {
		course.setCourseEndTime(new Date());
		int updateCount = courseDao.updateCourse(course);
		if (updateCount == 0) {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return false;
		}
		List<CourseRecord> courseRecordList = courseRecordDao.queryByCourseNumber(course.getCourseNumber());
		for (CourseRecord courseRecord: courseRecordList) {
			courseRecord.setOfflineTime(course.getCourseEndTime());
			updateCount = courseRecordDao.updateCourseRecord(courseRecord);
			if (updateCount == 0) {
				TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
				return false;
			}
		}
		return true;
	}

	@Override
	@Transactional
	public boolean onlineStudent(CourseRecord courseRecord) {
		int insertCount = courseRecordDao.insertCourseRecord(courseRecord);
		if (insertCount == 0) {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return false;
		}
		return true;
	}

	@Override
	public List<CourseRecordData> getStudentRecord(Course course) {
		List<CourseRecordData> courseRecordList = courseRecordDao.queryByCourseNumberWithScore(course.getCourseNumber());
		return courseRecordList;
	}

	@Override
	public CourseRecord getStudentRecordId(Course course, Student student) {
		return courseRecordDao.queryByCourseNumberAndStudentId(course.getCourseNumber(), student.getStudentId());
	}

	@Override
	@Transactional
	public Question addQuestion(Question question, List<Option> optionList) {
		int insertCount = questionDao.insertQuestion(question);
		Question resultQuestion = null;
		if (insertCount != 0) {
			for (Option option: optionList) {
				option.setQuestion(question);
				insertCount = optionDao.insertOption(option);
				if (insertCount == 0) {
					TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
					return null;
				}
			}
			resultQuestion = questionDao.queryByQuestionId(question.getQuestionId());
		} else {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return null;
		}
		return resultQuestion;
	}

	@Override
	@Transactional
	public StudentAnswer isTrueStudentAnswer(StudentAnswer studentAnswer) {
		Question question = questionDao.queryByQuestionId(studentAnswer.getQuestion().getQuestionId());
		if (question == null) {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return null;
		}
 		if (studentAnswer.getAnswerContent().equals(question.getQuestionAnswer())) {
			studentAnswer.setAnswerCorrect(1);
			studentAnswer.setAnswerValue(1);
			int insertCount = studentAnswerDao.insertStudentAnswer(studentAnswer);
			if (insertCount == 0) {
				TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
				return null;
			}
		} else {
 			studentAnswer.setAnswerCorrect(0);
			studentAnswer.setAnswerValue(0);
			int insertCount = studentAnswerDao.insertStudentAnswer(studentAnswer);
			if (insertCount == 0) {
				TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
				return null;
			}
		}
		return studentAnswer;
	}

	@Override
	public List<StudentAnswer> questionAnswerList(int questionId) {
		return studentAnswerDao.queryByQuestionId(questionId);
	}

	@Override
	@Transactional
	public VoteData addVote(Vote vote, List<VoteChoice> voteChoiceList) {
		int insertCount = voteDao.insertVote(vote);
		System.out.println(vote);
		VoteData voteData = null;
		if (insertCount != 0) {
			for (VoteChoice voteChoice: voteChoiceList) {
				voteChoice.setVote(vote);
				insertCount = voteChoiceDao.insertVoteChoice(voteChoice);
				if (insertCount == 0) {
					TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
					return voteData;
				}
			}
			voteData = new VoteData();
			voteData.setVote(vote);
			voteData.setVoteChoiceList(voteChoiceList);
		} else {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return voteData;
		}
		return voteData;
	}

	@Override
	@Transactional
	public boolean studentVote(VoteStudent voteStudent) {
		int insertCount = voteStudentDao.insertVoteStudent(voteStudent);
		if (insertCount != 0) {
			return true;
		} else {
			TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
			return false;
		}
	}

	@Override
	public List<VoteStudent> getVoteStudentList(Vote vote) {
		return voteStudentDao.queryByVoteId(vote.getVoteId());
	}

	@Override
	public List<Vote> getVoteList(Course course) {
		return voteDao.queryByCourseNumber(course.getCourseNumber());
	}
}
