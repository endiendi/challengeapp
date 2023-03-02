namespace challengeapp
{
    public class Ststistics
    {
        public float Max { get; private set; }

        public float Min { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }
                public float ConfirmedRratingt { get; private set; }

        public float Average
        {
            get
            {
                if (Count == 0)
                {
                    return 0;
                }
                else
                {
                    return this.Sum / this.Count;
                }
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 100:
                        return 'A';
                    case var average when average >= 80:
                        return 'B';
                    case var average when average >= 60:
                        return 'C';
                    case var average when average >= 40:
                        return 'D';
                    case var average when average >= 20:
                        return 'E';
                    default:
                        return 'F';
                }
            }
        }
        public string? PointsCollected { get; private set; }

        public Ststistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min = float.MaxValue;
            this.Max = float.MinValue;
            this.ConfirmedRratingt = 0;

        }
        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
            this.ConfirmedRratingt = grade;

        }
    }
}
