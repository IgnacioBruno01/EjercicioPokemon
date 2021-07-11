using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class Pokemon
{
    public string name;
    public int level;
    public List<Types> types;
    public int Hp;
    public int MaxHp;
    public int Attack;
    public int SpecialAttack;
    public int Defense;
    public int SpecialDefense;
    public int Speed;
    public List<Movement> movements;
    public PokemonState state;

    public Pokemon()
    {
        types = new List<Types>();
        movements = new List<Movement>();
    }
   
    //public int GetAttack()
    //{
    //    return Attack;
    //}
    //public void SetAttack(int NewAttack)
    //{
    //    Attack = NewAttack;
    //}
    //public int GetSpecialAttack()
    //{
    //    return SpecialAttack;
    //}
    //public void SetSpecialAttack(int NewSpecialAttack)
    //{
    //    SpecialAttack = NewSpecialAttack;
    //}
    //public int GetDefense()
    //{
    //    return Defense;
    //}
    //public void SetDefense(int NewDefense)
    //{
    //    Defense = NewDefense;
    //}
    //public int GetSpecialDefense()
    //{
    //    return SpecialDefense;
    //}
    //public void SetSpecialDefense(int NewSpecialDefense)
    //{
    //    SpecialDefense = NewSpecialDefense;
    //}
    //public int GetSpeed()
    //{
    //    return Speed;
    //}
    //public void SetSpeed(int NewSpeed)
    //{
    //    Speed = NewSpeed;
    //}
    public List<Movement> GetMovement(Pokemon affected) //creo que rompe encapsulamiento preguntar a lean.
    {
        return movements;
    }
}
