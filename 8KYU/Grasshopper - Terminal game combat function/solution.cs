using System;
public static class Game
{
	public static float Combat(float health, float damage)
		=> Math.Max(health - damage, 0);
}