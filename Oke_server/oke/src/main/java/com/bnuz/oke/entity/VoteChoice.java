package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * VoteChoice
 *
 * @author handsome
 * @date 2020年 06月02日 13:56:52
 */
public class VoteChoice implements Serializable {

	private static final long serialVersionUID = 7969519398643670192L;

	private int voteChoiceId;

	private Vote vote;

	private String voteChoiceType;

	private String voteChoiceDescribe;

	public int getVoteChoiceId() {
		return voteChoiceId;
	}

	public void setVoteChoiceId(int voteChoiceId) {
		this.voteChoiceId = voteChoiceId;
	}

	public Vote getVote() {
		return vote;
	}

	public void setVote(Vote vote) {
		this.vote = vote;
	}

	public String getVoteChoiceType() {
		return voteChoiceType;
	}

	public void setVoteChoiceType(String voteChoiceType) {
		this.voteChoiceType = voteChoiceType;
	}

	public String getVoteChoiceDescribe() {
		return voteChoiceDescribe;
	}

	public void setVoteChoiceDescribe(String voteChoiceDescribe) {
		this.voteChoiceDescribe = voteChoiceDescribe;
	}

	@Override
	public String toString() {
		return "VoteChoice{" +
				"voteChoiceId=" + voteChoiceId +
				", vote=" + vote +
				", voteChoiceType='" + voteChoiceType + '\'' +
				", voteChoiceDescribe='" + voteChoiceDescribe + '\'' +
				'}';
	}
}
