package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * Vote
 *
 * @author handsome
 * @date 2020年 06月02日 13:55:05
 */
public class Vote implements Serializable {

	private static final long serialVersionUID = -8950875829245223710L;

	private int voteId;

	private Course course;

	private String voteDescribe;

	private int voteLimitTime;

	public int getVoteId() {
		return voteId;
	}

	public void setVoteId(int voteId) {
		this.voteId = voteId;
	}

	public Course getCourse() {
		return course;
	}

	public void setCourse(Course course) {
		this.course = course;
	}

	public String getVoteDescribe() {
		return voteDescribe;
	}

	public void setVoteDescribe(String voteDescribe) {
		this.voteDescribe = voteDescribe;
	}

	public int getVoteLimitTime() {
		return voteLimitTime;
	}

	public void setVoteLimitTime(int voteLimitTime) {
		this.voteLimitTime = voteLimitTime;
	}

	@Override
	public String toString() {
		return "Vote{" +
				"voteId=" + voteId +
				", course=" + course +
				", voteDescribe='" + voteDescribe + '\'' +
				'}';
	}
}
