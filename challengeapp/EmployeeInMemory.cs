namespace challengeapp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
            this.Name = name;
            this.Surname = surname;
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
                Eventa(grade);
            }
            else
            {
                throw new Exception($"Punkty poza zakresem, prawidłowy zakres to 0-100\n");
            }
        }
        public override void AddGrade(string grade)
        {
            string gradeToUpper = grade.ToUpper();

            if (float.TryParse(gradeToUpper, out float result))
            {
                this.AddGrade(result);
            }
            else if (gradeToUpper == "A")
            {
                this.AddGrade('A');
            }
            else if (gradeToUpper == "B")
            {
                this.AddGrade('B');
            }
            else if (gradeToUpper == "C")
            {
                this.AddGrade('C');
            }
            else if (gradeToUpper == "D")
            {
                this.AddGrade('D');
            }
            else if (gradeToUpper == "E")
            {
                this.AddGrade('E');
            }
            else if (gradeToUpper == "F")
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
            {
                foreach (var gradr in this.grades)
                {
                    statistics.AddGrade(gradr);
                }
            }
            return statistics;
        }
        private void Eventa(float grade)
        {
            if (GradeAdded != null)
            {
                GradeAdded(this, EventArgs.Empty, grade);
            }
        }
    }
}
