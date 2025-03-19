
namespace modul5_103022300154
{
    class Program
    {
        public static void Main()
        {
            SimpleDatabase<double> db = new SimpleDatabase<double>();
            db.AddNewData(10.1);
            db.AddNewData(30.2);
            db.AddNewData(22.3);

            db.PrintAllData();
        }
    }
    class SimpleDatabase<T>
    {
        List<T> StoredData;
        List<DateTime> inputDates;
        public SimpleDatabase()
        {
            this.StoredData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.StoredData.Add(data);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            int i = 1;
            foreach (var item in StoredData)
            {
                Console.WriteLine($"Data {i} berisi {item} pada waktu {inputDates[i - 1]}");
                i++;
            }
        }
    }
}