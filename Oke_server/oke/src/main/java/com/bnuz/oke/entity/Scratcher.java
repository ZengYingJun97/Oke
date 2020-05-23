package com.bnuz.oke.entity;

import java.io.Serializable;
import java.util.List;

/**
 * Scratcher
 *
 * @author handsome
 * @date 2020年 05月15日 00:14:38
 */
public class Scratcher implements Serializable {

	private static final long serialVersionUID = -7217401108178683132L;

	private int scratcherId;

	private Course course;

	private List<Prize> prizeList;


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

	public List<Prize> getPrizeList() {
		return prizeList;
	}

	public void setPrizeList(List<Prize> prizeList) {
		this.prizeList = prizeList;
	}

	@Override
	public String toString() {
		return "Scratcher{" +
				"scratcherId=" + scratcherId +
				", course=" + course +
				", prizeList=" + prizeList +
				'}';
	}
}
