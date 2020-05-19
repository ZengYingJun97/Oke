package com.bnuz.oke.service;

import com.bnuz.oke.entity.*;

import java.util.List;

/**
 * CourseService
 *
 * @author handsome
 * @date 2020年 05月18日 23:21:31
 */
public interface CourseService {

	Course beginCourse(Course course);

	boolean endCourse(Course course);

	boolean onlineStudent(CourseRecord courseRecord);

	List<CourseRecord> getStudentRecord(Course course);

	Question addQuestion(Question question, List<Option> optionList);

	StudentAnswer isTrueStudentAnswer(StudentAnswer studentAnswer);
}
