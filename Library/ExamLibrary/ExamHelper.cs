using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamLibrary
{
    public abstract class ExamHelper
    {
        public string[] GetLetters()
        {
            var x = Enumerable.Range(65, 26).Select(p => (char)p).ToList();
            List<string> result = new List<string>();
            foreach (var first in x)
            {
                result.Add(first.ToString().ToLower());
            }

            return result.ToArray();
        }

        public  string RepeatLetter(string value, int count)
        {
            return new StringBuilder(value.Length * count).Insert(0, value, count).ToString();
        }

        public virtual void Output(List<string> data, string path)
        {
            TextWriter tw = new StreamWriter(path);
            var letters = this.GetLetters();
            int i = 0;
            int repeat = 1;
            foreach (String word in data)
            {
                if (i == 26)
                {
                    i = 0;
                    repeat++;
                }
                tw.WriteLine(RepeatLetter(letters[i],repeat) + "." + word);
                i++;
            }

            tw.Close();
        }
    }
}
