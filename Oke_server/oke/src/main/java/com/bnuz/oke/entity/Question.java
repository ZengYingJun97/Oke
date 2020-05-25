package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * Question
 *
 * @author handsome
 * @date 2020年 05月15日 00:08:42
 */
public class Question implements Serializable {

	private static final long serialVersionUID = -1049328428563962705L;

	private int questionId;

	private Course course;

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

	public Course getCourse() {
		return course;
	}

	public void setCourse(Course course) {
		this.course = course;
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

	@Override
	public String toString() {
		return "Question{" +
				"questionId=" + questionId +
				", course=" + course +
				", questionType=" + questionType +
				", questionDescribe='" + questionDescribe + '\'' +
				", questionAnswer='" + questionAnswer + '\'' +
				", questionScore=" + questionScore +
				", questionLimitTime=" + questionLimitTime +
				'}';
	}
}
