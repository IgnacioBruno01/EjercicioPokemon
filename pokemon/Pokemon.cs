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
    protected int Attack;
    protected int SpecialAttak;
    protected int Defense;
    protected int SpecialDefense;
    protected int Speed;
    protected List<Movement> movements;
    public PokemonState state;

    public Pokemon()
    {
        types = new List<Types>();
        movements = new List<Movement>();
    }
}
