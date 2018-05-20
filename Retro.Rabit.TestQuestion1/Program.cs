using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retro.Rabit.TestQuestion1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var res = LoadData(@"c:\users\f makopo\documents\visual studio 2015\Projects\Retro.Rabit.TestQuestion1\Retro.Rabit.TestQuestion1\Files\ListOfWords.txt");
            string wordResults = string.Empty;
            var wordFound = checkWordExist(res, "ABCDE", out wordResults);
            if (wordFound == true){
                Console.WriteLine(wordResults);
            }
            else{
                Console.WriteLine("No Words Found");
            }
            Console.ReadLine();
        }

        public static string[][] LoadData(string path)
        {
            var rows = new List<string[]>();
            foreach (var line in File.ReadLines(path))
            {
                var arr = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                rows.Add(arr);
            }
            return rows.ToArray();
        }

        public static bool checkWordExist(string[][] lines, string wordToSearch, out string searchResults)
        {
            searchResults = string.Empty;
            foreach (var item in lines)
            {
                var _item = item.Where(x => x == wordToSearch);
                if (_item.Count() > 0)
                {
                    //line can contain multiple words
                    foreach (var itemWord in _item)
                    {
                        searchResults += "Word found " + itemWord + " Search Word " + wordToSearch + "\n";
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
