using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameReviewer.Models
{
    public class Game
    {
         public string Name { get; set; } 
         public string Description { get; set; }

        public static void Create(Game game)
        {
            GlobalVariables.Games.Add(game);
        }

        public static List<Game> ReadAll()
        {
            return GlobalVariables.Games; 
        }

        public static Game Read(string name)
        {
            foreach (var game in GlobalVariables.Games)
            {
                if(game.Name == name )
                return game; 
            }
            return null;
        }
    }
}