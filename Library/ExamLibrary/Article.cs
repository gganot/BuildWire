using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExamLibrary
{
    public class Article : ExamHelper,IParagraph
    {
        private static Article instance = null;
        public static Article GetInstance()
        {

            if (instance == null)
                instance = new Article();
            return instance;

        }
        public List<string> Split(string file)
        {
            List<string> list = new List<string>();
            string articleContent = File.ReadAllText(file);
            string[] wordsArr = articleContent.Split(' ');

            foreach (var word in wordsArr)
            {
                list.Add(word);

            }

            return list;
        }

      

    }
}
