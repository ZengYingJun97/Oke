package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Prize;
import com.bnuz.oke.entity.Scratcher;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest
class PrizeDaoTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private PrizeDao prizeDao;

	@Test
	void queryByScratcherId() {
		int scratcherId = 1;
		List<Prize> prizeList = prizeDao.queryByScratcherId(scratcherId);
		logger.info("prizeList = {}", prizeList);
	}

	@Test
	void queryByPrizeId() {
		int prizeId = 1;
		Prize prize = prizeDao.queryByPrizeId(prizeId);
		logger.info("prize = {}", prize);
	}

	@Test
	void insertPrize() {
		Scratcher scratcher = new Scratcher();
		scratcher.setScratcherId(1);
		Prize prize = new Prize();
		prize.setScratcher(scratcher);
		prize.setPrizeDescribe("寒假作业");
		prize.setPrizeCount(10);
		int insertCount = prizeDao.insertPrize(prize);
		logger.info("insertCount = {}", insertCount);
	}

	@Test
	void updatePrize() {
		Prize prize = new Prize();
		prize.setPrizeId(1);
		prize.setPrizeCount(10);
		int count = prizeDao.updatePrize(prize);
		logger.info("count = {}", count);
	}

	@Test
	void deletePrize() {
		Prize prize = new Prize();
		prize.setPrizeId(2);
		int deleteCount = prizeDao.deletePrize(prize);
		logger.info("deleteCount = {}", deleteCount);
	}
}