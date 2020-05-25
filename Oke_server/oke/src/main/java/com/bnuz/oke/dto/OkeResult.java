package com.bnuz.oke.dto;

/**
 * OkeResult
 *
 * @author handsome
 * @date 2020年 05月23日 12:35:56
 */
public class OkeResult<T> {

	private boolean success;

	private T data;

	private String error;

	public OkeResult(boolean success, T data) {
		this.success = success;
		this.data = data;
	}

	public OkeResult(boolean success, String error) {
		this.success = success;
		this.error = error;
	}

	public boolean isSuccess() {
		return success;
	}

	public void setSuccess(boolean success) {
		this.success = success;
	}

	public T getData() {
		return data;
	}

	public void setData(T data) {
		this.data = data;
	}

	public String getError() {
		return error;
	}

	public void setError(String error) {
		this.error = error;
	}
}
