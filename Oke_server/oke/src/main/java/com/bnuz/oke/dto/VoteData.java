package com.bnuz.oke.dto;

import com.bnuz.oke.entity.Vote;
import com.bnuz.oke.entity.VoteChoice;

import java.util.List;

/**
 * VoteData
 *
 * @author handsome
 * @date 2020年 06月02日 23:32:49
 */
public class VoteData {

	private Vote vote;

	private List<VoteChoice> voteChoiceList;

	public Vote getVote() {
		return vote;
	}

	public void setVote(Vote vote) {
		this.vote = vote;
	}

	public List<VoteChoice> getVoteChoiceList() {
		return voteChoiceList;
	}

	public void setVoteChoiceList(List<VoteChoice> voteChoiceList) {
		this.voteChoiceList = voteChoiceList;
	}

	@Override
	public String toString() {
		return "VoteData{" +
				"vote=" + vote +
				", voteChoiceList=" + voteChoiceList +
				'}';
	}
}
