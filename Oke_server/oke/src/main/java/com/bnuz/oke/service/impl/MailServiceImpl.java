package com.bnuz.oke.service.impl;

import com.bnuz.oke.dao.MailDao;
import com.bnuz.oke.entity.Mail;
import com.bnuz.oke.service.MailService;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

/**
 * MailServiceImpl
 *
 * @author handsome
 * @date 2020年 06月09日 12:11:59
 */
@Service
public class MailServiceImpl implements MailService {
	private final Logger logger = LoggerFactory.getLogger(MailServiceImpl.class);

	@Autowired
	private MailDao mailDao;

	@Override
	public List<Mail> getMailByFromUsername(String username) {
		return mailDao.queryByFromUsername(username);
	}

	@Override
	public List<Mail> getMailByToUsername(String username) {
		return mailDao.queryByToUsername(username);
	}

	@Override
	public boolean addMail(Mail mail) {
		try {
			int insertCount = mailDao.insertMail(mail);
			return insertCount== 1;
		} catch (Exception e) {
			logger.info("e = {}", e);
			return false;
		}
	}
}
