using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using read_csv;

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
  NewLine = Environment.NewLine,
};

using (var reader = new StreamReader("./electronic-card-transactions.csv"))

using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
  var records = csv.GetRecords<ElectricCardTransactions>();

  foreach (var item in records)
  {
    Console.WriteLine(item.Series_reference + " | " + item.Period + " | " + item.Data_value + " | " + item.STATUS + " | " + item.UNITS + " | " + item.Magnitude);
  }
}


