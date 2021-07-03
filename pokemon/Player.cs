using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string name;
    public Player()
    {
    }
    public Player(string name)
    {
        Console.WriteLine("Whats your name?");
        this.name = Console.ReadLine();
    }
}


