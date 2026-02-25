using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Dog dog = new Dog();
dog.Name = "초코";
dog.Age = 3;
dog.Bark();
Console.WriteLine($"이름: {dog.Name}, 나이: {dog.Age}살");

Monster monster1 = new Monster();
var monster2 = new Monster();
Console.WriteLine(monster1);
Console.WriteLine(monster2);

Calculator cal = new Calculator();
cal.Add(3, 5);
cal.Multiply(4, 6);

Counter count = new Counter();
count.Increment();
count.Increment();
count.Increment();
count.Reset();

GameManager.TotalPlayers = 10;
GameManager.ShowStatus();
GameManager manager = new GameManager();
manager.PlayerName = "홍길동";
manager.Greet();

Greeting.SayHello();
Farewell.Wave();
Greeting greeting = new Greeting();
greeting.SayGoodbye();
Farewell farewell = new Farewell();
farewell.Bow();

Item item = new Item();
item.Name = "포션";
item.Price = 100;
Console.WriteLine(item);

Player player1 = new Player();
player1.Name = "전사";
player1.Level = 10;
player1.Health = 200;
Player player2 = new Player();
player2.Name = "마법사";
player2.Level = 8;
player2.Health = 120;
Console.WriteLine(player1);
Console.WriteLine(player2);

Enemy[] enemies = new Enemy[3];

enemies[0] = new Enemy();
enemies[0].Name = "고블린";
enemies[0].Health = 50;
enemies[1] = new Enemy();
enemies[1].Name = "오크";
enemies[1].Health = 100;
enemies[2] = new Enemy();
enemies[2].Name = "드래곤";
enemies[2].Health = 500;

for (int i = 0; i < enemies.Length; i++)
{
    enemies[i].ShowInfo();
}

Item[] items = new Item[3];

items[0] = new Item
{
    Name = "검",
    Price = 500
};

items[1] = new Item
{
    Name = "방패",
    Price = 300
};

items[2] = new Item
{
    Name = "포션",
    Price = 50
};

Console.WriteLine("=== 인벤토리 ===");
foreach (Item i in items)
{
    Console.WriteLine(i);
}

Character char1 = new Character();
char1.Name = "홍길동";
char1.Level = 1;
char1.Job = "전사";

Character char2 = new Character
{
    Name = "이순신",
    Level = 5,
    Job = "궁수"
};

Console.WriteLine(char1);
Console.WriteLine(char2);

Student[] students = new Student[3]
{
    new Student { Name = "김철수", Score = 85 },
    new Student { Name = "이영희", Score = 92 },
    new Student { Name = "박민수", Score = 78 }
};

foreach (var student in students)
{
    Console.WriteLine(student);
}