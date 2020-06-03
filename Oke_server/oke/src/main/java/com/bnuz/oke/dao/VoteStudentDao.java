package com.bnuz.oke.dao;

import com.bnuz.oke.entity.VoteStudent;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * VoteStudentDao
 *
 * @author handsome
 * @date 2020年 06月02日 22:29:24
 */
@Mapper
@Component
public interface VoteStudentDao {

	List<VoteStudent> queryByVoteId(int voteId);

	List<VoteStudent> queryByStudentId(int studentId);

	int insertVoteStudent(VoteStudent voteStudent);
}
