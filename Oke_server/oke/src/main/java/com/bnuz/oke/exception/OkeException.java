package com.bnuz.oke.exception;

/**
 * OkeException
 *
 * @author handsome
 * @date 2020年 05月18日 16:20:32
 */
public class OkeException extends RuntimeException {

	public OkeException(String message) {
		super(message);
	}

	public OkeException(String message, Throwable cause) {
		super(message, cause);
	}
}
