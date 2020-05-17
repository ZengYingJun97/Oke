package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Prize;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * PrizeDao
 *
 * @author handsome
 * @date 2020年 05月17日 23:48:38
 */
@Mapper
@Component
public interface PrizeDao {

	List<Prize> queryByScratcherId(int scratcherId);

	Prize queryByPrizeId(int prizeId);

	int insertPrize(Prize prize);

	int updatePrize(Prize prize);

	int deletePrize(Prize prize);
}
