package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Option;
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
class OptionDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private OptionDao optionDao;

	@Test
	void queryByQuestionId() {
		int questionId = 1;
		List<Option> optionList = optionDao.queryByQuestionId(questionId);
		logger.info("optionList = {}", optionList);
	}

	@Test
	void queryByOptionId() {
		int optionId = 2;
		Option option = optionDao.queryByOptionId(optionId);
		logger.info("option = {}", option);
	}

	@Test
	void insertOption() {
		Question question = new Question();
		question.setQuestionId(1);
		Option option1 = new Option();
		option1.setQuestion(question);
		option1.setOptionType("A");
		option1.setOptionDescribe("所有公民都有选举权和被选举权");
		Option option2 = new Option();
		option2.setQuestion(question);
		option2.setOptionType("B");
		option2.setOptionDescribe("宪法没有规定对归侨权益的保护");
		Option option3 = new Option();
		option3.setQuestion(question);
		option3.setOptionType("C");
		option3.setOptionDescribe("宪法对建立劳动者休息和休养的设施未加以规定");
		Option option4 = new Option();
		option4.setQuestion(question);
		option4.setOptionType("D");
		option4.setOptionDescribe("宪法规定公民的住宅不受侵犯");
		int insertCount = optionDao.insertOption(option1);
		insertCount += optionDao.insertOption(option2);
		insertCount += optionDao.insertOption(option3);
		insertCount += optionDao.insertOption(option4);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateOption() {
		Option option = new Option();
		option.setOptionId(1);
		option.setOptionDescribe("所有公民都有选举权和被选举权");
		int count = optionDao.updateOption(option);
	}
}