namespace challengeapp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            this.Name = name;
            this.Surname = surname;
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
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade == "A" || grade == "a")
            {
                this.AddGrade('A');
            }
            else if (grade == "B" || grade == "b")
            {
                this.AddGrade('B');
            }
            else if (grade == "C" || grade == "c")
            {
                this.AddGrade('C');
            }
            else if (grade == "D" || grade == "d")
            {
                this.AddGrade('D');
            }
            else if (grade == "E" || grade == "e")
            {
                this.AddGrade('E');
            }
            else if (grade == "F" || grade == "f")
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
