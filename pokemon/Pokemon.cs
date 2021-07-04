using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    public string name;
    public int level;
    public List<Types> types;
    public int Hp;
    public int MaxHp;
    private int Attack;
    private int SpecialAttak;
    private int Defense;
    private int SpecialDefense;
    private int Speed;
    private List<Movement> movements;
    public PokemonState state;

    public Pokemon()
    {
        types = new List<Types>();
        movements = new List<Movement>();
    }

}
