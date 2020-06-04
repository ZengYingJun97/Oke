package com.bnuz.oke.dao;

import com.bnuz.oke.dto.CourseRecordData;
import com.bnuz.oke.entity.Course;
import com.bnuz.oke.entity.CourseRecord;
import com.bnuz.oke.entity.Student;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.Date;
import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
class CourseRecordDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private CourseRecordDao courseRecordDao;

	@Test
	void queryByCourseNumber() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		List<CourseRecord> courseRecordList = courseRecordDao.queryByCourseNumber(courseNumber);
		logger.info("courseRecordList = {}", courseRecordList);
	}

	@Test
	void queryByStudentId() {
		int studentId = 1;
		List<CourseRecord> courseRecordList = courseRecordDao.queryByStudentId(studentId);
		logger.info("courseRecordList = {}", courseRecordList);
	}

	@Test
	void insertCourseRecord() {
		CourseRecord courseRecord = new CourseRecord();
		Course course = new Course();
		course.setCourseNumber("B089E222B33146E98210ACA687EB5D9D");
		courseRecord.setCourse(course);
		Student student = new Student();
		student.setStudentId(1);
		courseRecord.setStudent(student);
		int insertCount = courseRecordDao.insertCourseRecord(courseRecord);
		logger.info("insertCount = {}", courseRecord);
	}

	@Test
	void updateCourseRecord() {
		CourseRecord courseRecord = new CourseRecord();
		Course course = new Course();
		course.setCourseNumber("B089E222B33146E98210ACA687EB5D9D");
		courseRecord.setCourse(course);
		Student student = new Student();
		student.setStudentId(1);
		courseRecord.setStudent(student);
		courseRecord.setOfflineTime(new Date());
		int count = courseRecordDao.updateCourseRecord(courseRecord);
		logger.info("count = {}", count);
	}

	@Test
	void queryByCourseNumberAndStudentId() {
		String courseNumber = "3384CBB8AAC34A2C9895F0A6DE27AB3C";
		int studentId = 6;
		CourseRecord courseRecord = courseRecordDao.queryByCourseNumberAndStudentId(courseNumber, studentId);
		logger.info("courseRecord = {}", courseRecord);
	}

	@Test
	void queryByCourseNumberWithScore() {
		String courseNumber = "B089E222B33146E98210ACA687EB5D9D";
		List<CourseRecordData> courseRecordDataList = courseRecordDao.queryByCourseNumberWithScore(courseNumber);
		logger.info("courseRecordDataList = {}", courseRecordDataList);
 	}
}