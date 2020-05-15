package com.bnuz.oke.dao;

import com.bnuz.oke.entity.Student;

/**
 * StudentDao
 *
 * @author handsome
 * @date 2020年 05月16日 00:08:12
 */
public interface StudentDao {

	Student queryByUsername(String username);

	Student queryById(int studentId);

	int insertStudent(Student student);

	int updateStudent(Student student);
}
