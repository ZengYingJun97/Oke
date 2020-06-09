package com.bnuz.oke.service;

import com.bnuz.oke.dto.CourseRecordData;
import com.bnuz.oke.dto.QuestionData;
import com.bnuz.oke.dto.VoteData;
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

	List<CourseRecordData> getStudentRecord(Course course);

	CourseRecord getStudentRecordId(Course course, Student student);

	Question addQuestion(Question question, List<Option> optionList);

	StudentAnswer isTrueStudentAnswer(StudentAnswer studentAnswer);

	List<StudentAnswer> questionAnswerList(int questionId);

	VoteData addVote(Vote vote, List<VoteChoice> voteChoiceList);

	boolean studentVote(VoteStudent voteStudent);

	List<VoteStudent> getVoteStudentList(Vote vote);

	List<Vote> getVoteList(Course course);

	List<CourseRecord> getCourseList(int studentId);

	List<QuestionData> getCourseQuestionList(String courseNumber);
}
