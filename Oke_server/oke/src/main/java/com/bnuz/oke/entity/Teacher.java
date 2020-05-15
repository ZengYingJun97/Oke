package com.bnuz.oke.entity;

/**
 * Teacher
 *
 * @author handsome
 * @date 2020年 05月14日 23:58:10
 */
public class Teacher {

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
}
