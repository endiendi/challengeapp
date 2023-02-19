using Newtonsoft.Json.Linq;

namespace challengeapp.tests
{
    public class TypeTests
    {

        [Test]
        public void GetValuesInt_ShouldReturnTheCorrectValue()
        {
            //arrange
            int namber1 = 2;
            int namber2 = 2;

            //act


            //assert
            Assert.AreEqual(namber1, namber2);

        }

        [Test]
        public void GetValuesString_ShouldReturnTheCorrectValue()
        {
            //arrange
            string namber1 = "Andrzej";
            string namber2 = "Andrzej";

            //act


            //assert
            Assert.AreEqual(namber1, namber2);

        }

        [Test]
        public void GetValuesDouble_ShouldReturnTheCorrectValue()
        {
            //arrange
            double namber1 = 2.12;
            double namber2 = 5.15;

            //act


            //assert
            Assert.AreNotEqual(namber1, namber2);

        }

        [Test]
        public void TGetUserShuldRetrutnDifferentObects()
        {
            //arrange
            var user1 = GetUser("Adam", "aa");
            var user2 = GetUser("Tomasz", "aa");

            //act


            //assert
            Assert.AreNotEqual(user1.Login, user2.Login);

        }
        private User GetUser(string name, string asd)
        {
            return new User(name, asd);
        }
    }
}