using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


public abstract class Movement
{
    public string name;
    protected int power;
    protected int maxUses;
    protected int ActualUses;
    protected int precision;
    public string type;
    protected string category;
    public abstract Pokemon Use(Pokemon caster, Pokemon objective);

    public int GetPrecision()
    {
        return precision;
    }
    public void SetPrecision(int NewPrecision)
    {
        precision = NewPrecision;
    }
}



public sealed class DefaultError : Movement
{
    public DefaultError()
    {
        name = "DefaultError";
        power = 0;
        maxUses = 0;
        ActualUses = 0;
        precision = 0;
        type = "Normal";
        category = "Normal";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
      return objective;
    }
}


public sealed class Tackle : Movement
{
    public Tackle()
    {
        name = "Tackle";
        power = 40;
        maxUses = 35;
        ActualUses = 35;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }

    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }

}

public sealed class Ember : Movement
{
    //burn
    public Ember()
    {
        name = "Ember";
        power = 40;
        maxUses = 25;
        precision = 100;
        type = "Fire";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}
public sealed class Harden : Movement
{
    //defenseUp
    public Harden()
    {
        name = "Harden";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 0;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return caster;
    }
}

public sealed class MudSlap : Movement
{
    //accuaracy
    public MudSlap()
    {
        name = "Mud - Slap";
        power = 20;
        maxUses = 10;
        ActualUses = 10;
        precision = 100;
        type = "Rock";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class Headbutt : Movement
{
    //flinch
    public Headbutt()
    {
        name = "Headbutt";
        power = 70;
        maxUses = 15;
        ActualUses = 15;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class Scratch : Movement
{
    public Scratch()
    {
        name = "Scratch";
        power = 40;
        maxUses = 35;
        ActualUses = 35;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}

public sealed class Growl : Movement
{//attackdown
    public Growl()
    {
        name = "Growl";
        power = 0;
        maxUses = 40;
        ActualUses = 40;
        precision = 100;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class MetalClaw : Movement
{
    //atackup
    public MetalClaw()
    {
        name = "Metal Claw";
        power = 50;
        maxUses = 35;
        ActualUses = 35;
        precision = 95;
        type = "Steel";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class RazorLeaf : Movement
{
    public RazorLeaf()
    {
        name = "Razor Leaf";
        power = 55;
        maxUses = 25;
        ActualUses = 25;
        precision = 95;
        type = "Grass";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class Reflect : Movement
{
    //defenseup solo cuando recive un ataque fisico
    public Reflect()
    {
        name = "Reflect";
        power = 0;
        maxUses = 20;
        ActualUses = 20;
        precision = 0;
        type = "psychic";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {
        return objective;
    }
}

public sealed class Leer : Movement
{
    //defensedown
    public Leer()
    {
        name = "Leer";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}

public sealed class FocusEnergy : Movement
{
    //aumente probabilidad critico 25%
    public FocusEnergy()
    {
        name = "Focus Energy";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 0;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Pursuit : Movement
{
    public Pursuit()
    {
        name = "Pursuit";
        power = 40;
        maxUses = 20;
        ActualUses = 20;
        precision = 100;
        type = "Sinister";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return caster;
    }
}

public sealed class CometPunch : Movement
{//38%probablididad de golpear 2 y 3 veces, 13% probabilidad de golpear 4 y 5 veces
    public CometPunch()
    {
        name = "Comet Punch";
        power = 18;
        maxUses = 15;
        ActualUses = 15;
        precision = 85;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Agility : Movement
{
    //speedup
    public Agility()
    {
        name = "Agility";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 0;
        type = "psychic";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return caster;
    }
}

public sealed class Bubble : Movement
{
    //speedDown
    public Bubble()
    {
        name = "Bubble";
        power = 40;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Wather";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}

public sealed class WaterSport : Movement
{
    //movement type fire reduce power 50%
    public WaterSport()
    {
        name = "Water Sport";
        power = 0;
        maxUses = 15;
        ActualUses = 15;
        precision = 0;
        type = "Wather";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}

public sealed class TakeDown : Movement
{
    //el usuario recive un 25% del daño causado al oponente
    public TakeDown()
    {
        name = "Take Down";
        power = 90;
        maxUses = 20;
        ActualUses = 20;
        precision = 85;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Smokescreen : Movement
{
    //accuaracy
    public Smokescreen()
    {
        name = "Smokescreen";
        power = 0;
        maxUses = 20;
        ActualUses = 20;
        precision = 100;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class RockThrow : Movement
{
    public RockThrow()
    {
        name = "Rock Throw";
        power = 50;
        maxUses = 15;
        ActualUses = 15;
        precision = 90;
        type = "Rock";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Magnitude : Movement
{
    // varia la potencia del ataque si la magnitud es de 4 a 10
    public Magnitude()
    {
        name = "Magnitude";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Ground";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class MudSport : Movement
{
    //defenseup
    public MudSport()
    {
        name = "Mud Sport";
        power = 0;
        maxUses = 15;
        ActualUses = 15;
        precision = 0;
        type = "Ground";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class KarateChop : Movement
{
    public KarateChop()
    {
        name = "Karate Chop";
        power = 50;
        maxUses = 25;
        ActualUses = 25;
        precision = 100;
        type = "Fighting";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class WhaterGun : Movement
{
    public WhaterGun()
    {
        name = "Whater Gun";
        power = 40;
        maxUses = 25;
        ActualUses = 25;
        precision = 100;
        type = "Wather";
        category = "Special";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Rage : Movement
{
    //attackup
    public Rage()
    {
        name = "Rage";
        power = 20;
        maxUses = 20;
        ActualUses = 20;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Withdraw : Movement
{
    //defenseup
    public Withdraw()
    {
        name = "Withdraw";
        power = 0;
        maxUses = 40;
        ActualUses = 40;
        precision = 0;
        type = "Wather";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return caster;
    }
}
public sealed class Absorb : Movement
{//devuelve en forma de hp el 50% del daño causado al usuario
    public Absorb()
    {
        name = "Absorb";
        power = 20;
        maxUses = 25;
        ActualUses = 25;
        precision = 100;
        type = "Special";
        category = "Grass";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class TailWhip : Movement
{//defensedown
    public TailWhip()
    {
        name = "Tail Whip";
        power = 0;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class QuickAttack : Movement
{
    public QuickAttack()
    {
        name = "QuickAttack";
        power = 40;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Pound : Movement
{
    public Pound()
    {
        name = "Pound";
        power = 40;
        maxUses = 35;
        ActualUses = 35;
        precision = 100;
        type = "Normal";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class Peck : Movement
{
    public Peck()
    {
        name = "Peck";
        power = 35;
        maxUses = 35;
        ActualUses = 35;
        precision = 100;
        type = "Flying";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class DoubleKick : Movement
{
    //ataca dos veces
    public DoubleKick()
    {
        name = "Double Kick";
        power = 30;
        maxUses = 30;
        ActualUses = 30;
        precision = 100;
        type = "Fighting";
        category = "Physical";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}
public sealed class DefenseCurl : Movement
{
    //defenseUp
    public DefenseCurl()
    {
        name = "Defense Curl";
        power = 0;
        maxUses = 40;
        ActualUses = 40;
        precision = 0;
        type = "Normal";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return caster;
    }
}
public sealed class RockPolish : Movement
{
    //speedup
    public RockPolish()
    {
        name = "Rock Polish";
        power = 0;
        maxUses = 20;
        ActualUses = 20;
        precision = 0;
        type = "Rock";
        category = "Condition";
    }
    public override Pokemon Use(Pokemon caster, Pokemon objective)
    {

        return objective;
    }
}