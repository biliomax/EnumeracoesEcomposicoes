using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracoesEcomposicoes.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuesPerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double valuesPerHour, int hours)
        {
            Date = date;
            ValuesPerHour = valuesPerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuesPerHour;
        }
    }
}
