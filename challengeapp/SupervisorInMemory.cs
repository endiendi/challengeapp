
namespace challengeapp
{
    public class SupervisorInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();
        public SupervisorInMemory(string name, string surname, char gender, int age)
            : base(name, surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(float grade)
        {
            if (grade >= -5 && grade <= 105)
            {
                this.grades.Add(grade);
                Eventa(grade);
            }
            else
            {
                throw new Exception($"Punkty poza zakresem, prawidłowy zakres to 0-105\n");
            }
        }

        public override void AddGrade(string grade)
        {
            int halfPoints = 0;
            string polarization = "";

            grade = grade.ToUpper();
            if (grade.Contains("+"))
            {
                halfPoints = 5;
                polarization += "+";
            }
            else if (grade.Contains("-"))
            {
                halfPoints = -5;
                polarization += "-";
            }
            if (grade == $"{polarization}6" || grade == $"6{polarization}" || grade == $"A{polarization}" || grade == $"{polarization}A")
            {
                this.AddGrade(100 + halfPoints);
            }
            else if (grade == $"{polarization}5" || grade == $"5{polarization}" || grade == $"B{polarization}" || grade == $"{polarization}B")
            {
                this.AddGrade(80 + halfPoints);
            }
            else if (grade == $"{polarization}4" || grade == $"4{polarization}" || grade == $"C{polarization}" || grade == $"{polarization}C")
            {
                this.AddGrade(60 + halfPoints);
            }
            else if (grade == $"{polarization}3" || grade == $"3{polarization}" || grade == $"D{polarization}" || grade == $"{polarization}D")
            {
                this.AddGrade(40 + halfPoints);
            }
            else if (grade == $"{polarization}2" || grade == $"2{polarization}" || grade == $"E{polarization}" || grade == $"{polarization}E")
            {
                this.AddGrade(20 + halfPoints);
            }
            else if (grade == $"{polarization}1" || grade == $"1{polarization}" || grade == $"F{polarization}" || grade == $"{polarization}F")
            {
                this.AddGrade(0 + halfPoints);
            }
            else
            {
                throw new Exception("Błędna wartość - wybierz \"A,B,C,D,E,F, 6-1\" lub \"Q\" aby wyjść\n");
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
                    throw new Exception(" char Wprowadzono niewłaściwą literę - \"A,B,C,D,E,F\" lub \"Q\" aby wyjść");
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
