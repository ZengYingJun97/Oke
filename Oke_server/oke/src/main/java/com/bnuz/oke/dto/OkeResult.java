package com.bnuz.oke.dto;

/**
 * OkeResult
 *
 * @author handsome
 * @date 2020年 05月25日 16:46:51
 */
public class OkeResult<T> {

	private boolean success;

	private T data;

	private String error;

	public OkeResult(boolean success, T data) {
		this.success = success;
		this.data = data;
	}

	public boolean isSuccess() {
		return success;
	}

	public OkeResult(boolean success, String error) {
		this.success = success;
		this.error = error;
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
