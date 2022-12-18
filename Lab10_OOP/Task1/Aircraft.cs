namespace Lab10_OOP.Task1
{
    internal class Aircraft : Transport
    {
        public bool Passanger { get; set; }
        public int Distance { get; set; }
        public Aircraft()
        {
            Random random = new();
            bool[] bools = { true,false };
            Passanger = bools[random.Next(0, 2)];
            Distance = random.Next(4000, 20000);
        }
        public override void Show()
        {
            Console.Write($"Distance - {Distance} ");
            base.Show();
        }
    }
}
