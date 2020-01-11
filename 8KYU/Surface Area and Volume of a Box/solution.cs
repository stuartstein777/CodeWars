using System;
public class Kata
{
	public static int[] Get_size(int w, int h, int d)
		=> new[] {(d * w * 2) + (w * h * 2) + (2 * d * h), (w * h * d)};
}