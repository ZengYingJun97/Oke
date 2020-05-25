package com.bnuz.oke.entity;

import java.io.Serializable;
import java.util.Date;

/**
 * CourseRecord
 *
 * @author handsome
 * @date 2020年 05月15日 00:05:47
 */
public class CourseRecord implements Serializable {

	private static final long serialVersionUID = -3338693164709439041L;

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

	@Override
	public String toString() {
		return "CourseRecord{" +
				"course=" + course +
				", student=" + student +
				", onlineTime=" + onlineTime +
				", offlineTime=" + offlineTime +
				'}';
	}
}
