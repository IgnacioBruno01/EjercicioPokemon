using System;
using System.Collections.Generic;
using System.Text;

class GamePlay
{
    private Player player;
    private EnemyTrainer enemyTrainer;
    private Pokemon pokemon;
    public GamePlay()
    {
        bool load = false;
        if (load)
        {
            StartNewGame();
        }
    }
    void StartNewGame()
    {
        player = new Player();
        enemyTrainer = new EnemyTrainer("EnemyTrainer");
        pokemon = new Pokemon();
    }
    public bool Play()
    {
        StartNewGame();
        return true;
    }
}

