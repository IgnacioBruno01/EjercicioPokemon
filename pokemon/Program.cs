using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        bool gameOpen = true;

        try
        {
            Game game = new Game();
            do
            {
                gameOpen = game.Update();
            } while (gameOpen);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR INESPERADO!" + e.Message);
        }
    }
}

