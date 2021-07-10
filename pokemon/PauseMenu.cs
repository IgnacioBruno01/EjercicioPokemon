using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
class PauseMenu
{
    public void Pause()
    {
        Console.WriteLine("Paused!, press p key to back");
        char input = Console.ReadKey().KeyChar;

        if (input == 'p')
        {
            Game.GoToGameplay();
        }
    }
}
