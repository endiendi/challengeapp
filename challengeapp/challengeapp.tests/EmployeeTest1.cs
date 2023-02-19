namespace challengeapp.tests
{
    public class Tests
    {

        [Test]
        public void ValidateEmployeePointswhennegative()
        {
            //Assert.Pass();

            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddScore(-1);
            employee.AddScore(1);
            employee.AddScore(1);
            employee.AddScore(1);
            employee.AddScore(1);

            //act
            var result = employee.Result;

            //assert

            Assert.AreEqual(3, result);


        }

        [Test]
        public void CheckTheCorrectnessOfTheEmployeesPoints()
        {
            //Assert.Pass();

            //arrange
            var employee = new Employee("Adam", "Kowalski", 35);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(4);
            employee.AddScore(5);
            employee.AddScore(5);
            //act
            var result = employee.Result;

            //assert

            Assert.AreEqual(25, result);


        }
    }
}