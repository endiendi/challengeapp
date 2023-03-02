namespace challengeapp
{
    public class EmployeeInFile : EmployeeBase
    {
        private string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
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
            var gradesFromFile = this.ReadGradesFromFile(fileName);
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile(string fileNameS)
        {
            var grades = new List<float>();
            if (File.Exists(fileNameS))
            {
                using (var reade = File.OpenText(fileNameS))
                {
                    var line = reade.ReadLine();
                    while (line != null)
                    {
                        try
                        {
                            var namber = float.Parse(line);
                            grades.Add(namber);
                            line = reade.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine($"Plik {fileNameS} jest uszkodzony, usuń plik! \n");
                            break;
                        }
                    }
                }
            }
            return grades;
        }
        private Ststistics CountStatistics(List<float> grades)
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
        private void SaveGradeFile(float grade, string fileNameS)
        {
            using (var writer = File.AppendText(fileNameS))
            {
                writer.WriteLine(grade);
            }
        }
    }
}
