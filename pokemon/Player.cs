using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Player
{
    public string name;
    public Player()
    {
        Pokemon[] PokemonsTeam = new Pokemon[6];
    }
    public Player(string name)
    {
        Player player = PlayerReadFile.ReadPlayerFromFile("\\James\\NamePlayer.txt");
         this.name;
    }

    void PlayerTurn()
    {

    }
}


