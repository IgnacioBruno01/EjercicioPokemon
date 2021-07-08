using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string name;
    public Player()
    {
        Pokemon[] PokemonsTeam = new Pokemon[6];
    }
    public Player(string name)
    {
        Console.WriteLine("Whats your name?");
        this.name = Console.ReadLine();
    }
    
    void PlayerTurn() 
    {

    }
}


