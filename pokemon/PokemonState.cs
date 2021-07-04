using System;
using System.Collections.Generic;
using System.Text;
public abstract class PokemonState
{
    public abstract Pokemon ApplyEffect(Pokemon affected);
}

public sealed class Poisoned : PokemonState
{
    int maxTurns = 3;
    int appliedTurns = 0;

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected.Hp -= (affected.MaxHp / 16);
        appliedTurns++;

        if (new Random().Next(appliedTurns, maxTurns) == maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}