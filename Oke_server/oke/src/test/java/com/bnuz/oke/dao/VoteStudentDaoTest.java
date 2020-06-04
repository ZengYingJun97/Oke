package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Vote;
import com.bnuz.oke.entity.VoteStudent;
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
class VoteStudentDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private VoteStudentDao voteStudentDao;

	@Test
	void queryByVoteId() {
		int voteId = 1;
		List<VoteStudent> voteStudentList = voteStudentDao.queryByVoteId(voteId);
		logger.info("voteStudentList = {}", voteStudentList);
	}

	@Test
	void queryByStudentId() {
		int studentId = 1;
		List<VoteStudent> voteStudentList = voteStudentDao.queryByStudentId(studentId);
		logger.info("voteStudentList = {}", voteStudentList);
	}

	@Test
	void insertVoteStudent() {
		Vote vote = new Vote();
		vote.setVoteId(1);
		Student student = new Student();
		student.setStudentId(1);
		VoteStudent voteStudent = new VoteStudent();
		voteStudent.setVote(vote);
		voteStudent.setStudent(student);
		int insertCount = voteStudentDao.insertVoteStudent(voteStudent);
		logger.info("insertCount = {}", insertCount);
	}
}