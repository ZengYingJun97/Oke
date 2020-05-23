package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * User
 *
 * @author handsome
 * @date 2020年 05月14日 23:56:54
 */
public class User implements Serializable {

	private static final long serialVersionUID = 2547923461654131204L;

	private String username;

	private String password;

	public String getUsername() {
		return username;
	}

	public void setUsername(String username) {
		this.username = username;
	}

	public String getPassword() {
		return password;
	}

	public void setPassword(String password) {
		this.password = password;
	}

	@Override
	public String toString() {
		return "User{" +
				"username='" + username + '\'' +
				", password='" + password + '\'' +
				'}';
	}
}
