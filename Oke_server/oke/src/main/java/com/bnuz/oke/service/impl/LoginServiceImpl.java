package com.bnuz.oke.service.impl;

import com.bnuz.oke.dao.StudentDao;
import com.bnuz.oke.dao.TeacherDao;
import com.bnuz.oke.dao.UserDao;
import com.bnuz.oke.entity.Student;
import com.bnuz.oke.entity.Teacher;
import com.bnuz.oke.entity.User;
import com.bnuz.oke.service.LoginService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;
import org.springframework.transaction.interceptor.TransactionAspectSupport;

/**
 * LoginServiceImpl
 *
 * @author handsome
 * @date 2020年 05月18日 15:59:28
 */
@Service
public class LoginServiceImpl implements LoginService {

	@Autowired
	private UserDao userDao;

	@Autowired
	private StudentDao studentDao;

	@Autowired
	private TeacherDao teacherDao;

	@Override
	@Transactional
	public boolean registerStudent(Student student) {
		if (userDao.queryByUsername(student.getUser().getUsername()) == null) {
			int insertUserCount = userDao.insertUser(student.getUser());
			int insertStudentCount = studentDao.insertStudent(student);
			if (insertStudentCount == 0 || insertUserCount == 0) {
				TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
				return false;
			}
			return true;
		}
		return false;
	}

	@Override
	@Transactional
	public boolean registerTeacher(Teacher teacher) {
		if (userDao.queryByUsername(teacher.getUser().getUsername()) == null) {
			int insertUserCount = userDao.insertUser(teacher.getUser());
			int insertTeacherCount = teacherDao.insertTeacher(teacher);
			if (insertTeacherCount == 0 || insertUserCount == 0) {
				TransactionAspectSupport.currentTransactionStatus().setRollbackOnly();
				return false;
			}
			return true;
		}
		return false;
	}

	@Override
	public Student loginStudent(User user) {
		return studentDao.queryByUsername(user.getUsername());
	}

	@Override
	public Teacher loginTeacher(User user) {
		return teacherDao.queryByUsername(user.getUsername());
	}
}
