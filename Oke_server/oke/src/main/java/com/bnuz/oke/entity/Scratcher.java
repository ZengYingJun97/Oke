package com.bnuz.oke.entity;

/**
 * Scratcher
 *
 * @author handsome
 * @date 2020年 05月15日 00:14:38
 */
public class Scratcher {

	private int scratcherId;

	private Course course;


	public int getScratcherId() {
		return scratcherId;
	}

	public void setScratcherId(int scratcherId) {
		this.scratcherId = scratcherId;
	}

	public Course getCourse() {
		return course;
	}

	public void setCourse(Course course) {
		this.course = course;
	}

	@Override
	public String toString() {
		return "Scratcher{" +
				"scratcherId=" + scratcherId +
				", course=" + course +
				'}';
	}
}
