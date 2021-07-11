using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class EnemyTrainer
{
    public string name;
    List<Pokemon> PokmTeam = new List<Pokemon>();
    public EnemyTrainer()
    {
        string[] lines;
        lines = File.ReadAllLines("\\Dante\\NameEnemy.txt");
        this.name = lines[0];
        Pokemon Geodude = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Geodude.txt");
        PokmTeam.Add(Geodude);
        Pokemon Hitmonlee = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Hitmonlee.txt");
        PokmTeam.Add(Hitmonlee);
        Pokemon Skarmory = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Skarmory.txt");
        PokmTeam.Add(Skarmory);
        Pokemon Squirtle = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Squirtle.txt");
        PokmTeam.Add(Squirtle);
        Pokemon Treecko = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Treecko.txt");
        PokmTeam.Add(Treecko);
        Pokemon Vulpix = PokemonReader.ReadPokemonFromFile(".Dante/Pokemons/Vulpix.txt");
        PokmTeam.Add(Vulpix);
    }

    void EnemyTrainerTurn()
    {

    }

}

