// See https://aka.ms/new-console-template for more information
using Lottery;

var lottery = new RandomizableLottery(new DotnetRandomizer(), 0.5f);
bool result = lottery.Draw();
Console.WriteLine($"Lottery Result: {result}");
