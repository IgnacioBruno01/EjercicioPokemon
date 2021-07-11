using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class GamePlay
{
    private Player player;
    private EnemyTrainer enemy;
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
        enemy = new EnemyTrainer();
        pokemon = new Pokemon();
    }
    public bool Play()
    {
        StartNewGame();
        return true;
    }
}

