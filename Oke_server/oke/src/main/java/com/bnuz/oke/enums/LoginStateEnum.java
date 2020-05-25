package com.bnuz.oke.enums;

/**
 * LoginStateEnum
 *
 * @author handsome
 * @date 2020年 05月23日 13:55:25
 */
public enum LoginStateEnum {
	SUCCESS_REGISTER(0, "注册成功"),
	FAIL_REGISTER(1, "该账号已存在"),
	SUCCESS_LOGIN(2, "登陆成功"),
	FAIL_LOGIN(3, "用户名或密码不正确"),
	INVALID_OP(4, "无效操作"),
	SUCCESS_UPDATE(5, "修改成功"),
	SUCCESS_LOGOUT(6, "退出成功");

	private int state;

	private String stateInfo;

	LoginStateEnum(int state, String stateInfo) {
		this.state = state;
		this.stateInfo = stateInfo;
	}

	public int getState() {
		return state;
	}

	public String getStateInfo() {
		return stateInfo;
	}

	public static LoginStateEnum stateOf(int index) {
		for (LoginStateEnum state: values()) {
			if (state.getState() == index) {
				return state;
			}
		}
		return null;
	}
}
