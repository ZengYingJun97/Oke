package com.bnuz.oke.dto;

import com.bnuz.oke.entity.User;

/**
 * UpdateUserData
 *
 * @author handsome
 * @date 2020年 05月25日 00:04:56
 */
public class UpdateUserData {

	private User user;

	private String newPassword;

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	public String getNewPassword() {
		return newPassword;
	}

	public void setNewPassword(String newPassword) {
		this.newPassword = newPassword;
	}
}
