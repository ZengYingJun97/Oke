package com.bnuz.oke.uitls;

import java.util.Date;
import java.util.Random;

/**
 * RandomUitl
 *
 * @author handsome
 * @date 2020年 05月26日 13:28:14
 */
public class RandomUitl {

	private static char getChar(int num) {
		if (num < 10) {
			return (char) (num + '0');
		} else {
			return (char) (num - 10 + 'A');
		}
	}

	public static String getRandom() {
		Date nowTime = new Date();
		int HH = nowTime.getHours();
		int mm = (int) (nowTime.getMinutes() * 0.6);
		int ss = (int) (nowTime.getSeconds() * 0.6);
		Random random = new Random();
		int var1 = random.nextInt(36);
		int var2 = random.nextInt(36);
		int var3 = random.nextInt(36);
		String result = "" + getChar(var1) + getChar(HH) + getChar(var2) + getChar(mm) + getChar(var3) + getChar(ss);
		return result;
	}
}
