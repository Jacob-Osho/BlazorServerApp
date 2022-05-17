using GameIndustry.Models;
using System.Collections.Generic;

namespace GameIndustry.Repository
{
    public interface IRepository
    {
        public List<Game> GetAllGames();
    }
}
