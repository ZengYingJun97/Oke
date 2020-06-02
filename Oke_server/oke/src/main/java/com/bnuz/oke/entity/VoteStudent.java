package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * VoteStudent
 *
 * @author handsome
 * @date 2020年 06月02日 13:59:19
 */
public class VoteStudent implements Serializable {

	private static final long serialVersionUID = 697839377051194910L;

	private Student student;

	private Vote vote;

	public Student getStudent() {
		return student;
	}

	public void setStudent(Student student) {
		this.student = student;
	}

	public Vote getVote() {
		return vote;
	}

	public void setVote(Vote vote) {
		this.vote = vote;
	}

	@Override
	public String toString() {
		return "VoteStudent{" +
				"student=" + student +
				", vote=" + vote +
				'}';
	}
}
