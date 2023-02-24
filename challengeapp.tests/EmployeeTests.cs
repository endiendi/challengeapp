namespace challengeapp.tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenInvokedToFetchStatisticsForAnEmptyValueIt_ShouldReturnAnAverageOfZero()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade("");

            //act
            var statistics = employee.GetStstisticsForEch();

            //assert
            Assert.AreEqual(0, statistics.Average);

        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(1);
            employee.AddGrade(6);


            //act
            var statistics = employee.GetStstisticsForEch();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
        [Test]
        public void WhenYouCallGetPointsCollectedForThey_ShouldReturnPointsCollected()
        {
            var employee = new Employee("Adam", "Kowalski");
            //arrange
            employee.AddGrade(1);
            employee.AddGrade(2);
            employee.AddGrade('C');
            employee.AddGrade(4);
            employee.AddGrade('E');

            //act
            var statistics = employee.RememberTheCollectedPoints();

            //assert
            Assert.AreEqual("1,2,60,4,20,", statistics.PointsCollected);
        }
        [Test]
        public void WhenGetStatisticsiscalledit_shouldreturntheaverageoftheliteralvalues()
        {
            var employee = new Employee("Adam", "Kowalski");
            //arrange
            employee.AddGrade('a');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('E');


            //act
            var statistics = employee.GetStstisticsForEch();

            //assert
            Assert.AreEqual(100, statistics.Max);
        }

        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            var employee = new Employee("Adam", "Kowalski");
            //arrange
            employee.AddGrade(6);
            employee.AddGrade(2);
            employee.AddGrade(6);
            employee.AddGrade(1);
            employee.AddGrade(6);


            //act
            var statistics = employee.GetStstisticsForEch();

            //assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void WhenGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            var employee = new Employee("Adam", "Kowalski");
            //arrange
            employee.AddGrade(0);
            employee.AddGrade(0);
            employee.AddGrade(0);
            employee.AddGrade(0);
            employee.AddGrade(6);


            //act
            var statistics = employee.GetStstisticsForEch();

            //assert
            Assert.AreEqual(Math.Round(1.2, 2), Math.Round(statistics.Average, 2));
        }
    }

}
