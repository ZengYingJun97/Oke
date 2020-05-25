package com.bnuz.oke.dto;

/**
 * SessionData
 *
 * @author handsome
 * @date 2020年 05月23日 15:21:04
 */
public class SessionData<T> {

	private String sessionId;

	private T data;

	public SessionData(String sessionId, T data) {
		this.sessionId = sessionId;
		this.data = data;
	}

	public String getSessionId() {
		return sessionId;
	}

	public void setSessionId(String sessionId) {
		this.sessionId = sessionId;
	}

	public T getData() {
		return data;
	}

	public void setData(T data) {
		this.data = data;
	}
}
