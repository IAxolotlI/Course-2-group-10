using System.Text.Json;
using static PracticeABC.StoreController;

namespace PracticeA.Classes
{
    public class ClassDB
    {
        //класс DB
        public List<Product> productsDB;
        public readonly string DB_Path;
        public ClassDB() {
            DB_Path = "DataBase.json";
            productsDB = new List<Product>();
        }
        
        
        //логика чтения из файла
        private bool DB_Exist()
        {
            return System.IO.File.Exists(DB_Path);
        }
        private string ReadDB()//это приваты, так как они нужны ток здесь
        {
            return System.IO.File.ReadAllText(DB_Path);
        }
        public void Read_Data_From_DB()//это паблик, так как нам надо будет этот метод использовать в других местах, также и с логикой записи
        {
            if (DB_Exist())
            {
                var json = ReadDB();
                productsDB = JsonSerializer.Deserialize<List<Product>>(json);
            }
            else
            {
                productsDB = new List<Product>();
            }
        }
        
        
        //Логика записи в файл
        private string CurrentChanges()
        {
            return JsonSerializer.Serialize(productsDB);
        }
        public void WriteDataToFile()
        {
            System.IO.File.WriteAllText(DB_Path, CurrentChanges());
        }
    }
}
