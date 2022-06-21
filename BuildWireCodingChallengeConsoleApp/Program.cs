using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using ExamLibrary;

namespace BuildWireCodingChallengeConsoleApp
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {

            string articleFile = ConfigurationSettings.AppSettings["Article"].ToString();
            string wordsFile = ConfigurationSettings.AppSettings["Words"].ToString();
            string outputFile = ConfigurationSettings.AppSettings["Output"].ToString();

            Article article = Article.GetInstance();
            Words word = Words.GetInstance();

       
            var articleArr = article.Split(articleFile);
            var wordsArr = word.Split(wordsFile);

            article.Output(articleArr, outputFile);
            word.Output(wordsArr, outputFile);

            Console.ReadLine();
        }



    }
}
