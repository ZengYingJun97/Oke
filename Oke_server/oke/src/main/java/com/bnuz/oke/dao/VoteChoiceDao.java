package com.bnuz.oke.dao;

import com.bnuz.oke.entity.VoteChoice;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * VoteChoiceDao
 *
 * @author handsome
 * @date 2020年 06月02日 17:37:15
 */
@Mapper
@Component
public interface VoteChoiceDao {

	List<VoteChoice> queryByVoteId(int voteId);

	VoteChoice queryByVoteChoiceId(int voteChoiceId);

	int insertVoteChoice(VoteChoice voteChoice);

	int updateVoteChoice(VoteChoice voteChoice);
}
