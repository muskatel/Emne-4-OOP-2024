using System.Globalization;
using CsvHelper;

namespace CSVDemo;

class Program
{
    
    static string path = "customers-100000.csv";
    static void Main(string[] args)
    {
        IEnumerable<Customer> customers = new List<Customer>();
        
        StreamReader sr = new StreamReader(path);
        
        // while (!sr.EndOfStream)
        // {
        //     string[] values = sr.ReadLine().Split(',');
        //     //Console.WriteLine(values[2] + " " + values[3]);
        //     Customer c = new Customer() { FirstName = values[2], LastName = values[3] };
        //     customers.Add(c);
        // }

        CsvReader csvReader = new CsvReader(sr, CultureInfo.InvariantCulture);
        
        customers = csvReader.GetRecords<Customer>();

        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " - " + customer.Company);
        }
    }
}