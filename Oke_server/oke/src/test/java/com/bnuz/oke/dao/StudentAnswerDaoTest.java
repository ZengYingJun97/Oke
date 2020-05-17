package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Question;
import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.StudentAnswer;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest
class StudentAnswerDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private StudentAnswerDao studentAnswerDao;

	@Test
	void queryByStudentIdAndCourseNumber() {
		int studentId = 1;
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		List<StudentAnswer> studentAnswerList = studentAnswerDao.queryByStudentIdAndCourseNumber(studentId, courseNumber);
		logger.info("studentAnswerList = {}", studentAnswerList);
	}

	@Test
	void queryByQuestionId() {
		int questionId = 1;
		List<StudentAnswer> studentAnswerList = studentAnswerDao.queryByQuestionId(questionId);
		logger.info("studentAnswerList = {}", studentAnswerList);
	}

	@Test
	void insertStudentAnswer() {
		Student student = new Student();
		student.setStudentId(1);
		Question question = new Question();
		question.setQuestionId(1);
		StudentAnswer studentAnswer = new StudentAnswer();
		studentAnswer.setStudent(student);
		studentAnswer.setQuestion(question);
		studentAnswer.setAnswerContent("A");
		studentAnswer.setAnswerCorrect(1);
		studentAnswer.setAnswerValue(1);
		int insertCount = studentAnswerDao.insertStudentAnswer(studentAnswer);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateStudentAnswer() {
		Student student = new Student();
		student.setStudentId(1);
		Question question = new Question();
		question.setQuestionId(1);
		StudentAnswer studentAnswer = new StudentAnswer();
		studentAnswer.setStudent(student);
		studentAnswer.setQuestion(question);
		studentAnswer.setAnswerContent("D");
		studentAnswer.setAnswerCorrect(1);
		studentAnswer.setAnswerValue(1);
		int count = studentAnswerDao.updateStudentAnswer(studentAnswer);
		logger.info("count = {}", count);
	}
}