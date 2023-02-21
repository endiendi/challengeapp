namespace challengeapp
{
    public class Employee
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;

        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            //3,33
            //3
            //int valueInInt = (int)grade;
            //int valueInInt = Math.Floor(grade);
            //var valueInInt = Math.Ceiling(grade);

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Punkty poza zakresem, prawidłowy zakres to 0-100");
            }

        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Błędna wartość - tekst zamiast cyfry");
            }
            //var value=float.Parse(grade);
            //this.grades.Add(value);
        }

        public Ststistics GetStstistics()
        {
            var statistics = new Ststistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            //
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }


}
