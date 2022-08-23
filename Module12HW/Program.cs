static void Main(string[] args)
{
   	CheckUserData();
}

static void CheckUserData()
{
	
	var user1 = new User();
	Console.WriteLine("Введите логин: ");
	user1.Login = Console.ReadLine();

	Console.WriteLine("Введите имя: ");
	user1.Name = Console.ReadLine();

	if (user1.IsPremium == false)
    {
		ShowAds();
		Console.WriteLine("Привет! " + user1.Name);
	}  
	else
    {
		Console.WriteLine("Привет! " + user1.Name);
    }

}



static void ShowAds()
{
	Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
	// Остановка на 1 с
	Thread.Sleep(1000);

	Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
	// Остановка на 2 с
	Thread.Sleep(2000);

	Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
	// Остановка на 3 с
	Thread.Sleep(3000);
}


class User
{
	public string Login { get; set; }
	public string Name { get; set; }
	public bool IsPremium { get; set; }
}

