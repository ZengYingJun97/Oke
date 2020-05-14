package com.bnuz.oke.entity;

/**
 * Question
 *
 * @author handsome
 * @date 2020年 05月15日 00:08:42
 */
public class Question {

	private int questionId;

	private String courseNumber;

	private int questionType;

	private String questionDescribe;

	private String questionAnswer;

	private int questionScore;

	private int questionLimitTime;

	public int getQuestionId() {
		return questionId;
	}

	public void setQuestionId(int questionId) {
		this.questionId = questionId;
	}

	public String getCourseNumber() {
		return courseNumber;
	}

	public void setCourseNumber(String courseNumber) {
		this.courseNumber = courseNumber;
	}

	public int getQuestionType() {
		return questionType;
	}

	public void setQuestionType(int questionType) {
		this.questionType = questionType;
	}

	public String getQuestionDescribe() {
		return questionDescribe;
	}

	public void setQuestionDescribe(String questionDescribe) {
		this.questionDescribe = questionDescribe;
	}

	public String getQuestionAnswer() {
		return questionAnswer;
	}

	public void setQuestionAnswer(String questionAnswer) {
		this.questionAnswer = questionAnswer;
	}

	public int getQuestionScore() {
		return questionScore;
	}

	public void setQuestionScore(int questionScore) {
		this.questionScore = questionScore;
	}

	public int getQuestionLimitTime() {
		return questionLimitTime;
	}

	public void setQuestionLimitTime(int questionLimitTime) {
		this.questionLimitTime = questionLimitTime;
	}
}
