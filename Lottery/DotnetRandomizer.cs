namespace Lottery
{
    public sealed class DotnetRandomizer : IRandomizer
    {
        private readonly Random _random = new Random();

        public float Random => (float)_random.NextDouble();
    }
}
