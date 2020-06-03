package com.bnuz.oke.dto;

import com.bnuz.oke.entity.CourseRecord;

import java.io.Serializable;

/**
 * CourseRecordData
 *
 * @author handsome
 * @date 2020年 06月03日 16:17:50
 */
public class CourseRecordData implements Serializable {

	private static final long serialVersionUID = 3657770820939183637L;

	private CourseRecord courseRecord;

	private int score;

	public CourseRecord getCourseRecord() {
		return courseRecord;
	}

	public void setCourseRecord(CourseRecord courseRecord) {
		this.courseRecord = courseRecord;
	}

	public int getScore() {
		return score;
	}

	public void setScore(int score) {
		this.score = score;
	}

	@Override
	public String toString() {
		return "CourseRecordData{" +
				"courseRecord=" + courseRecord +
				", score=" + score +
				'}';
	}
}
