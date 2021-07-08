using System;
using System.Collections.Generic;
using System.Text;
public static class PokemonReader
{
	public static Pokemon ReadPokemonFromFile(string path)
	{
		Pokemon P = new Pokemon();

		string[] lines = File.ReadAllLines(path);

		P.name = lines[0];
		P.level = Convert.ToInt32(lines[1]);

		string[] types = lines[2].Split(" ");
		for (int i = 0; i < types.Length; i++)
		{
			P.types.Add(Types.GetInstance().GetType(types[i]));
		}

		P.Hp = Convert.ToInt32(lines[3]);
		P.MaxHp = Convert.ToInt32(lines[3]);
		P.ataque = Convert.ToInt32(lines[4]);
		P.ataqueEpecial = Convert.ToInt32(lines[5]);
		P.defensa = Convert.ToInt32(lines[6]);
		P.defensaEspecial = Convert.ToInt32(lines[7]);
		P.velocidad = Convert.ToInt32(lines[8]);
		if (lines.Length >= 9)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[9]));
		}
		if (lines.Length >= 10)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[10]));
		}
		if (lines.Length >= 11)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[11]));
		}
		if (lines.Length >= 12)
		{
			P.moves.Add(MovementDatabase.GetMovement(lines[12])));
		}

		return P;
	}
}

public static class MovementDatabase
{
	public static Movement GetMovement(string movementName)
	{
		try
		{
			switch (movementName)
			{
				case "Tackle":
					return new Tackle();
				case "Ember":
					return new Ember();
				case "Harden":
					return new Harden();
				case "Mud Slap":
					return new MudSlap();
				case "Headbutt":
					return new Headbutt();
				case "Scratch":
					return new Scratch();
				case "Growl":
					return new Growl();
				case "Metal Claw":
					return new MetalClaw();
				case "Razor Leaf":
					return new RazorLeaf();
				case "Reflect":
					return new Reflect();
				case "Leer":
					return new Leer();
				case "Focus Energy":
					return new FocusEnergy();
				case "Pursuit":
					return new Pursuit();
				case "Comet Punch":
					return new CometPunch();
				case "Agility":
					return new Agility();
				case "Bubble":
					return new Bubble();
				case "Water Sport":
					return new WaterSport();
				case "Take Down":
					return new TakeDown();
				case "Smokescreen":
					return new Smokescreen();
				case "Rock Throw":
					return new RockThrow();
				case "Magnitude":
					return new Magnitude();
				case "Mud Sport":
					return new MudSport();
				case "Karate Chop":
					return new KarateChop();
				case "Whater Gun":
					return new WhaterGun();
				case "Rage":
					return new Rage();
				case "Withdraw":
					return new Withdraw();
				case "Absorb":
					return new Absorb();
				case "Tail Whip":
					return new TailWhip();
				case "Quick Attack":
					return new QuickAttack();
				case "Pound":
					return new Pound();
				case "Peck":
					return new Peck();
				case "Double Kick":
					return new DoubleKick();
				case "Defense Curl":
					return new DefenseCurl();
				case "Rock Polish":
					return new RockPolish();
				default:
					throw new MissingMovementException("The movement whit name " + movementName + " dos't exist or is not added to the dartabase");
			}
		}
		catch (MissingMovementException e)
		{
			Console.WriteLine(e.Message);
			return e.GetDefaultMovement();
		}
	}
}


