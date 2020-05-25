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
		Student student = studentDao.queryByUsername(user.getUsername());
		if (!student.getUser().getPassword().equals(user.getPassword())) {
			student = null;
		}
		return student;
	}

	@Override
	public Teacher loginTeacher(User user) {
		Teacher teacher = teacherDao.queryByUsername(user.getUsername());
		if (!teacher.getUser().getPassword().equals(user.getPassword())) {
			teacher = null;
		}
		return teacher;
	}

	@Override
	public Student updateStudent(Student student) {
		studentDao.updateStudent(student);
		student = studentDao.queryById(student.getStudentId());
		return student;
	}

	@Override
	public Teacher updateTeacher(Teacher teacher) {
		teacherDao.updateTeacher(teacher);
		teacher = teacherDao.queryByUsername(teacher.getUser().getUsername());
		return teacher;
	}

	@Override
	public boolean updateUser(User user) {
		int updateCount = userDao.updateUser(user);
		if (updateCount == 0) {
			return false;
		} else {
			return true;
		}
	}

	@Override
	public User getUserByUsername(String username) {
		return userDao.queryByUsername(username);
	}

	@Override
	public Teacher getTeacherByUsername(String username) {
		return teacherDao.queryByUsername(username);
	}

	@Override
	public Student getStudentByUsername(String username) {
		return studentDao.queryByUsername(username);
	}
}
