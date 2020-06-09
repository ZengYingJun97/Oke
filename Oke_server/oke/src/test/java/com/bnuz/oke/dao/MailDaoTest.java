package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Mail;
import com.bnuz.oke.entity.User;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
class MailDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private MailDao mailDao;

	@Test
	void queryByFromUsername() {
		String username = "1701030006";
		List<Mail> mailList = mailDao.queryByFromUsername(username);
		logger.info("mailList = {}", mailList);
	}

	@Test
	void queryByToUsername() {
		String username = "admin007";
		List<Mail> mailList = mailDao.queryByToUsername(username);
		logger.info("mailList = {}", mailList);
	}

	@Test
	void insertMail() {
		User fromUser = new User();
		fromUser.setUsername("1701030006");
		User toUser = new User();
		toUser.setUsername("admin007");
		Mail mail = new Mail();
		mail.setMailTitle("测试标题");
		mail.setMailDescribe("测试描述");
		mail.setMailFromUser(fromUser);
		mail.setMailToUser(toUser);
		mailDao.insertMail(mail);
		logger.info("mail = {}", mail);
	}
}