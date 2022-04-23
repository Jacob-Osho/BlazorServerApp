using GameIndustry.Models;
using System;
using System.Collections.Generic;

namespace GameIndustry.Repository
{
    public class MockGamesRepositories : IRepository
    {
        private List<Game> _games;
        public MockGamesRepositories()
        {
            _games = new List<Game>()
            {
                new Game()
                {
                    Name = "Farming Simulator",
                    Genre = "Simulator",
                    ReleaseDate = new DateTime(2018, 11, 19)

                },
                new Game()
                {
                    Name = "The Witcher 3",
                    Genre = "Action/RPG",
                    ReleaseDate = new DateTime(2015, 05, 18)

                },
                new Game()
                {
                    Name = "Destroy all Humans",
                    Genre = "Actio-advanture",
                    ReleaseDate = new DateTime(2020, 07, 28)

                }

            };
        }
        public List<Game> GetAllGames()
        {
            return _games;
        }
    }
}
