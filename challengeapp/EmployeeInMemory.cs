namespace challengeapp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public delegate void GradeAddedDelegate(object sender, EventArgs args, float punkty);

        public event GradeAddedDelegate GradeAdded;

        public delegate void AllRatingsDelegate(object sender, EventArgs args, string punkty);

        public event AllRatingsDelegate AllRatings;
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            this.Name = name;
            this.Surname = surname;

            //WriteMessage del;
            //del = WritrMessageInConsole;
            //del += WritrMessageInConsole2;
            //del("Mój tekst");
            //del -= WritrMessageInConsole;
            //del("Mój tekst 2");
            //var result1 = del("Mój tekst");
            //var result2 = del = ReturnMessagr;
            //WritrMessageInConsole("Mój tekst1");

        }
        private void WritrMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }
        private void WritrMessageInConsole2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        private string ReturnMessagr(string message)
        {
            return message;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }


        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, EventArgs.Empty, grade);
                }
            }
            else
            {
                throw new Exception($"Punkty poza zakresem, prawidłowy zakres to 0-100\n");
            }
        }

        public override void SayHello()
        {
            Console.WriteLine($"HI!!!");
            base.SayHello();
        }
        public override void AddGrade(string grade)
        {
            string stringTest = grade.ToUpper();

            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (stringTest == "A")
            {
                this.AddGrade('A');
            }
            else if (stringTest == "B")
            {
                this.AddGrade('B');
            }
            else if (stringTest == "C")
            {
                this.AddGrade('C');
            }
            else if (stringTest == "D")
            {
                this.AddGrade('D');
            }
            else if (stringTest == "E")
            {
                this.AddGrade('E');
            }
            else if (stringTest == "F")
            {
                this.AddGrade('F');
            }
            else
            {
                throw new Exception("Błędna wartość - wybierz \"A,B,C,D,E,F, 0-100\" lub \"Q\" aby wyjść\n");
            }
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                case 'F':
                case 'f':
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("Wprowadzono niewłaściwą literę - \"A,B,C,D,E,F\" lub \"Q\" aby wyjść");
            }
        }

        public override Ststistics GetStstistics()
        {
            var statistics = new Ststistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            if (this.grades.Count == 0)
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }
            else
            {
                statistics.Average /= this.grades.Count;
            }
            switch (statistics.Average)
            {
                case var average when average >= 100:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 80:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }
            return statistics;
        }

        public override Ststistics RememberTheCollectedPoints()
        {
            var statistics = new Ststistics();

            foreach (var grade in this.grades)
            {
                statistics.PointsCollected += grade + ",";
            }
            return statistics;
        }
    }
}
