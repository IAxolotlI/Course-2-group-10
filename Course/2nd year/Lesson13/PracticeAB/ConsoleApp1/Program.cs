using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace AB;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool isVerified { get; set; }
}
public class Shop
{
    public string OrederId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> Items { get; set; }
}
public class Library
{
    public string Name { get; set; }
    public List<Book> books { get; set; }
}
public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }
}
internal class Program
{
    static void Main()
    {
        const string filePath = "D:\\course\\Course-2-group-10\\Course\\2nd year\\Lesson13\\PracticeAB\\1.json";
        const string filePath2 = "D:\\course\\Course-2-group-10\\Course\\2nd year\\Lesson13\\PracticeAB\\2.json";
        const string filePath3 = "D:\\course\\Course-2-group-10\\Course\\2nd year\\Lesson13\\PracticeAB\\3.json";
        string jsonContent = File.ReadAllText(filePath);
        string jsonContent2 = File.ReadAllText(filePath2);
        string jsonContent3 = File.ReadAllText(filePath3);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true, // Игнорировать регистр
            WriteIndented = true, // Читаемая структура JSON
        };
        Person? data = JsonSerializer.Deserialize<Person>(jsonContent, options);
        Console.WriteLine(data.Name);
        Console.WriteLine(data.Id);
        Shop? data2 = JsonSerializer.Deserialize<Shop>(jsonContent2, options);
        foreach( string item in data2.Items)
        {
            Console.WriteLine(item);
        }
        data2.Items.Add("Салфетки");
        data2.totalPrice += 1550;
        data2.totalPrice = (int) (data2.totalPrice*0.98);
        string updatedJsonContent2 = JsonSerializer.Serialize(data2, options);
        File.WriteAllText(filePath, updatedJsonContent2);
        Library? data3 = JsonSerializer.Deserialize<Library>(jsonContent3, options);
        Book kniga = new Book();
        kniga.title = "Медный Всадник";
        kniga.author = "Александр Пушкин";
        kniga.year = 1833;
        data3.books.Add(kniga);
        string updatedJsonContent3 = JsonSerializer.Serialize(data3, options);
        File.WriteAllText(filePath, updatedJsonContent3);
    }

}

