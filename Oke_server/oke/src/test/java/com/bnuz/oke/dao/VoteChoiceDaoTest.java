package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Vote;
import com.bnuz.oke.entity.VoteChoice;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
class VoteChoiceDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private VoteChoiceDao voteChoiceDao;

	@Test
	void queryByVoteId() {
		int voteId = 1;
		List<VoteChoice> voteChoiceList = voteChoiceDao.queryByVoteId(voteId);
		logger.info("voteChoiceList = {}", voteChoiceList);
	}

	@Test
	void queryByVoteChoiceId() {
		int voteChoiceId = 1;
		VoteChoice voteChoice = voteChoiceDao.queryByVoteChoiceId(voteChoiceId);
		logger.info("voteChoice = {}", voteChoice);
	}

	@Test
	void insertVoteChoice() {
		Vote vote = new Vote();
		vote.setVoteId(1);
		VoteChoice voteChoice = new VoteChoice();
		voteChoice.setVote(vote);
		voteChoice.setVoteChoiceType("B");
		voteChoice.setVoteChoiceDescribe("否");
		int insertCount = voteChoiceDao.insertVoteChoice(voteChoice);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateVoteChoice() {
		VoteChoice voteChoice = new VoteChoice();
		voteChoice.setVoteChoiceId(2);
		voteChoice.setVoteChoiceType("B");
		voteChoice.setVoteChoiceDescribe("否");
		int updateCount = voteChoiceDao.updateVoteChoice(voteChoice);
		logger.info("updateCount = {}", updateCount);
	}
}