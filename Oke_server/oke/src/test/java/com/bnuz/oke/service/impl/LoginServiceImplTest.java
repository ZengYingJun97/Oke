package com.bnuz.oke.service.impl;

import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.service.LoginService;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

@RunWith(SpringRunner.class)
@SpringBootTest
class LoginServiceImplTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private LoginService loginService;

	@Test
	void registerStudent() {
		User user = new User();
		user.setUsername("IamGuang");
		user.setPassword("test123");
		Student student = new Student();
		student.setUser(user);
		student.setStudentNumber("PDU001");
		student.setStudentName("Guang");
		student.setStudentClass("C++");
		boolean registerSuccess = loginService.registerStudent(student);
		logger.info("registerSuccess = {}", registerSuccess);
	}

	@Test
	void registerTeacher() {
		User user = new User();
		user.setUsername("IamDuang");
		user.setPassword("test123");
		Teacher teacher = new Teacher();
		teacher.setUser(user);
		teacher.setTeacherName("Duang");
		teacher.setTeacherTitle("硕士导师");
		boolean registerSuccess = loginService.registerTeacher(teacher);
		logger.info("registerSuccess = {}", registerSuccess);
	}

	@Test
	void loginStudent() {
		User user = new User();
		user.setUsername("IamGuang");
		user.setPassword("test123");
		Student student = loginService.loginStudent(user);
		if (student != null && student.getUser().getPassword().equals(user.getPassword())) {
			logger.info("登陆成功！");
		} else {
			logger.info("登陆失败！");
		}
	}

	@Test
	void loginTeacher() {
		User user = new User();
		user.setUsername("admin");
		user.setPassword("123456");
		Teacher teacher = loginService.loginTeacher(user);
		if (teacher != null && teacher.getUser().getPassword().equals(user.getPassword())) {
			logger.info("登陆成功！");
		} else {
			logger.info("登陆失败！");
		}
	}
}