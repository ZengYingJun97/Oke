package com.bnuz.oke.service.impl;

import com.bnuz.oke.entity.Mail;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.service.MailService;
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
class MailServiceImplTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private MailService mailService;

	@Test
	void getMailByFromUsername() {
		String username = "1701030006";
		List<Mail> mailList = mailService.getMailByFromUsername(username);
		logger.info("mailList = {}", mailList);
	}

	@Test
	void getMailByToUsername() {
		String username = "admin007";
		List<Mail> mailList = mailService.getMailByToUsername(username);
		logger.info("mailList = {}", mailList);
	}

	@Test
	void addMail() {
		User fromUser = new User();
		fromUser.setUsername("handsome");
		User toUser = new User();
		toUser.setUsername("1701030006");
		Mail mail = new Mail();
		mail.setMailTitle("测试标题");
		mail.setMailDescribe("测试描述");
		mail.setMailFromUser(fromUser);
		mail.setMailToUser(toUser);
		boolean isOk = mailService.addMail(mail);
		logger.info("isOk = {}", isOk);
	}
}