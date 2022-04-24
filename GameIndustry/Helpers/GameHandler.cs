namespace GameIndustry.Helpers
{
    public class GameHandler
    {
        public RSPOptions Choose { get; set; }
        public RSPOptions WinCondition { get; set; }

        public RSPOptions LoseCondition { get; set; }
        public string ImagePath { get; set; }
        public GameState GameResult(GameHandler opponent)
        {
            if (Choose == opponent.Choose)
                return GameState.Draw;
            if (LoseCondition == opponent.Choose)
                return GameState.Lose;

            return GameState.Victory;
        }

    }

}
