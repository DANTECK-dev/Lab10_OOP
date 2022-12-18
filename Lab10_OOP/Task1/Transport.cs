namespace Lab10_OOP.Task1
{
    internal abstract class Transport
    {
        public string? Name { get; set; }
        protected Transport()
        {
            Random random = new();
            string[] names =
            {
                "Автокам",
                "Бронто",
                "ГАЗ",
                "Ё-мобиль",
                "ЗАЗ",
                "ЗИЛ",
                "ЗиС",
                "ИЖ",
                "Канонир",
                "Комбат",
                "ЛуАЗ",
                "Москвич",
                "СМ",
                "ТагАЗ",
                "УАЗ",
                "Эксклюзив",
                "AC",
                "Acura",
                "Adler",
                "Alfa Romeo",
                "Alpina"
            };
            int s = random.Next(names!.Length);
            Name = names[s];
        }
        public virtual void Show() => Console.WriteLine($"Name - {Name} ");
    }
}
