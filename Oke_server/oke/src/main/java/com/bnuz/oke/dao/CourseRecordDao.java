package com.bnuz.oke.dao;

import com.bnuz.oke.entity.CourseRecord;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

import java.util.List;

/**
 * CourseRecordDao
 *
 * @author handsome
 * @date 2020年 05月16日 23:48:32
 */
@Mapper
@Component
public interface CourseRecordDao {

	List<CourseRecord> queryByCourseNumber(String courseNumber);

	List<CourseRecord> queryByStudentId(int studentId);

	CourseRecord queryByCourseNumberAndStudentId(String courseNumber, int studentId);

	int insertCourseRecord(CourseRecord courseRecord);

	int updateCourseRecord(CourseRecord courseRecord);
}
