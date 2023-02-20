﻿namespace challengeapp
{
    public class Employee
    {
        private List<float> grades = new List<float>();


        public Employee(string name, string surname)//, int age)
        {
            this.Name = name;
            this.Surname = surname;
            //this.Age = age;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        //public int Age { get; private set; }

        //public float Result
        //{
        //   get
        //  {
        //       return this.grades.Sum();
        //   }

        //        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
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
                //statistics.Average = statistics.Average+ grade;
                statistics.Average += grade;
            }
            //statistics.Average = statistics.Average / this.grades.Count;
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }


}
