using System;

// Настрой интерфейсы для шутников и клоунов так чтобы все заработало 

// Шуточный интерфейс "Способность танцевать"
interface IDanceable
{
    public void Dance();
}

// Шуточный интерфейс "Способность петь"
interface ISingable
{
    public void Sing();
}


internal interface ITalkable
{
    public void Talk();
}

internal interface IJokeable
{
    public void TellJoke();
}

// Класс шутника, реализующий ITalkable, IJokeable, IDanceable и ISingable
class Joker : IDanceable, ISingable, ITalkable, IJokeable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я мастер шуток и разговоров.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему ученые не доверяют атомам? Потому что они составляют все!");
    }

    public void Dance()
    {
        Console.WriteLine("Я танцую, как будто никто не видит!");
    }

    public void Sing()
    {
        Console.WriteLine("Ла ла ла! Я певчая сенсация!");
    }
}


// Класс клоуна, реализующий ITalkable и IJokeable
class Clown : ITalkable, IJokeable
{
    public void Talk()
    {
        Console.WriteLine("Привет! Я здесь, чтобы заставить вас улыбнуться.");
    }

    public void TellJoke()
    {
        Console.WriteLine("Почему пугало получило награду? Потому что оно было выдающимся на своем поле!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляры шутника и клоуна 
        ITalkable clown = new Clown();
        IJokeable clown1 = new Clown();
        ITalkable joker = new Joker();
        IJokeable joker1 = new Joker();
        IDanceable joker2 = new Joker();
        ISingable joker3 = new Joker();
        // Используем методы через интерфейсы
        clown.Talk();
        clown1.TellJoke();
        joker.Talk(); 
        joker1.TellJoke();
        joker2.Dance();
        joker3.Sing();
    }
}
