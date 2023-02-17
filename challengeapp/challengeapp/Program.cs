using challengeapp;
User user1 = new User("Adam", "134841");
User user2 = new User("Monika", "16549841");
User user3 = new User("Zuzia", "4568218");
User user4 = new User("Dominik", "456789");


user1.AddScore(5);
user1.AddScore(2);

var result = user1.Result; //wykonanie metody sumowanie
Console.WriteLine(result);
var name = User.GemeName;
var pi = Math.PI;
Console.WriteLine(pi);

