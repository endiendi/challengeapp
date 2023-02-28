namespace challengeapp
{
    public abstract class EmployeeBase : IEmployee
    {

        public EmployeeBase(string name, string surname )

        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Surname { get; private set; }
        public string Name { get; private set; }

        public virtual void SayHello()
        {
            Console.WriteLine($"Hello! I am {Name} {Surname}");
        }
        public abstract void AddGrade(float grade);

        public abstract void AddGrade(string grade);


        public abstract void AddGrade(double grade);


        public abstract void AddGrade(long grade);


        public abstract void AddGrade(decimal grade);


        public abstract void AddGrade(char grade);


        public abstract Ststistics GetStstistics();


        public abstract Ststistics RememberTheCollectedPoints();

    }
}
