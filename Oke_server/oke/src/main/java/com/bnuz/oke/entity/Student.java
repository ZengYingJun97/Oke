package com.bnuz.oke.entity;

/**
 * Student
 *
 * @author handsome
 * @date 2020年 05月15日 00:00:33
 */
public class Student {

	private int studentId;

	private String studentNumber;

	private String studentName;

	private String studentClass;

	private User user;

	public int getStudentId() {
		return studentId;
	}

	public void setStudentId(int studentId) {
		this.studentId = studentId;
	}

	public String getStudentNumber() {
		return studentNumber;
	}

	public void setStudentNumber(String studentNumber) {
		this.studentNumber = studentNumber;
	}

	public String getStudentName() {
		return studentName;
	}

	public void setStudentName(String studentName) {
		this.studentName = studentName;
	}

	public String getStudentClass() {
		return studentClass;
	}

	public void setStudentClass(String studentClass) {
		this.studentClass = studentClass;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	@Override
	public String toString() {
		return "Student{" +
				"studentId=" + studentId +
				", studentNumber='" + studentNumber + '\'' +
				", studentName='" + studentName + '\'' +
				", studentClass='" + studentClass + '\'' +
				", user=" + user +
				'}';
	}
}
