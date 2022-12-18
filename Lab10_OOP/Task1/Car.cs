namespace Lab10_OOP.Task1
{
    internal class Car : Transport
    {
        public int Year { get; set; }
        public string? Company { get; set; }
        public Car()
        {
            Random random = new();
            Year = random.Next(1900, 2022);
            string[] companys =
            {
                "Акура",
                "Альфа Ромео",
                "Ауди",
                "Аурус",
                "Б",
                "Би-Уай-Ди",
                "БМВ",
                "Бриллианс",
                "Бугатти",
                "Бьюик",
                "Бэнтли",
                "В",
                "Вольво",
                "Г",
                "ГАЗ",
                "Грэйт волл",
                "Д",
                "Дайхацу",
                "Датсун",
                "Джей Эй Си",
                "Дженезис",
                "Джи-Эй-Си",
                "Джили",
                "Джип",
                "Додж",
                "Дунфэн",
                "Дэу"
            };
            Company = companys[random.Next(companys.Length)];
        }
        public override void Show()
        {
            Console.Write($"Company - {Company} ");
            base.Show();
        }

    }
}
