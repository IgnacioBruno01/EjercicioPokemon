using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
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
        affected.GetMovement(affected);
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
        affected.Attack = affected.Attack / 2;
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
        affected.Attack = affected.Attack * 2;
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class DefenseUp : PokemonState
{
    public DefenseUp(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
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
        affected.Defense = affected.Defense * 2;
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class DefenseDown : PokemonState
{
    public DefenseDown(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
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
        affected.Defense = affected.Defense / 2;
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class SpeedUp : PokemonState
{
    public SpeedUp(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
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
        affected.Speed = affected.Speed * 2;
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}
public sealed class SpeedDown : PokemonState
{
    public SpeedDown(int maxTurns, int appliedTurns, int probability) : base(maxTurns, appliedTurns, probability)
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
        affected.Speed = affected.Speed / 2;
        _appliedTurns++;

        if (new Random().Next(_appliedTurns, _maxTurns) == _maxTurns)
        {
            affected.state = null;
        }

        return affected;
    }
}