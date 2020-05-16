package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Course;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

/**
 * CourseDao
 *
 * @author handsome
 * @date 2020年 05月16日 23:12:07
 */
@Mapper
@Component
public interface CourseDao {

	Course queryByNumber(String courseNumber);

	int insertCourse(Course course);

	int updateCourse(Course course);
}
