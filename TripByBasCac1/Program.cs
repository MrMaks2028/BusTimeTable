using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TripByBusCacl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TimeTable = new TextIO("Bus.txt");
            var _timeTable = new List<string>();
            _timeTable = TimeTable.ReadString();
            //var regex = new Regex(@"\d{2}:\d{2}");
            //MatchCollection _match;
            var _text = new TextAnalayser();
            MatchCollection tmp;
            string _pattern = @"Химмаш\s*\d{2}:\d{2}", _pattern002 = @"\d{2}:\d{2}";
            foreach (var item in _timeTable)
            {
                //if(item.Contains("Химмаш"))
                //Console.WriteLine(regex.Matches(item)[0].Value.ToString());
                _text.Search(item, _pattern, out tmp);
                _text.Search(tmp[0].ToString(), _pattern002, out tmp);
                |Console.WriteLine(tmp[0]);
            }
            Console.ReadKey();
        }
    }
}
