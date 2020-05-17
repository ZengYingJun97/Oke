package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Student;
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
class StudentDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private StudentDao studentDao;

	@Test
	void queryByUsername() {
		String username = "1701030006";
		Student student = studentDao.queryByUsername(username);
		logger.info("student = {}", student);
	}

	@Test
	void queryById() {
		int studentId = 1;
		Student student = studentDao.queryById(studentId);
		logger.info("student = {}", student);
	}

	@Test
	void insertStudent() {
		Student student = new Student();
		student.setStudentNumber("1701030006");
		student.setStudentName("曾英俊");
		student.setStudentClass("17软件2班");
		User user = new User();
		user.setUsername("1701030006");
		student.setUser(user);
		int studentId = studentDao.insertStudent(student);
	}

	@Test
	void updateStudent() {
		Student student = new Student();
		student.setStudentId(1);
		student.setStudentName("张三");
		student.setStudentNumber("ddj_zz001");
		student.setStudentClass("李姐");
		int count = studentDao.updateStudent(student);
		logger.info("count = {}", count);
	}
}