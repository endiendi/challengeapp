namespace challengeapp
{
    //Określa co ma być zaimplementowane
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(decimal grade);
        void AddGrade(char grade);
        Ststistics GetStstistics();
        Ststistics RememberTheCollectedPoints();
    }
}
