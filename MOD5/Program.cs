namespace MOD5_1302223012
{
    internal class Program
    {
        class SimpleDataBase<T>
        {
            List<T> storedData { get; set; }
            List<DateTime> inputDates { get; set; }


            public SimpleDataBase()
            {
                storedData = new List<T>();
                inputDates = new List<DateTime>();
            }
            public void AddNewData(T list)
            {
                storedData.Add(list);
                inputDates.Add(DateTime.Now);
            }
            public void printAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " + i + " berisi : " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
                }
            }
        }



        static void Main(string[] args)
        {
            SimpleDataBase<int> Data = new SimpleDataBase<int>();
            Data.AddNewData(13); Data.AddNewData(02); Data.AddNewData(22);
            Data.printAllData();
            Console.ReadLine();
        }

    }
}