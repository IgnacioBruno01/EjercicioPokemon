using System;
using System.Collections.Generic;
using System.Text;

public enum Type { FIRE, STEEL, FIGHTER, GRASS, ROCK, WATHER, Error }
public class Types
{
    private Dictionary<string, Type> typesDataBase = new Dictionary<string, Type>();

    private static Types instance;
    public static Types GetInstance()
    {
        if (instance == null)
        {
            instance = new Types();
        }
        return instance;
    }
    private Types()
    {
        typesDataBase.Add("Fire", Type.FIRE);
        typesDataBase.Add("Steel", Type.STEEL);
        typesDataBase.Add("Fighter", Type.FIGHTER);
        typesDataBase.Add("Grass", Type.GRASS);
        typesDataBase.Add("Rock", Type.ROCK);
        typesDataBase.Add("Wather", Type.WATHER);
    }
    public Type GetType(string typeName)
    {
        if (typesDataBase.ContainsKey(typeName))
        {
            return typesDataBase[typeName];
        }
        else
        {
            Console.WriteLine("Error!");
            return Type.Error;
        }
    }
}

