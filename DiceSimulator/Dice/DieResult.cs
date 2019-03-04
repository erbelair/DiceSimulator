namespace DiceSimulator.Dice
{
    public class DieResult
    {
        public int Value { get; private set; }
        public string Name { get; private set; }

        public DieResult(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
