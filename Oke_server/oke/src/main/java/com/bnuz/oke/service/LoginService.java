package com.bnuz.oke.service;

import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;

/**
 * LoginService
 *
 * @author handsome
 * @date 2020年 05月18日 15:22:08
 */
public interface LoginService {

	boolean registerStudent(Student student);

	boolean registerTeacher(Teacher teacher);

	Student loginStudent(User user);

	Teacher loginTeacher(User user);
}
