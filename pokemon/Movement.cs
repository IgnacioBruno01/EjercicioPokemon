using System;
using System.Collections.Generic;
using System.Text;


public abstract class Movement
{
    public string name;
    public int power;
    public int maxUses;
    public int precision;
    public string type;
    public abstract Pokemon Use(Pokemon caster, Pokemon objective);
}


public sealed class DefaultError : Movement
{
    public DefaultError()
    {
        name = "DefaultError";
        power = 0;
        maxUses = 0;
        precision = 0;
        type = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}


public sealed class Placaje : Movement
{
    public Placaje()
    {
        name = "Placaje";
        power = 30;
        maxUses = 20;
        precision = 95;
        type = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}

public sealed class Lanzallamas : Movement
{
    public Lanzallamas()
    {
        name = "Lanzallamas";
        power = 80;
        maxUses = 10;
        precision = 90;
        type = "Fuego";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}


