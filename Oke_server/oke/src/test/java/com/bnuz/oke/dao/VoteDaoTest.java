package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Course;
import com.bnuz.oke.entity.Vote;
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
class VoteDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private VoteDao voteDao;

	@Test
	void queryByCourseNumber() {
		String courseNumber = "3384CBB8AAC34A2C9895F0A6DE27AB3C";
		List<Vote> voteList = voteDao.queryByCourseNumber(courseNumber);
		logger.info("voteList = {}", voteList);
	}

	@Test
	void queryByVoteId() {
		int voteId = 1;
		Vote vote = voteDao.queryByVoteId(voteId);
		logger.info("vote = {}", vote);
	}

	@Test
	void insertVote() {
		String courseNumber = "3384CBB8AAC34A2C9895F0A6DE27AB3C";
		Course course = new Course();
		course.setCourseNumber(courseNumber);
		Vote vote = new Vote();
		vote.setCourse(course);
		vote.setVoteDescribe("曾小课想上班吗");
		vote.setVoteLimitTime(60);
		int insertCount = voteDao.insertVote(vote);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updateVote() {
		Vote vote = new Vote();
		vote.setVoteId(1);
		vote.setVoteDescribe("曾小课想上学吗");
		int updateCount = voteDao.updateVote(vote);
		logger.info("updateCount = {}", updateCount);
	}
}