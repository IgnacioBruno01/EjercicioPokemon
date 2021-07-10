using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

public class EnemyTrainer
{
    public string name;
    public EnemyTrainer()
    {
        var trainer1 = new EnemyTrainer(name);
        var trainer2 = new EnemyTrainer(name);
    }
    public EnemyTrainer(string name)
    {
        EnemyTrainer enemy = EnemyReadFile.ReadEnemyFromFile("\\Dante\\NameEnemy.txt");
         this.name;
    }

    void EnemyTrainerTurn()
    {

    }

}

