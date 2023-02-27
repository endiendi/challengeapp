using System.Diagnostics;

namespace challengeapp
{
    public class Supervision : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervision(string name, string surname, char gender, int age)
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


        public void AddGrade(float grade)
        {
            if (grade >= -5 && grade <= 105)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception($"Punkty poza zakresem, prawidłowy zakres to 0-105\n");
            }
        }
        public void AddGrade(string grade)
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

            if (grade == polarization + "6" || grade == "6" + polarization || grade == "A" + polarization || grade == polarization + "A")
            {
                this.AddGrade(100 + halfPoints);
            }
            else if (grade == polarization + "5" || grade == "5" + polarization || grade == "B" + polarization || grade == polarization + "B")
            {
                this.AddGrade(80 + halfPoints);
            }
            else if (grade == polarization + "4" || grade == "4" + polarization || grade == "C" + polarization || grade == polarization + "C")
            {
                this.AddGrade(60 + halfPoints);
            }
            else if (grade == polarization + "3" || grade == "3" + polarization || grade == "D" + polarization || grade == polarization + "D")
            {
                this.AddGrade(40 + halfPoints);
            }
            else if (grade == polarization + "2" || grade == "2" + polarization || grade == "E" + polarization || grade == polarization + "E")
            {
                this.AddGrade(20 + halfPoints);
            }
            else if (grade == polarization + "1" || grade == "1" + polarization || grade == "F" + polarization || grade == polarization + "F")
            {
                this.AddGrade(0 + halfPoints);
            }
            else
            {
                throw new Exception("Błędna wartość - wybierz \"A,B,C,D,E,F, 6-1\" lub \"Q\" aby wyjść\n");
            }
        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(decimal grade)
        {
            this.AddGrade((float)grade);
        }

        public void AddGrade(char grade)
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
        public Ststistics GetStstistics()
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
        public Ststistics RememberTheCollectedPoints()
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

