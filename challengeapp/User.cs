
namespace challengeapp
{
    public class User
    {
        public static string GemeName = "Diablo";
        private List<int> score = new List<int>();
        public User(string login, string password)  //Konstruktor z parametrem pozwala twożyć unikatowych użytkowników
        {
            this.Login = login;  //this -  'to jest' pozwala przypisać zmienną do zmiennej
            this.Password = password;

        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }

        public void AddScore(int namber)
        {
            this.score.Add(namber);
        }
    }
}

