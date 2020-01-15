using System;
public static class Paper
{
	public static int Paperwork(int n, int m)
		=> m < 0 || n < 0 ? 0 : n * m;
}
