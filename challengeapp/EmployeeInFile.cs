using System.Xml.Linq;

namespace challengeapp
{
    public class EmployeeInFile : EmployeeBase
    {
        public string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
            fileName = $"{Name} {Surname}.txt";
        }

        public override void AddGrade(float grade)
        {

            {
                if (grade >= 0 && grade <= 100)
                {
                    SaveGradeFile(grade, fileName);
                }
                else
                {
                    throw new Exception($"Punkty poza zakresem, prawidłowy zakres to 0-100\n");
                }
            }
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
            SaveGradeFile((float)grade, fileName);
        }

        public override void AddGrade(long grade)
        {
            SaveGradeFile((float)grade, fileName);
        }

        public override void AddGrade(decimal grade)
        {
            SaveGradeFile((float)grade, fileName);
        }

        public override void AddGrade(char grade)
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    SaveGradeFile(100, fileName);
                    break;
                case 'B':
                case 'b':
                    SaveGradeFile(80, fileName);
                    break;
                case 'C':
                case 'c':
                    SaveGradeFile(60, fileName);
                    break;
                case 'D':
                case 'd':
                    SaveGradeFile(40, fileName);
                    break;
                case 'E':
                case 'e':
                    SaveGradeFile(20, fileName);
                    break;
                case 'F':
                case 'f':
                    SaveGradeFile(0, fileName);
                    break;
                default:
                    throw new Exception("Wprowadzono niewłaściwą literę - \"A,B,C,D,E,F\" lub \"Q\" aby wyjść");
            }
        }

        public override Ststistics GetStstistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);

            return result;
        }
        private Ststistics CountReadGradesFromFile(List<float> grades)
        {
            var statistics = new Ststistics();
            foreach (var grade in grades)
            {
                statistics.PointsCollected += grade + ",";
            }
            return statistics;
        }
        public override Ststistics RememberTheCollectedPoints()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountReadGradesFromFile(gradesFromFile);
            return result;
        }


        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reade = File.OpenText(fileName))
                {
                    var line = reade.ReadLine();
                    while (line != null)
                    {
                        var namber = float.Parse(line);
                        grades.Add(namber);
                        line = reade.ReadLine();

                    }
                }
            }
            return grades;
        }
        private Ststistics CountStatistics(List<float> grades)
        {
            var statistics = new Ststistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            if (grades.Count == 0)
            {
                statistics.Max = 0;
                statistics.Min = 0;
                statistics.Average = 0;
            }
            else
            {
                statistics.Average /= grades.Count;
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
        private void SaveGradeFile(float grade, string fileNameS)
        {
            using (var writer = File.AppendText(fileNameS))
            {
                writer.WriteLine(grade);
            }
        }
    }
}
