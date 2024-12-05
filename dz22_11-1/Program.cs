namespace dz22_11_1
{
    internal class Program
    {
        class MusicalInstrument
        {
            protected string Name;
            protected string Description;
            protected string HistoryText;

            public MusicalInstrument(string name, string description, string history)
            {
                Name = name;
                Description = description;
                HistoryText = history;
            }

            public virtual void Sound()
            {
                Console.WriteLine("Звук");
            }

            public void Show()
            {
                Console.WriteLine($"Назва: {Name}");
            }

            public void Desc()
            {
                Console.WriteLine($"Опис: {Description}");
            }

            public void History()
            {
                Console.WriteLine($"Історія: {HistoryText}");
            }
        }


        class Violin : MusicalInstrument
        {
            public Violin() : base("Скрипка", "Скрипка — струнно-смичковий інструмент.", "Винайдена у XVI столітті в Італії.")
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Скрипка видає мелодійний звук.");
            }
        }


        class Trombone : MusicalInstrument
        {
            public Trombone() : base("Тромбон", "Тромбон — духовий інструмент з кроною.", "З'явився у XV столітті.")
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Тромбон видає низький і потужний звук.");
            }
        }


        class Ukulele : MusicalInstrument
        {
            public Ukulele() : base("Укулеле", "Укулеле — невелика гітара з Гаваїв.", "З'явилася у XIX столітті.")
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Укулеле видає легкий і веселий звук.");
            }
        }


        class Cello : MusicalInstrument
        {
            public Cello() : base("Віолончель", "Віолончель — струнно-смичковий інструмент середнього розміру.", "З'явилася у XVI столітті.")
            {
            }

            public override void Sound()
            {
                Console.WriteLine("Віолончель видає глибокий і емоційний звук.");
            }
        }
        static void Main(string[] args)
        {

            Violin violin = new Violin();
            Trombone trombone = new Trombone();
            Ukulele ukulele = new Ukulele();
            Cello cello = new Cello();


            Console.WriteLine("Скрипка:");
            violin.Sound();
            violin.Show();
            violin.Desc();
            violin.History();
            Console.WriteLine();

            Console.WriteLine("Тромбон:");
            trombone.Sound();
            trombone.Show();
            trombone.Desc();
            trombone.History();
            Console.WriteLine();

            Console.WriteLine("Укулеле:");
            ukulele.Sound();
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();
            Console.WriteLine();

            Console.WriteLine("Віолончель:");
            cello.Sound();
            cello.Show();
            cello.Desc();
            cello.History();
        }
    }
}
