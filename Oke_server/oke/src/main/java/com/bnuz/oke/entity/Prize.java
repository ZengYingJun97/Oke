package com.bnuz.oke.entity;

/**
 * Prize
 *
 * @author handsome
 * @date 2020年 05月15日 00:16:04
 */
public class Prize {

	private int prizeId;

	private Scratcher scratcher;

	private String prizeDescribe;

	private int prizeCount;

	public int getPrizeId() {
		return prizeId;
	}

	public void setPrizeId(int prizeId) {
		this.prizeId = prizeId;
	}

	public Scratcher getScratcher() {
		return scratcher;
	}

	public void setScratcher(Scratcher scratcher) {
		this.scratcher = scratcher;
	}

	public String getPrizeDescribe() {
		return prizeDescribe;
	}

	public void setPrizeDescribe(String prizeDescribe) {
		this.prizeDescribe = prizeDescribe;
	}

	public int getPrizeCount() {
		return prizeCount;
	}

	public void setPrizeCount(int prizeCount) {
		this.prizeCount = prizeCount;
	}

	@Override
	public String toString() {
		return "Prize{" +
				"prizeId=" + prizeId +
				", scratcher=" + scratcher +
				", prizeDescribe='" + prizeDescribe + '\'' +
				", prizeCount=" + prizeCount +
				'}';
	}
}
