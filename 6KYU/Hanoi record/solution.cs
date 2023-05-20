using System;

static class Kata
{
    public static int Hanoi(int disks) 
        => (int)(Math.Pow(2, disks) - 1);
}