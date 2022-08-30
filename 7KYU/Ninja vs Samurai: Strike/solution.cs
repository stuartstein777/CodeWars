using System;

public class Warrior
{
    private string name;

    public Warrior(string name)
    {
        this.name = name;
    }

    public int Health { get; set; } = 100;

    public void Strike(Warrior enemy, int swings)
    {
        enemy.Health -= swings * 10;
    }
}