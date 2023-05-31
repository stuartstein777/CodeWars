using System;

public class Penta {
	
	public static Boolean pNum(long n) {
		var r = ((Math.Sqrt(24 * n + 1) + 1) / 6) % 1;
    return r == 0;
	}
	public static Boolean gpNum(long n) {
    return Math.Sqrt((n * 24) + 1) % 1 == 0;
	}
	public static Boolean spNum(long n) {
		return pNum(n) && Math.Sqrt(n) %1 == 0;
	}
}