package com.bnuz.oke.service.impl;

import com.bnuz.oke.entity.*;
import com.bnuz.oke.service.CourseService;
import org.springframework.stereotype.Service;

import java.util.List;

/**
 * CourseServiceImpl
 *
 * @author handsome
 * @date 2020年 05月18日 23:48:52
 */
@Service
public class CourseServiceImpl implements CourseService {

	@Override
	public Course beginCourse(Course course) {
		return null;
	}

	@Override
	public boolean endCourse(Course course) {
		return false;
	}

	@Override
	public boolean onlineStudent(CourseRecord courseRecord) {
		return false;
	}

	@Override
	public List<CourseRecord> getStudentRecord(CourseRecord courseRecord) {
		return null;
	}

	@Override
	public Question addQuestion(Question question, List<Option> optionList) {
		return null;
	}

	@Override
	public StudentAnswer isTrueStudentAnswer(StudentAnswer studentAnswer) {
		return null;
	}
}
