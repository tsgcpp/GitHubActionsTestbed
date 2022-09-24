namespace Lottery
{
    public sealed class RandomizableLottery : ILottery
    {
        private readonly IRandomizer _randomizer;

        public RandomizableLottery(IRandomizer randomizer, float firstFloor = 0.9f)
        {
            _randomizer = randomizer;
            Floor = firstFloor;
        }

        public float Floor { get; }

        public bool Draw()
        {
            float random = _randomizer.Random;
            if (random < Floor)
            {
                return false;
            }

            return true;
        }
    }
}
