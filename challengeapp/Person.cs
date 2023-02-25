namespace challengeapp
{
    public abstract class Person// :System.Object
    {
        //protected int caunter;
        public Person(string name, string surname,char gender, int age)
        {
            this.Name=name;
            this.Surname = surname;
            this.Gender = gender;
            this.Age = age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Gender { get; private set; }
        public int Age { get; private set; }

    }
}
