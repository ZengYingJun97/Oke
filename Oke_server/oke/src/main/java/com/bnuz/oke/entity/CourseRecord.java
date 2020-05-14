package com.bnuz.oke.entity;

import java.util.Date;

/**
 * CourseRecord
 *
 * @author handsome
 * @date 2020年 05月15日 00:05:47
 */
public class CourseRecord {

	private Course course;

	private Student student;

	private Date onlineTime;

	private Date offlineTime;

	public Course getCourse() {
		return course;
	}

	public void setCourse(Course course) {
		this.course = course;
	}

	public Student getStudent() {
		return student;
	}

	public void setStudent(Student student) {
		this.student = student;
	}

	public Date getOnlineTime() {
		return onlineTime;
	}

	public void setOnlineTime(Date onlineTime) {
		this.onlineTime = onlineTime;
	}

	public Date getOfflineTime() {
		return offlineTime;
	}

	public void setOfflineTime(Date offlineTime) {
		this.offlineTime = offlineTime;
	}
}
