using static Lab10_OOP.Rand;

namespace Lab10_OOP.Task3
{
    enum Status
    {
        Director,
        Worker
    }
    delegate int SalaryCalculate(Status status);
    delegate double Rate(int Exp);
    internal class EmployeeData
    {
        SalaryCalculate SC = SalaryCalcul;
        Rate rate = CalcRate;

        private int experience;
        public string? Name { get; set; }
        public Status Status { get; set; }
        public int Experience { get => experience; set => experience = value >= 0 ? value : 0; }
        public double Salary { get => SC(Status) * rate(experience); }

        public EmployeeData()
        {
            string[] names =
            {
                "Алексей",
                "Иван",
                "Марьям",
                "Всеволод",
                "Роман",
                "Мирослав",
                "Серафима",
                "Иван",
                "Билал",
                "Александра",
                "Екатерина",
                "Диана",
                "Всеволод",
                "Ева"
            };
            Random random = new Random();
            Name = names[random.Next(names.Length)];
            Status = (Status)random.Next(0, 2);
            Experience = random.Next(1, 20);
        }

        public override string ToString()
        {
            return "Name: " + Name + "\n" + ""
                + "Status: " + Status + "\n" + ""
                + "Experience: " + Experience + "\n" + ""
                + "Salary: " + Salary;
        }

        public static int SalaryCalcul(Status status) => status switch
        {
            Status.Director => 100000,
            Status.Worker => 50000,
            _ => 0
        };
        public static double CalcRate(int exp)
        {
            return exp switch
            {
                < 3 => 1,
                >= 3 and < 5 => 1.1,
                >= 5 => 2
            };
        }
    }
}
