package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Question;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * QuestionDao
 *
 * @author handsome
 * @date 2020年 05月17日 15:44:11
 */
@Mapper
@Component
public interface QuestionDao {

	List<Question> queryByCourseNumber(String courseNumber);

	Question  queryByQuestionId(int questionId);

	int insertQuestion(Question question);

	int updateQuestion(Question question);
}
