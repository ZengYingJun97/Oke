package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Student;
import org.apache.ibatis.annotations.Mapper;
import org.springframework.stereotype.Component;

/**
 * StudentDao
 *
 * @author handsome
 * @date 2020年 05月16日 00:08:12
 */
@Mapper
@Component
public interface StudentDao {

	Student queryByUsername(String username);

	Student queryById(int studentId);

	int insertStudent(Student student);

	int updateStudent(Student student);
}
