using System;
using System.Collections.Generic;
using System.Text;

public class EnemyTrainer
{
    private string name;
    public EnemyTrainer()
    {
        var trainer1 = new EnemyTrainer(name);
        var trainer2 = new EnemyTrainer(name);
    }
    public EnemyTrainer(string name)
    {
        _ = this.name;
    }

    void EnemyTrainerTurn()
    {

    }

}

