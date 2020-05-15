package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Teacher;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

/**
 * TeacherDao
 *
 * @author handsome
 * @date 2020年 05月15日 23:36:13
 */
@Mapper
@Component
public interface TeacherDao {

	Teacher queryByUsername(String username);

	int insertTeacher(Teacher teacher);

	int updateTeacher(Teacher teacher);
}
