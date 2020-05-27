package com.bnuz.oke.enums;

/**
 * CourseStateEnum
 *
 * @author handsome
 * @date 2020年 05月26日 12:21:15
 */
public enum CourseStateEnum {
	REPEAT_COURSE(0, "已有正在进行的课堂"),
	SUCCESS_OP(1, "操作成功"),
	NULL_COURSE(2, "课堂已下课或不存在"),
	COURSE_ONLINE(3, "课堂正在上课");

	private int state;

	private String stateInfo;

	CourseStateEnum(int state, String stateInfo) {
		this.state = state;
		this.stateInfo = stateInfo;
	}

	public int getState() {
		return state;
	}

	public String getStateInfo() {
		return stateInfo;
	}

	public static CourseStateEnum stateOf(int index) {
		for (CourseStateEnum state: values()) {
			if (state.getState() == index) {
				return state;
			}
		}
		return null;
	}
}
