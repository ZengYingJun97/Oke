package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import static org.junit.jupiter.api.Assertions.*;

@RunWith(SpringRunner.class)
@SpringBootTest
class TeacherDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private TeacherDao teacherDao;

	@Test
	void queryByUsername() {

	}

	@Test
	void insertTeacher() {
		Teacher teacher = new Teacher();
		teacher.setTeacherName("鲍勃");
		teacher.setTeacherTitle("班主任");
		User user = new User();
		user.setUsername("admin");
		teacher.setUser(user);
		int teacherId = teacherDao.insertTeacher(teacher);
		logger.info("teacherId = {}", teacherId);
	}

	@Test
	void updateTeacher() {
	}
}