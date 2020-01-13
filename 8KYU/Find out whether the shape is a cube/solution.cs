namespace CubeCheck
{
	using System;
	public class CubeChecker
	{
		public bool IsCube(double volume, double side)
			=> ((side > 0 && volume > 0) && (volume == side * side * side));
	}
}