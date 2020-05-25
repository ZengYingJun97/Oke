package com.bnuz.oke.entity;

import java.io.Serializable;
import java.util.Date;

/**
 * Course
 *
 * @author handsome
 * @date 2020年 05月15日 00:02:34
 */
public class Course implements Serializable {

	private static final long serialVersionUID = 830830966765014573L;

	private String courseNumber;

	private String courseName;

	private Date courseCreateTime;

	private Date courseEndTime;

	private Teacher teacher;

	public String getCourseNumber() {
		return courseNumber;
	}

	public void setCourseNumber(String courseNumber) {
		this.courseNumber = courseNumber;
	}

	public String getCourseName() {
		return courseName;
	}

	public void setCourseName(String courseName) {
		this.courseName = courseName;
	}

	public Date getCourseCreateTime() {
		return courseCreateTime;
	}

	public void setCourseCreateTime(Date courseCreateTime) {
		this.courseCreateTime = courseCreateTime;
	}

	public Date getCourseEndTime() {
		return courseEndTime;
	}

	public void setCourseEndTime(Date courseEndTime) {
		this.courseEndTime = courseEndTime;
	}

	public Teacher getTeacher() {
		return teacher;
	}

	public void setTeacher(Teacher teacher) {
		this.teacher = teacher;
	}

	@Override
	public String toString() {
		return "Course{" +
				"courseNumber='" + courseNumber + '\'' +
				", courseName='" + courseName + '\'' +
				", courseCreateTime=" + courseCreateTime +
				", courseEndTime=" + courseEndTime +
				", teacher=" + teacher +
				'}';
	}
}
