package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Scratcher;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * ScratcherDao
 *
 * @author handsome
 * @date 2020年 05月17日 23:12:34
 */
@Mapper
@Component
public interface ScratcherDao {

	List<Scratcher> queryByCourseNumber(String courseNumber);

	Scratcher queryByScratcherId(int scratcherId);

	int insertScratcher(Scratcher scratcher);
}
