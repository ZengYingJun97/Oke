package com.bnuz.oke.dao;

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
class UserDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private UserDao userDao;

	@Test
	void queryByUsername() {
		String username = "admin";
		String password = "admin";
		logger.info("login success? {}", userDao.queryByUsername(username).getPassword().equals(password));
	}

	@Test
	void insertUser() {
		User user = new User();
		user.setUsername("admin");
		user.setPassword("admin");
		userDao.insertUser(user);
		logger.info("success insert");
	}

	@Test
	void updateUser() {
		User user = new User();
		user.setUsername("admin");
		user.setPassword("123456");
		int count = userDao.updateUser(user);
		logger.info("count = {}", count);
	}
}