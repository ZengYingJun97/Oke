package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * Mail
 *
 * @author handsome
 * @date 2020年 06月09日 11:11:53
 */
public class Mail implements Serializable {

	private static final long serialVersionUID = 2113025072512738080L;

	private int mailId;

	private String mailTitle;

	private String mailDescribe;

	private User mailFromUser;

	private User mailToUser;

	public int getMailId() {
		return mailId;
	}

	public void setMailId(int mailId) {
		this.mailId = mailId;
	}

	public String getMailTitle() {
		return mailTitle;
	}

	public void setMailTitle(String mailTitle) {
		this.mailTitle = mailTitle;
	}

	public String getMailDescribe() {
		return mailDescribe;
	}

	public void setMailDescribe(String mailDescribe) {
		this.mailDescribe = mailDescribe;
	}

	public User getMailFromUser() {
		return mailFromUser;
	}

	public void setMailFromUser(User mailFromUser) {
		this.mailFromUser = mailFromUser;
	}

	public User getMailToUser() {
		return mailToUser;
	}

	public void setMailToUser(User mailToUser) {
		this.mailToUser = mailToUser;
	}

	@Override
	public String toString() {
		return "Mail{" +
				"mailId=" + mailId +
				", mailTitle='" + mailTitle + '\'' +
				", mailDescribe='" + mailDescribe + '\'' +
				", mailFromUser=" + mailFromUser +
				", mailToUser=" + mailToUser +
				'}';
	}
}
