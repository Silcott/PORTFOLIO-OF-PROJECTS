﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace HistoryTest
{
    public static class ListExtensions
    {
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        public static IEnumerable<List<T>> BatchBy<T>(this IEnumerable<T> enumerable, int batchSize)
        {
            using (var enumerator = enumerable.GetEnumerator())
            {
                List<T> list = null;
                while (enumerator.MoveNext())
                {
                    if (list == null)
                    {
                        list = new List<T> { enumerator.Current };
                    }
                    else if (list.Count < batchSize)
                    {
                        list.Add(enumerator.Current);
                    }
                    else
                    {
                        yield return list;
                        list = new List<T> { enumerator.Current };
                    }
                }

                if (list?.Count > 0)
                {
                    yield return list;
                }
            }
        }
    }
    public static class FullScreen
    {
        //this is for the fullscreen mode
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;

        //This will set the console window to full screen
        public static void WideScreenMethod()
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
        }
    }
    public static class PrintList
    {
        public static void WriteToConsole<T>(this IList<T> collection)
        {
            WriteToConsole<T>(collection, "\t");
        }

        public static void WriteToConsole<T>(this IList<T> collection, string delimiter)
        {
            collection.FastForEach(item => Console.Write("{0}{1}", item.ToString(), delimiter));
        }

        public static void FastForEach<T>(this IList<T> collection, Action<T> actionToPerform)
        {
            int count = collection.Count();
            for (int i = 0; i < count; ++i)
            {
                actionToPerform(collection[i]);
            }
            Console.WriteLine();
        }
    }
    public class CsvParser
    {
        private readonly List<List<string>> entries = new List<List<string>>();
        private string currentEntry = "";
        private bool insideQuotation;

        /// <summary>
        ///   Returns all scanned entries.
        ///   Outer IEnumerable = rows,
        ///   inner IEnumerable = columns of the corresponding row.
        /// </summary>
        public IEnumerable<IEnumerable<string>> Entries
        {
            get { return entries; }
        }

        public void ScanNextLine(string line)
        {
            // At the beginning of the line
            if (!insideQuotation)
            {
                entries.Add(new List<string>());
            }
            // The characters of the line
            foreach (char c in line)
            {
                if (insideQuotation)
                {
                    if (c == '"')
                    {
                        insideQuotation = false;
                    }
                    else
                    {
                        currentEntry += c;
                    }
                }
                else if (c == ',')
                {
                    entries[entries.Count - 1].Add(currentEntry);
                    currentEntry = "";
                }
                else if (c == '"')
                {
                    insideQuotation = true;
                }
                else
                {
                    currentEntry += c;
                }
            }
            // At the end of the line
            if (!insideQuotation)
            {
                entries[entries.Count - 1].Add(currentEntry);
                currentEntry = "";
            }
            else
            {
                currentEntry += "\n";
            }
        }
    }
    public static class ListScraper
    {

        public static string GetCSV(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }
        public static void SplitCSV()
        {
            List<string> splitted = new List<string>();
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            List<string> list7 = new List<string>();
            List<string> list8 = new List<string>();
            List<string> list9 = new List<string>();
            List<string> list10 = new List<string>();
            List<string> list11 = new List<string>();
            List<string> list12 = new List<string>();
            List<string> list13 = new List<string>();
            List<string> list14 = new List<string>();
            List<string> list15 = new List<string>();
            List<string> list16 = new List<string>();
            List<string> list17 = new List<string>();
            List<string> list18 = new List<string>();
            List<string> list19 = new List<string>();
            List<string> list20 = new List<string>();
            List<string> list21 = new List<string>();
            List<string> list22 = new List<string>();
            List<string> list23 = new List<string>();
            List<string> list24 = new List<string>();
            List<string> list25 = new List<string>();
            List<string> list26 = new List<string>();
            List<string> list27 = new List<string>();
            List<string> list28 = new List<string>();
            List<string> list29 = new List<string>();
            List<string> list30 = new List<string>();
            List<string> list31 = new List<string>();
            List<string> list32 = new List<string>();
            List<string> list33 = new List<string>();
            List<string> list34 = new List<string>();
            List<string> list35 = new List<string>();
            List<string> list36 = new List<string>();
            List<string> list37 = new List<string>();
            List<string> list38 = new List<string>();
            List<string> list39 = new List<string>();
            List<string> list40 = new List<string>();
            List<string> list41 = new List<string>();
            List<string> list42 = new List<string>();
            List<string> list43 = new List<string>();
            List<string> list44 = new List<string>();
            List<string> list45 = new List<string>();
            List<string> list46 = new List<string>();
            List<string> list47 = new List<string>();
            List<string> list48 = new List<string>();
            List<string> list49 = new List<string>();
            List<string> list50 = new List<string>();
            List<string> list51 = new List<string>();
            List<string> list52 = new List<string>();
            List<string> list53 = new List<string>();
            List<string> list54 = new List<string>();
            List<string> list55 = new List<string>();
            List<string> list56 = new List<string>();
            List<string> list57 = new List<string>();
            List<string> list58 = new List<string>();
            List<string> list59 = new List<string>();
            List<string> list60 = new List<string>();
            List<string> list61 = new List<string>();
            List<string> list62 = new List<string>();
            List<string> list63 = new List<string>();
            List<string> list64 = new List<string>();
            List<string> list65 = new List<string>();
            List<string> list66 = new List<string>();
            List<string> list67 = new List<string>();
            List<string> list68 = new List<string>();
            List<string> list69 = new List<string>();
            List<string> list70 = new List<string>();
            List<string> list71 = new List<string>();
            List<string> list72 = new List<string>();
            List<string> list73 = new List<string>();
            List<string> list74 = new List<string>();
            List<string> list75 = new List<string>();
            List<string> list76 = new List<string>();
            List<string> list77 = new List<string>();
            List<string> list78 = new List<string>();
            List<string> list79 = new List<string>();
            List<string> list80 = new List<string>();
            List<string> list81 = new List<string>();
            List<string> list82 = new List<string>();
            List<string> list83 = new List<string>();
            List<string> list84 = new List<string>();
            List<string> list85 = new List<string>();
            List<string> list86 = new List<string>();
            List<string> list87 = new List<string>();
            List<string> list88 = new List<string>();
            List<string> list89 = new List<string>();
            List<string> list90 = new List<string>();
            List<string> list91 = new List<string>();
            List<string> list92 = new List<string>();
            List<string> list93 = new List<string>();
            List<string> list94 = new List<string>();
            List<string> list95 = new List<string>();
            List<string> list96 = new List<string>();
            List<string> list97 = new List<string>();
            List<string> list98 = new List<string>();
            List<string> list99 = new List<string>();
            List<string> list100 = new List<string>();

            string fileList = GetCSV("https://raw.githubusercontent.com/Silcott/PORTFOLIO-OF-PROJECTS/master/PROJECTS/HistoryTest/assets/pres.csv");
            string[] tempStr;
            ;
            //string fileList2;
            //fileList2 = Regex.Replace(fileList, @"t|n|r", "");
            tempStr = fileList.Replace(@",", "").Split(new string[] { "\"" }, StringSplitOptions.RemoveEmptyEntries).ToList().Where(x => !string.IsNullOrEmpty(" ")).ToArray();

            //Get the number of elements in teh list to loop through
            int number = tempStr.Count();
            for (int i = 0; i < number; i++)
            {
                list1.Add(tempStr[i]);
            }
            var allProducts = list1;

            allProducts = list1
                            .Concat(list2)
                            .Concat(list3)
                            .Concat(list4)
                            .Concat(list5)
                            .Concat(list6)
                            .Concat(list7)
                            .Concat(list8)
                            .Concat(list9)
                            .Concat(list10)
                            .Concat(list11)
                            .Concat(list12)
                            .Concat(list13)
                            .Concat(list14)
                            .Concat(list15)
                            .Concat(list16)
                            .Concat(list17)
                            .Concat(list18)
                            .Concat(list19)
                            .Concat(list20)
                            .Concat(list21)
                            .Concat(list22)
                            .Concat(list23)
                            .Concat(list24)
                            .Concat(list25)
                            .Concat(list26)
                            .Concat(list27)
                            .Concat(list28)
                            .Concat(list29)
                            .Concat(list30)
                            .Concat(list31)
                            .Concat(list32)
                            .Concat(list33)
                            .Concat(list34)
                            .Concat(list35)
                            .Concat(list36)
                            .Concat(list37)
                            .Concat(list38)
                            .Concat(list39)
                            .Concat(list40)
                            .Concat(list41)
                            .Concat(list42)
                            .Concat(list43)
                            .Concat(list44)
                            .Concat(list45)
                            .Concat(list46)
                            .Concat(list47)
                            .Concat(list48)
                            .Concat(list49)
                            .Concat(list50)
                            .Concat(list51)
                            .Concat(list52)
                            .Concat(list53)
                            .Concat(list54)
                            .Concat(list55)
                            .Concat(list56)
                            .Concat(list57)
                            .Concat(list58)
                            .Concat(list59)
                            .Concat(list60)
                            .Concat(list61)
                            .Concat(list62)
                            .Concat(list63)
                            .Concat(list64)
                            .Concat(list65)
                            .Concat(list66)
                            .Concat(list67)
                            .Concat(list68)
                            .Concat(list69)
                            .Concat(list70)
                            .Concat(list71)
                            .Concat(list72)
                            .Concat(list73)
                            .Concat(list74)
                            .Concat(list75)
                            .Concat(list76)
                            .Concat(list77)
                            .Concat(list78)
                            .Concat(list79)
                            .Concat(list80)
                            .Concat(list81)
                            .Concat(list82)
                            .Concat(list83)
                            .Concat(list84)
                            .Concat(list85)
                            .Concat(list86)
                            .Concat(list87)
                            .Concat(list88)
                            .Concat(list89)
                            .Concat(list90)
                            .Concat(list91)
                            .Concat(list92)
                            .Concat(list93)
                            .Concat(list94)
                            .Concat(list95)
                            .Concat(list96)
                            .Concat(list97)
                            .Concat(list98)
                            .Concat(list99)
                            .Concat(list100)
                            .ToList();

            Console.WriteLine();
            //list1.WriteToConsole();

            //Before Removing
            //allProducts.WriteToConsole();

            //Print entire list
            allProducts = allProducts.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            //allProducts.WriteToConsole();


            foreach (var item in allProducts)
            {
                Console.WriteLine(item);
            }
            //var newlists1 = ListExtensions.ChunkBy(allProducts, 5);
            //var newlists = ListExtensions.BatchBy(allProducts, 5);

            //Combine the list into a string with separator
            //string combindedString = string.Join(" ,", allProducts.ToArray());
            //Console.WriteLine(combindedString);

            Console.WriteLine(allProducts.Count);

         var theList = allProducts;
            Console.WriteLine(theList[0]);
        }

}
    class Program
    {
        public static void MakeTest()
        {

        }

        public static void GiveTest()
        {

        }


        static void Main(string[] args)
        {
            FullScreen.WideScreenMethod();
            ListScraper.SplitCSV();
            

        }
    }
}
