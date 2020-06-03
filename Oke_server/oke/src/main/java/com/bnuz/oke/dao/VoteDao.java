package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Vote;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * VoteDao
 *
 * @author handsome
 * @date 2020年 06月02日 14:06:02
 */
@Mapper
@Component
public interface VoteDao {

	List<Vote> queryByCourseNumber(String courseNumber);

	Vote queryByVoteId(int voteId);

	int insertVote(Vote vote);

	int updateVote(Vote vote);
}
