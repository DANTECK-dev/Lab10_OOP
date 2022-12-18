using Lab10_OOP.Task1;
using Lab10_OOP.Task2;
using Lab10_OOP.Task3;

namespace Lab10_OOP
{
    public class Rand { public Random random { get; } = new Random(); };
    public class Program
    {
        static void Main(string[] _)
        {
            Task1();
            Task2();
            Task3();
        }
        static void Task1()
        {
            List<Transport> transports = new();
            for (int i = 0; i < 10; i++)
            {
                transports.Add(new Car());
                transports.Add(new Aircraft());
            }

            void Who(List<Transport> trans, int minYear, int minDistnce)
            {
                for (int i = 0; i < trans.Count; i++)
                {
                    switch (trans[i])
                    {
                        case Car car when car.Year >= minYear:
                            car.Show();
                            Console.WriteLine(car.Year);
                            Console.WriteLine("---------------------------------------------------------");
                            break;
                        case Aircraft aircraft when aircraft.Distance >= minDistnce:
                            if (aircraft is Aircraft { Passanger: true })
                            {
                                aircraft.Show();
                                Console.WriteLine(aircraft.Distance);
                                Console.WriteLine("---------------------------------------------------------");
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            Who(transports,
                ReadPositiveInt("Введите минимальный год выпуска автомобиля: "),
                ReadPositiveInt("Введите минимальную дистанцию полёта самолёта: "));

            TheNext("Перейти ко второму заданию, нажмите любую клавишу");
        }
        static void Task2()
        {
            Console.WriteLine();

            List<AuthorizedData> authorizedDatas = new List<AuthorizedData>();
            authorizedDatas.Add(new AuthorizedData() { Login = "UserTest", Access = AccessType.User, Password = "1234" });
            authorizedDatas.Add(new AuthorizedData() { Login = "AdminHere", Access = AccessType.Admin, Password = "qwerty0000" });
            authorizedDatas.Add(new AuthorizedData() { Login = "OperCool", Access = AccessType.Operator, Password = "4321" });
            authorizedDatas.Add(new AuthorizedData() { Login = "asd", Access = AccessType.Operator, Password = "4321" });

            string TaskMethod(AuthorizedData authorizedData) => authorizedData switch
            {
                (_, AccessType.User, _) => "Hello User",
                ("OperCool", AccessType.Operator, _) => "Hello Operator",
                (_, AccessType.Admin, "qwerty0000") => "Hello " + authorizedData.Login,
                _ => "Unknow data"

            };

            authorizedDatas.ForEach(x => Console.WriteLine($"{TaskMethod(x)}\n------------------------"));

            TheNext("Перейти к третьему заданию, нажмите любую клавишу");
        }
        static void Task3()
        {
            Console.WriteLine();

            List<EmployeeData> employeeDatas = new List<EmployeeData>();

            for (int i = 0; i < 5; i++)
            {
                employeeDatas.Add(new EmployeeData());
            }

            employeeDatas.ForEach(x => Console.WriteLine($"{x}\n------------------------"));

        }
        public static int ReadInt()
        {
            string str;

            do str = Console.ReadLine();
            while (!int.TryParse(str, out _));

            return int.Parse(str);
        }
        public static int ReadInt(string mess)
        {
            string str;

            do
            {
                Console.Write(mess);
                str = Console.ReadLine();
            }
            while (!int.TryParse(str, out _));

            return int.Parse(str);
        }
        public static int ReadPositiveInt(string mess)
        {
            int positiveInt;

            do positiveInt = ReadInt(mess);
            while (positiveInt < 0);

            return positiveInt;
        }
        public static void TheNext()
        {
            Console.Write("Чтобы продолжить, нажмите любую клавишу");
            Console.ReadKey();
        }
        public static void TheNext(string mess)
        {
            Console.Write(mess);
            Console.ReadKey();
            Console.WriteLine();
        }
        public static void PrintList<T>(List<T> list)
        {
            Console.Write("Массив [");
            list.ForEach(x => Console.Write($" {x} "));
            Console.WriteLine("]");
        }
    }
}