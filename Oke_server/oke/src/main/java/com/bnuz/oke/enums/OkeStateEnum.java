package com.bnuz.oke.enums;

/**
 * OkeStateEnum
 *
 * @author handsome
 * @date 2020年 05月23日 15:07:37
 */
public enum OkeStateEnum {
	EXCEPTION_SERVER(0, "系统繁忙");

	private int state;

	private String stateInfo;

	OkeStateEnum(int state, String stateInfo) {
		this.state = state;
		this.stateInfo = stateInfo;
	}

	public int getState() {
		return state;
	}

	public String getStateInfo() {
		return stateInfo;
	}

	public static OkeStateEnum stateOf(int index) {
		for (OkeStateEnum state: values()) {
			if (state.getState() == index) {
				return state;
			}
		}
		return null;
	}
}
