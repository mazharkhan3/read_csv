using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace read_csv
{
    public class ElectricCardTransactions
    {
        public string? Series_reference { get; set; }
        public double? Period { get; set; }
        public double? Data_value { get; set; }
        public char? STATUS { get; set; }
        public string? UNITS { get; set; }
        public int? Magnitude { get; set; }
        public string? Subject { get; set; }
        public string? Group { get; set; }
        public string? Series_title_1 { get; set; }
        public string? Series_title_2 { get; set; }

    }
}