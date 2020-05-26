package com.bnuz.oke.dto;

import com.bnuz.oke.entity.Option;
import com.bnuz.oke.entity.Question;

import java.io.Serializable;
import java.util.List;

/**
 * QuestionData
 *
 * @author handsome
 * @date 2020年 05月26日 16:07:43
 */
public class QuestionData implements Serializable {

	private static final long serialVersionUID = 919322861386944291L;

	private Question question;

	private List<Option> optionList;

	public Question getQuestion() {
		return question;
	}

	public void setQuestion(Question question) {
		this.question = question;
	}

	public List<Option> getOptionList() {
		return optionList;
	}

	public void setOptionList(List<Option> optionList) {
		this.optionList = optionList;
	}
}
