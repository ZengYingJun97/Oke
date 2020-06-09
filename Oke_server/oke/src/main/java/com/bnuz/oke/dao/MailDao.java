package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Mail;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * MailDao
 *
 * @author handsome
 * @date 2020年 06月09日 11:14:01
 */
@Mapper
@Component
public interface MailDao {

	List<Mail> queryByFromUsername(String username);

	List<Mail> queryByToUsername(String username);

	int insertMail(Mail mail);
}
