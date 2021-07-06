using System;
using System.Collections.Generic;
using System.Text;
public abstract class PokemonState
{
    public int _maxTurns;
    public int _appliedTurns;
    public int _probability;
    public PokemonState(int maxTurns, int appliedTurns, int probability)
    {
        _maxTurns = maxTurns;
        _appliedTurns = appliedTurns;
        _probability = probability;
    }
    public abstract Pokemon ApplyEffect(Pokemon affected);
}
public sealed class Burn : PokemonState
{
    public Burn(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
    {
        _maxTurns = 3;
        _appliedTurns = 0;
        _probability -= 10;
    }
    bool Probability(Pokemon affected)
    {
        if (new Random().Next(0, 100) == _probability)
        {
            ApplyEffect(affected);
        }
        return false;
    }

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected.Hp -= (affected.MaxHp / 16);
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class Accuaracy : PokemonState
{
    public Accuaracy(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
    {
        _maxTurns = 3;
        _appliedTurns = 0;
        _probability -= 20;
    }
    bool Probability(Pokemon affected)
    {
        if (new Random().Next(0, 100) == _probability)
        {
            ApplyEffect(affected);
        }
        return false;
    }

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected.Hp -= (affected.MaxHp / 16);
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class Flinch : PokemonState
{
    public Flinch(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
    {
        _maxTurns = 3;
        _appliedTurns = 0;
        _probability -= 30;
    }
    bool Probability(Pokemon affected)
    {
        if (new Random().Next(0, 100) == _probability)
        {
            ApplyEffect(affected);
        }
        return false;
    }

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected.Hp -= (affected.MaxHp / 16);
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class AttackDown : PokemonState
{
    public AttackDown(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
    {
        _maxTurns = 3;
        _appliedTurns = 0;
        _probability -= 100;
    }
    bool Probability(Pokemon affected)
    {
        if (new Random().Next(0, 100) == _probability)
        {
            ApplyEffect(affected);
        }
        return false;
    }

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected. -= (affected);
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class AttackUp : PokemonState
{
    public AttackUp(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
    {
        _maxTurns = 3;
        _appliedTurns = 0;
        _probability -= 100;
    }
    bool Probability(Pokemon affected)
    {
        if (new Random().Next(0, 100) == _probability)
        {
            ApplyEffect(affected);
        }
        return false;
    }

    public override Pokemon ApplyEffect(Pokemon affected)
    {
        affected. += (affected);
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}