using jieba.Analyser;
using jieba.Segmenter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace myjieba
{
    class Program
    {
        private static string GetFileContents(string fileName)
        {
            return File.ReadAllText(fileName);
        }
        static void Main(string[] args)
        {
            //var tfidf = new TfidfExtractor();
            //// Use less stopwords than default stopword list.
            //tfidf.SetStopWords(TestHelper.GetResourceFilePath("stop_words_test.txt"));
            //var text = GetFileContents(TestHelper.GetResourceFilePath("article.txt"));
            //var result = tfidf.ExtractTags(text, 30);
            //foreach (var tag in result)
            //{
            //    Console.WriteLine(tag);
            //}

            //Console.ReadLine();

            var s = "语言学家去参加了那个学术会议";
            var seg = new JiebaSegmenter();
            var words = seg.Cut(s);
            foreach (var w in words)
            {
                Console.WriteLine(w);
            }
            Console.ReadLine();
        }
    }
}
