package com.bnuz.oke.entity;

/**
 * Option
 *
 * @author handsome
 * @date 2020年 05月15日 00:10:58
 */
public class Option {

	private int optionId;

	private Question question;

	private String optionType;

	private String optionDescribe;

	public int getOptionId() {
		return optionId;
	}

	public void setOptionId(int optionId) {
		this.optionId = optionId;
	}

	public Question getQuestion() {
		return question;
	}

	public void setQuestion(Question question) {
		this.question = question;
	}

	public String getOptionType() {
		return optionType;
	}

	public void setOptionType(String optionType) {
		this.optionType = optionType;
	}

	public String getOptionDescribe() {
		return optionDescribe;
	}

	public void setOptionDescribe(String optionDescribe) {
		this.optionDescribe = optionDescribe;
	}

	@Override
	public String toString() {
		return "Option{" +
				"optionId=" + optionId +
				", question=" + question +
				", optionType='" + optionType + '\'' +
				", optionDescribe='" + optionDescribe + '\'' +
				'}';
	}
}
