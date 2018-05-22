
namespace BowlingReportSystem.Model
{
    class Player
    {
        public string name;
        public int[] points;

        public Player(PlayerBuilder builder)
        {
            this.name = builder.name;
            this.points = builder.points;
        }
    }
}
