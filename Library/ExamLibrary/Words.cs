using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExamLibrary
{
    public class Words : ExamHelper, IParagraph
    {
        private static Words instance = null;
        public static Words GetInstance()
        {

            if (instance == null)
                instance = new Words();
            return instance;

        }
        public List<string> Split(string file)
        {
            List<string> list = new List<string>();
            string content = File.ReadAllText(file);
          
            content.Split('\n').ToList().ForEach(word =>
            {
                list.Add(word.Replace("\n", "").Replace("\r", ""));
            });

         
            return list;
        }

     

    }
    
}
