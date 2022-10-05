using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TripByBusCacl
{
    public class TextIO
    {
        public string Name { get; }
        public TextIO()
        {
            Console.WriteLine("Задайте имя файла");
            Name = Console.ReadLine();
        }
        public TextIO(string name)
        {
            Name = name;
        }

        public void WriteToFile(string _text)
        {
            var sw = new StreamWriter(this.Name, true);
            sw.WriteLine(_text);
            sw.Close();
        }
        public List<string> ReadString()
        {
            var sr = new StreamReader(this.Name);
            var _arr = new List<string>();
            string _tmp;
            while ((_tmp = sr.ReadLine()) != null)
            {
                _arr.Add(_tmp);
            }
            sr.Close();
            return _arr;
        }
    }

    public class TextAnalayser
    {
        public string firstargAndOperation { get; }
        public string numbers { get; }
        public string operation { get; }
        public string secondargAndOperation { get; }
        public TextAnalayser()
        {
            this.firstargAndOperation = @"\d+\s*(\+|\-|\*|\/)";
            this.numbers = @"\d+";
            this.operation = @"\+|\-|\*|\/";
            this.secondargAndOperation = @"(\+|\-|\*|\/)\s*\d+";
        }
        public void Search(string _input, string _pattern, out MatchCollection _matches)
        {
            var _regex = new Regex(_pattern);
            _matches = _regex.Matches(_input);
        }
    }
}
