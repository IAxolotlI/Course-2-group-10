namespace Example;
using System.Net;
using System.IO;
using System;
using System.Text.Json;
public class Bpi
{
    public USD USD { get; set; }
    public GBP GBP { get; set; }
    public EUR EUR { get; set; }
}
public class Time
{
    public string updated { get; set; }
    public DateTime updatedISO { get; set; }
    public string updateduk { get; set; }
}

public class USD
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}
public class EUR
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}
public class GBP
{
    public string code { get; set; }
    public string symbol { get; set; }
    public string rate { get; set; }
    public string description { get; set; }
    public double rate_float { get; set; }
}
public class CoindeskResponse
{
    public Time time { get; set; }
    public string disclaimer { get; set; }
    public string chartName { get; set; }
    public Bpi bpi { get; set; }
}


public class Cat
{
    public string fact { get; set; }
    public int length { get; set; }
}

public class Joke
{
    public string type { get; set; }
    public string setup { get; set; }
    public string punchline { get; set; }
    public int id { get; set; }
}

public class listUni
{
    public List<Uni> list { get; set; }
}

public class Uni
{
    public string name { get; set; }
    public string alpha_two_code { get; set; }
    public List<string> domains { get; set; }

    public string? stateprovince { get; set; }
    public string country { get; set; }
    public List<string> web_pages { get; set; }
}


public class Coordinates
{
    public string latitude { get; set; }
    public string longitude { get; set; }
}
public class Dob
{
    public DateTime date { get; set; }
    public int age { get; set; }
}
public class Id
{
    public string name { get; set; }
    public string value { get; set; }
}
public class Info
{
    public string seed { get; set; }
    public int results { get; set; }
    public int page { get; set; }
    public string version { get; set; }
}
public class Location
{
    public Street street { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string postcode { get; set; }
    public Coordinates coordinates { get; set; }
    public Timezone timezone { get; set; }
}
public class Login
{
    public string uuid { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public string salt { get; set; }
    public string md5 { get; set; }
    public string sha1 { get; set; }
    public string sha256 { get; set; }
}
public class Name
{
    public string title { get; set; }
    public string first { get; set; }
    public string last { get; set; }
}
public class Picture
{
    public string large { get; set; }
    public string medium { get; set; }
    public string thumbnail { get; set; }
}
public class Registered
{
    public DateTime date { get; set; }
    public int age { get; set; }
}
public class Result
{
    public string gender { get; set; }
    public Name name { get; set; }
    public Location location { get; set; }
    public string email { get; set; }
    public Login login { get; set; }
    public Dob dob { get; set; }
    public Registered registered { get; set; }
    public string phone { get; set; }
    public string cell { get; set; }
    public Id id { get; set; }
    public Picture picture { get; set; }
    public string nat { get; set; }
}
public class Street
{
    public int number { get; set; }
    public string name { get; set; }
}
public class Timezone
{
    public string offset { get; set; }
    public string description { get; set; }
}
public class Humans
{
    public List<Result> results { get; set; }
    public Info info { get; set; }
}


public class Names
{
    public int count { get; set; }
    public string name { get; set; }
    public string gender { get; set; }
    public double probability { get; set; }
}


class Program
{
    public static string GetRequest(string url) // функция принимает адерс api
    {
        WebRequest request = WebRequest.Create(url); // создаем запрос
        WebResponse response = request.GetResponse(); // отправляем команду на получение ответа
        Stream dataStream = response.GetResponseStream(); // открываем поток для чтения (это как File.Readline только для сети)
        StreamReader streamReader = new StreamReader(dataStream); // Открываем чтение потока
        string jsonResponse = streamReader.ReadToEnd(); // получаем текст

        streamReader.Close();   // закрываем за собой чтение потока
        response.Close();
        return jsonResponse;  // возвращаем ответ
    }

    static void Main(string[] args)
    {
        //PRACTICE A
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        string coindeskURL = "https://api.coindesk.com/v1/bpi/currentprice.json"; // наша ссылка для  битка
        string jsonFromCoindesk = GetRequest(coindeskURL);  // поулчение ответа в виде json файла
        
        string country = "Kazakhstan";
        string jsonFromCat = GetRequest("https://catfact.ninja/fact");
        string jsonfromjoke = GetRequest("https://official-joke-api.appspot.com/random_joke");
        string jsonfromlistuni = GetRequest($"http://universities.hipolabs.com/search?country={country}");

        CoindeskResponse response = JsonSerializer.Deserialize<CoindeskResponse>(jsonFromCoindesk); // десериализация
        
        Cat response2 = JsonSerializer.Deserialize<Cat>(jsonFromCat);

        Joke response3 = JsonSerializer.Deserialize<Joke>(jsonfromjoke);

        //listUni response4 = JsonSerializer.Deserialize<listUni>(jsonfromlistuni, options);
        var universities = JsonSerializer.Deserialize<List<Uni>>(jsonfromlistuni, options);
        double bitcoinPrice = response.bpi.USD.rate_float; // получение нужной инфы
        Console.Write("Bitcoin price : " + bitcoinPrice + "\n"); // вывод
        
        Console.Write(response2.fact + "\n");

        Console.Write(response3.punchline + "\n");

        Console.Write(universities[0].name + "\n");
        Console.Write(universities[1].name + "\n");
        Console.Write(universities[2].name + "\n");
        //PRACTICE B
        string jsonfromhumans = GetRequest("https://randomuser.me/api/");
        string jsonfromnames = GetRequest("https://api.genderize.io/?name=vadim");
        Humans response5 = JsonSerializer.Deserialize<Humans>(jsonfromhumans);
        Names response6 = JsonSerializer.Deserialize<Names>(jsonfromnames);
        string gender = response5.results[0].gender;
        string gendername = response6.gender;
        if (gender == gendername)
        {
            Console.WriteLine("YES");
        }
        else { 
            Console.WriteLine("NO"); 
        }
        //Интересно, что это работает через раз, тип один раз ошибка, а во второй вывод. Думаю суть понятна
    }
}