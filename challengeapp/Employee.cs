using System;
using System.Diagnostics;

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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Punkty poza zakresem, prawidłowy zakres \t{grade}\t zakres to 0-100\n");
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
                Console.WriteLine("Błędna wartość - tekst zamiast cyfry\n");
            }
        }
        //public void AddGrade(int grade)
        //{
        //    this.AddGrade((float)grade);
        //}
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

        public Ststistics GetStstistics()
        {
            var statistics = new Ststistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            //var index = 0;

            //while (index < this.grades.Count) 
            //{
            //    if (this.grades[index] == this.grades.Count)
            //    {
            //        break;
            //    }

            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;
            //} 

            //var index = 0;

            //do
            //{
            //    statistics.Max = Math.Max(statistics.Max, this.grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, this.grades[index]);
            //    statistics.Average += this.grades[index];
            //    index++;
            //} while (index<this.grades.Count);


            //
            foreach (var grade in this.grades)

            //break
            //continue
            //goto
            {
                if (grade < 0) //Jeżeli warunek spełniony to wykonuj to co poniżej
                {
                    continue; //Jeżeli warunek spełniony to wykonuj to co poniżej

                }


                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
        //here:
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }


}
