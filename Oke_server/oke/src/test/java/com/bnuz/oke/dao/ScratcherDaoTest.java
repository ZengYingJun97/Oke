package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.entity.Scratcher;
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
class ScratcherDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private ScratcherDao scratcherDao;

	@Test
	void queryByCourseNumber() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		List<Scratcher> scratcherList = scratcherDao.queryByCourseNumber(courseNumber);
		logger.info("scratcherList = {}", scratcherList);
	}

	@Test
	void queryByScratcherId() {
		int scratcherId = 1;
		Scratcher scratcher = scratcherDao.queryByScratcherId(scratcherId);
		logger.info("scratcher = {}", scratcher);
	}

	@Test
	void insertScratcher() {
		Course course = new Course();
		course.setCourseNumber("B089E222B33146E98210ACA687EB5D9D");
		Scratcher scratcher = new Scratcher();
		scratcher.setCourse(course);
		int insertCount = scratcherDao.insertScratcher(scratcher);
		logger.info("insertCount = {}", insertCount);
	}
}