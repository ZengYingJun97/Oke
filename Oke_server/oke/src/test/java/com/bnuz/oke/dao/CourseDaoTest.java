package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.entity.Teacher;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.Date;
import java.util.List;
import java.util.UUID;

@RunWith(SpringRunner.class)
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
class CourseDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private CourseDao courseDao;

	@Test
	void queryByNumber() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		Course course = courseDao.queryByNumber(courseNumber);
		logger.info("course = {}", course);
	}

	@Test
	void insertCourse() {
		String courseNumber = UUID.randomUUID().toString().replace("-", "").toUpperCase();
		Course course = new Course();
		course.setCourseNumber(courseNumber);
		course.setCourseName(".Net");
		Teacher teacher = new Teacher();
		teacher.setTeacherId(1);
		course.setTeacher(teacher);
		int insertCount = courseDao.insertCourse(course);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateCourse() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		Course course = new Course();
		course.setCourseNumber(courseNumber);
		course.setCourseEndTime(new Date());
		int count = courseDao.updateCourse(course);
		logger.info("count = {}", count);
	}

	@Test
	void queryByTeacherId() {
		int teacherId = 1;
		List<Course> courseList = courseDao.queryByTeacherId(teacherId);
		logger.info("courseList = {}", courseList);
	}
}