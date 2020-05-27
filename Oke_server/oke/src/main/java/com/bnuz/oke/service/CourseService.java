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

	Course getCourseByCourseNumber(String courseNumber);

	List<Course> getCourseByTeacherId(int teacherId);

	boolean endCourse(Course course);

	boolean onlineStudent(CourseRecord courseRecord);

	List<CourseRecord> getStudentRecord(Course course);

	CourseRecord getStudentRecordId(Course course, Student student);

	Question addQuestion(Question question, List<Option> optionList);

	StudentAnswer isTrueStudentAnswer(StudentAnswer studentAnswer);

	List<StudentAnswer> questionAnswerList(int questionId);
}
