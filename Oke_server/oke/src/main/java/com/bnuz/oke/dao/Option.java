package com.bnuz.oke.dao;

import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * Option
 *
 * @author handsome
 * @date 2020年 05月17日 16:02:54
 */
@Mapper
@Component
public interface Option {

	List<Option> queryByQuestionId(int questionId);

	Option queryByOptionId(int optionId);

	int insertOption(Option option);

	int updateOption(Option option);
}
