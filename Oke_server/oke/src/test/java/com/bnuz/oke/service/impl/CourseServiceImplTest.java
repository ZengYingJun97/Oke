package com.bnuz.oke.service.impl;

import com.bnuz.oke.dto.VoteData;
import com.bnuz.oke.entity.*;
import com.bnuz.oke.service.CourseService;
import org.junit.jupiter.api.Test;
import org.junit.runner.RunWith;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;
import org.springframework.test.context.junit4.SpringRunner;

import java.util.ArrayList;
import java.util.List;

@RunWith(SpringRunner.class)
@SpringBootTest(webEnvironment = SpringBootTest.WebEnvironment.RANDOM_PORT)
class CourseServiceImplTest {
	private final Logger logger = LoggerFactory.getLogger(this.getClass());

	@Autowired
	private CourseService courseService;

	@Test
	void beginCourse() {
		Teacher teacher = new Teacher();
		teacher.setTeacherId(1);
		Course course = new Course();
		course.setCourseName("菊花妈妈小课堂");
		course.setTeacher(teacher);
		Course nowCourse = courseService.beginCourse(course);
		logger.info("nowCourse = {}", nowCourse);
	}

	@Test
	void endCourse() {
		Course course = new Course();
		course.setCourseNumber("7185B207543E44CD8CE6F719F46DBD53");
		if (courseService.endCourse(course)) {
			course = courseService.getCourseByCourseNumber(course.getCourseNumber());
			logger.info("course = {}", course);
		} else {
			logger.info("结束失败！");
		}
	}

	@Test
	void onlineStudent() {
		Student student = new Student();
		student.setStudentId(1);
		Course course = new Course();
		course.setCourseNumber("7185B207543E44CD8CE6F719F46DBD53");
		CourseRecord courseRecord = new CourseRecord();
		courseRecord.setStudent(student);
		courseRecord.setCourse(course);
		boolean onlineOk = courseService.onlineStudent(courseRecord);
		if (onlineOk) {
			logger.info("登陆成功!");
		} else {
			logger.info("登陆失败!");
		}
	}

	@Test
	void getStudentRecord() {
		Course course = new Course();
		course.setCourseNumber("7185B207543E44CD8CE6F719F46DBD53");
		List<CourseRecord> courseRecordList = courseService.getStudentRecord(course);
		logger.info("courseRecordList = {}", courseRecordList);
	}

	@Test
	void addQuestion() {
		Course course = new Course();
		course.setCourseNumber("7185B207543E44CD8CE6F719F46DBD53");
		Question question = new Question();
		question.setCourse(course);
		question.setQuestionType(0);
		question.setQuestionDescribe("区分成文宪法和不成文宪法的依据是()");
		question.setQuestionAnswer("B");
		question.setQuestionScore(5);
		question.setQuestionLimitTime(60);
		List<Option> optionList = new ArrayList<>();
		Option optionA = new Option();
		optionA.setQuestion(question);
		optionA.setOptionType("A");
		optionA.setOptionDescribe("是否有书面文字");
		Option optionB = new Option();
		optionB.setQuestion(question);
		optionB.setOptionType("B");
		optionB.setOptionDescribe("是否具有统一的法典形式");
		Option optionC = new Option();
		optionC.setQuestion(question);
		optionC.setOptionType("C");
		optionC.setOptionDescribe("是否具有最高效力");
		Option optionD = new Option();
		optionD.setQuestion(question);
		optionD.setOptionType("D");
		optionD.setOptionDescribe("是否具有严格的修改程序");
		optionList.add(optionA);
		optionList.add(optionB);
		optionList.add(optionC);
		optionList.add(optionD);
		Question nowQuestion = courseService.addQuestion(question, optionList);
		logger.info("nowQuestion = {}", nowQuestion);
	}

	@Test
	void isTrueStudentAnswer() {
		Question question = new Question();
		question.setQuestionId(9);
		Student student = new Student();
		student.setStudentId(1);
		StudentAnswer studentAnswer = new StudentAnswer();
		studentAnswer.setAnswerContent("B;");
		studentAnswer.setQuestion(question);
		studentAnswer.setStudent(student);
		courseService.isTrueStudentAnswer(studentAnswer);
		logger.info("studentAnswer = {}", studentAnswer);
	}

	@Test
	void questionAnswerList() {
		int questionId = 9;
		List<StudentAnswer> studentAnswerList = courseService.questionAnswerList(questionId);
		logger.info("studentAnswerList = {}", studentAnswerList);
	}

	@Test
	void getCourseByTeacherId() {
		int teacherId = 1;
		List<Course> courseList = courseService.getCourseByTeacherId(teacherId);
		logger.info("courseList = {}", courseList);
	}

	@Test
	void addVote() {
		Course course = new Course();
		course.setCourseNumber("3384CBB8AAC34A2C9895F0A6DE27AB3C");
		Vote vote = new Vote();
		vote.setCourse(course);
		vote.setVoteDescribe("曾小课想上班吗");
		vote.setVoteLimitTime(60);
		List<VoteChoice> voteChoiceList = new ArrayList<>();
		VoteChoice voteChoiceA = new VoteChoice();
		voteChoiceA.setVoteChoiceType("A");
		voteChoiceA.setVoteChoiceDescribe("是");
		VoteChoice voteChoiceB = new VoteChoice();
		voteChoiceB.setVoteChoiceType("B");
		voteChoiceB.setVoteChoiceDescribe("否");
		voteChoiceList.add(voteChoiceA);
		voteChoiceList.add(voteChoiceB);
		VoteData voteData = courseService.addVote(vote, voteChoiceList);
		logger.info("voteData = {}", voteData);
	}

	@Test
	void studentVote() {
		Student student = new Student();
		student.setStudentId(1);
		Vote vote = new Vote();
		vote.setVoteId(4);
		VoteChoice voteChoice = new VoteChoice();
		voteChoice.setVoteChoiceId(5);
		VoteStudent voteStudent = new VoteStudent();
		voteStudent.setStudent(student);
		voteStudent.setVote(vote);
		voteStudent.setVoteChoice(voteChoice);
		boolean isOk = courseService.studentVote(voteStudent);
		logger.info("isOk = {}", isOk);
	}

	@Test
	void getVoteStudentList() {
		Vote vote = new Vote();
		vote.setVoteId(4);
		List<VoteStudent> voteStudentList = courseService.getVoteStudentList(vote);
		logger.info("voteStudentList = {}", voteStudentList);
	}
}