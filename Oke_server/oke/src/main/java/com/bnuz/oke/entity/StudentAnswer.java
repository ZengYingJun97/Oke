package com.bnuz.oke.entity;

import java.io.Serializable;

/**
 * StudentAnswer
 *
 * @author handsome
 * @date 2020年 05月15日 00:12:56
 */
public class StudentAnswer implements Serializable {

	private static final long serialVersionUID = 7035576625168049177L;

	private Student student;

	private Question question;

	private String answerContent;

	private int answerCorrect;

	private float answerValue;

	public Student getStudent() {
		return student;
	}

	public void setStudent(Student student) {
		this.student = student;
	}

	public Question getQuestion() {
		return question;
	}

	public void setQuestion(Question question) {
		this.question = question;
	}

	public String getAnswerContent() {
		return answerContent;
	}

	public void setAnswerContent(String answerContent) {
		this.answerContent = answerContent;
	}

	public int getAnswerCorrect() {
		return answerCorrect;
	}

	public void setAnswerCorrect(int answerCorrect) {
		this.answerCorrect = answerCorrect;
	}

	public float getAnswerValue() {
		return answerValue;
	}

	public void setAnswerValue(float answerValue) {
		this.answerValue = answerValue;
	}

	@Override
	public String toString() {
		return "StudentAnswer{" +
				"student=" + student +
				", question=" + question +
				", answerContent='" + answerContent + '\'' +
				", answerCorrect=" + answerCorrect +
				", answerValue=" + answerValue +
				'}';
	}
}
