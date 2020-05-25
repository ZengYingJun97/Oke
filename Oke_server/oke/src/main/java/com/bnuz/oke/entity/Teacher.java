package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * Teacher
 *
 * @author handsome
 * @date 2020年 05月14日 23:58:10
 */
public class Teacher implements Serializable {

	private static final long serialVersionUID = -194261173474839551L;

	private int teacherId;

	private String teacherName;

	private String teacherTitle;

	private User user;

	public int getTeacherId() {
		return teacherId;
	}

	public void setTeacherId(int teacherId) {
		this.teacherId = teacherId;
	}

	public String getTeacherName() {
		return teacherName;
	}

	public void setTeacherName(String teacherName) {
		this.teacherName = teacherName;
	}

	public String getTeacherTitle() {
		return teacherTitle;
	}

	public void setTeacherTitle(String teacherTitle) {
		this.teacherTitle = teacherTitle;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	@Override
	public String toString() {
		return "Teacher{" +
				"teacherId=" + teacherId +
				", teacherName='" + teacherName + '\'' +
				", teacherTitle='" + teacherTitle + '\'' +
				", user=" + user +
				'}';
	}
}
