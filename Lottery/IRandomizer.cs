namespace Lottery
{
    public interface IRandomizer
    {
        /// <summary>
        /// Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.
        /// </summary>
        float Random { get; }
    }
}
