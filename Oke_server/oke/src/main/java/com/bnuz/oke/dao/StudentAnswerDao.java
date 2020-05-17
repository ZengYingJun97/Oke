package com.bnuz.oke.dao;

import com.bnuz.oke.entity.StudentAnswer;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * StudentAnswerDao
 *
 * @author handsome
 * @date 2020年 05月17日 17:07:44
 */
@Mapper
@Component
public interface StudentAnswerDao {

	List<StudentAnswer> queryByStudentIdAndCourseNumber(int studentId, String courseNumber);

	List<StudentAnswer> queryByQuestionId(int questionId);

	int insertStudentAnswer(StudentAnswer studentAnswer);

	int updateStudentAnswer(StudentAnswer studentAnswer);
}
