using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Player
{
    public string name;
    List<Pokemon> PokmTeam = new List<Pokemon>();

    public Player()
    {
        string[] lines;
        lines = File.ReadAllLines("\\James\\NamePlayer.txt");
        this.name = lines[0];
        Pokemon Aron = PokemonReader.ReadPokemonFromFile(".James/Pokemons/Aron.txt");
        PokmTeam.Add(Aron);
        Pokemon Charmander = PokemonReader.ReadPokemonFromFile("James/Pokemons/Charmander.txt");
        PokmTeam.Add(Charmander);
        Pokemon Chikorita = PokemonReader.ReadPokemonFromFile("James/Pokemons/Chikorita.txt");
        PokmTeam.Add(Chikorita);
        Pokemon Cranidos = PokemonReader.ReadPokemonFromFile("James/Pokemons/Cranidos.txt");
        PokmTeam.Add(Cranidos);
        Pokemon Hitmonchan = PokemonReader.ReadPokemonFromFile("James/Pokemons/Hitmonchan.txt");
        PokmTeam.Add(Hitmonchan);
        Pokemon Piplup = PokemonReader.ReadPokemonFromFile("James/Pokemons/Piplup.txt");
        PokmTeam.Add(Piplup);
    }

    void PlayerTurn()
    {

    }
}


