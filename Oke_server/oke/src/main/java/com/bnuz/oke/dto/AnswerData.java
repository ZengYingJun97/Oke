package com.bnuz.oke.dto;

import java.io.Serializable;

/**
 * AnswerData
 *
 * @author handsome
 * @date 2020年 06月02日 12:43:30
 */
public class AnswerData implements Serializable {

	private static final long serialVersionUID = 4014118658578508691L;

	private int total;

	private int correct;

	private int error;

	private int unCommited;

	public int getTotal() {
		return total;
	}

	public void setTotal(int total) {
		this.total = total;
	}

	public int getCorrect() {
		return correct;
	}

	public void setCorrect(int correct) {
		this.correct = correct;
	}

	public int getError() {
		return error;
	}

	public void setError(int error) {
		this.error = error;
	}

	public int getUnCommited() {
		return unCommited;
	}

	public void setUnCommited(int unCommited) {
		this.unCommited = unCommited;
	}
}
