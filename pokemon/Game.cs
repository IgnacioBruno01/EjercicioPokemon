using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Game
{ 
    private static Game instance;

    public static Game GetInstance()
    {
        if (instance == null)
        {
            instance = new Game();
        }
        return instance;
    }
    enum State { Gameplay, Pause };

    private GamePlay gameplay;
    private PauseMenu pauseMenu;
    private static State state;                                        

    public Game()
    {
        gameplay = new GamePlay();
        pauseMenu = new PauseMenu();
        state = State.Gameplay;
    }

    public void Update()
    {
        switch (state)
        {
            case State.Gameplay:
                gameplay.Play();
                break;
            case State.Pause:
                pauseMenu.Pause();
                break;
            default:
                break;
        }
    }

    public static void GoToPause()
    {
        state = State.Pause;
    }

    public static void GoToGameplay()
    {
        state = State.Gameplay;
    }
}
