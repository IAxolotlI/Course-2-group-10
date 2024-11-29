using System.Net.Security;
using System.Text;
using System.Text.Json;
namespace Client;
class Program
{
    static bool IsAuthorized = false;
    static void Auth()
    {
        var url = "https://localhost:7268/store/auth";
        var per = new
        {
            User = "admin",
            Pass="123"
        };
        var client = new HttpClient();
        var json = JsonSerializer.Serialize(per);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = client.PostAsync(url, content).Result;
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            IsAuthorized = true;

        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            IsAuthorized = false;
        }
    }
    static void Main(string[] args)
    {
        Auth();
    }
}
