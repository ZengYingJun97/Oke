package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Option;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * OptionDao
 *
 * @author handsome
 * @date 2020年 05月17日 16:45:10
 */
@Mapper
@Component
public interface OptionDao {

	List<Option> queryByQuestionId(int questionId);

	Option queryByOptionId(int optionId);

	int insertOption(Option option);

	int updateOption(Option option);
}