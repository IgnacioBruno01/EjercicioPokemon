using System;
class Program
{
    static void Main(string[] args)
    {
        bool gameOpen = true;

        try
        {
            GamePlay game = new GamePlay();
            do
            {
                gameOpen = game.Play();
            } while (gameOpen);
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR INESPERADO!" + e.Message);
        }
    }
}

