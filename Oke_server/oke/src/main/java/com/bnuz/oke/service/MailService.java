package com.bnuz.oke.service;

import com.bnuz.oke.entity.Mail;

import java.util.List;

/**
 * MailService
 *
 * @author handsome
 * @date 2020年 06月09日 12:08:02
 */
public interface MailService {

	List<Mail> getMailByFromUsername(String username);

	List<Mail> getMailByToUsername(String username);

	boolean addMail(Mail mail);
}
