package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.entity.Question;
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
class QuestionDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private QuestionDao questionDao;

	@Test
	void queryByCourseNumber() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		List<Question> quesionList = questionDao.queryByCourseNumber(courseNumber);
		logger.info("quesionList = {}", quesionList);
	}

	@Test
	void queryByQuestionId() {
		int questionId = 1;
		Question question = questionDao.queryByQuestionId(questionId);
		logger.info("question = {}", question);
	}

	@Test
	void insertQuestion() {
		Question question = new Question();
		Course course = new Course();
		course.setCourseNumber("B089E222B33146E98210ACA687EB5D9D");
		question.setCourse(course);
		question.setQuestionType(0);
		question.setQuestionDescribe("我国国家机关组织和活动的最基本的原则是()");
		question.setQuestionAnswer("B");
		question.setQuestionScore(5);
		question.setQuestionLimitTime(60);
		int insertCount = questionDao.insertQuestion(question);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateQuestion() {
		Question question = new Question();
		question.setQuestionId(1);
		question.setQuestionDescribe("根据我国现行《宪法》的规定，下列有关公民基本权利宪法保护的表述，正确的是()");
		question.setQuestionAnswer("D");
		question.setQuestionScore(10);
		question.setQuestionLimitTime(120);
		int count = questionDao.updateQuestion(question);
		logger.info("count = {}", count);
	}
}