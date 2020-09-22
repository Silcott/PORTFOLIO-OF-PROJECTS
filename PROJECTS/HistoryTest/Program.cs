using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;

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
        public static string urlName = GetURL();

        public static string GetURL()
        {
            Console.WriteLine("Welcome, I can access CSV files from online");
            Console.WriteLine("Do you have a url address to pull a CSV file from so I can generate a test? If not, no worries, I can grab one for you to use.  [Y] or [N]");
            var response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                Console.WriteLine(@"Type in the url: example: https://raw.githubusercontent.com/Silcott/PORTFOLIO-OF-PROJECTS/master/PROJECTS/HistoryTest/assets/pres.csv");
                var responseForCSVLocation = Console.ReadLine();
                return responseForCSVLocation;
            }
            else if (response == "N")
            {
                Console.WriteLine("Ok, we can use the one stored on file");
                Console.WriteLine(@"Using URL: https://raw.githubusercontent.com/Silcott/PORTFOLIO-OF-PROJECTS/master/PROJECTS/HistoryTest/assets/pres.csv");
                return "https://raw.githubusercontent.com/Silcott/PORTFOLIO-OF-PROJECTS/master/PROJECTS/HistoryTest/assets/pres.csv";
            }
            else
            {
                Console.WriteLine("That wasn't a correct choice, try again");
                GetURL();
                return null;
            }

        }
        public static string GetCSV(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }
        public static List<string> SplitCSV()
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

            string[] tempStr;
           
            try
            {
                string fileList = GetCSV(urlName);
                tempStr = fileList.Replace(@",", "").Split(new string[] { "\"" }, StringSplitOptions.RemoveEmptyEntries).ToList().Where(x => !string.IsNullOrEmpty(" ")).ToArray();

                if (Debug.debug == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                    Console.WriteLine("Printing List from Online - No Changes Have Been Made");
                    Console.WriteLine(fileList);
                    Console.WriteLine("________________________________________________________________________________________________________________");
                    Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                    Console.WriteLine(@"Printing List from Online - Inserted into string array. Replaced commas with , \"" and split on single quote then removed the line spaces");
                    foreach (var item in tempStr)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("________________________________________________________________________________________________________________");
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                //Get the number of elements in the list to loop through
                int number = tempStr.Count();
                for (int i = 0; i < number; i++)
                {
                    list1.Add(tempStr[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That wasn't a working URL, try again.");
                GetURL();
            }

            //string fileList2;
            //fileList2 = Regex.Replace(fileList, @"t|n|r", "");
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
            //Print entire list
            allProducts = allProducts.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
            //foreach (var item in allProducts)
            //{
            //    Console.WriteLine(item);
            //}
            //var newlists1 = ListExtensions.ChunkBy(allProducts, 5);
            //var newlists = ListExtensions.BatchBy(allProducts, 5);

            //Combine the list into a string with separator
            //string combindedString = string.Join(" ,", allProducts.ToArray());
            //Console.WriteLine(combindedString);

            //Console.WriteLine(allProducts.Count);

            var theList = allProducts;
            //Console.WriteLine(theList[0]);
            return theList;
        }

    }

    public static class Shorts
    {
        //This will allow me to pass a string into the method without calling the Writline method
        public static void Write(string str)
        {
            Console.Write(str);
        }
        //This will add blank spaces cutting my time and code down
        public static void AddSpace(int num)
        {
            do
            {
                Console.WriteLine();
                num--;
            } while (num > 0);

        }
        //This takes the users text they type and assigns it and return its value so i can call upon it later
        public static string ConsoleInput()
        {
            string conInput = Console.ReadLine();
            return conInput;
        }
    }
    public static class FullScreen
    {
        //Make Fullscreen
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
    public static class DivideScreen
    {
        public static int consoleWidth = Console.WindowWidth;
        public static int dividedWidth = consoleWidth / 2;
        public static string spaces = ' '.Repeat(dividedWidth);
    }
    //Class for Repeat Function - used for the text spaces and dividing the screen
    //Class was created to use the Repeat with spaces to center the text
    public static class CharExtensions
    {
        public static string Repeat(this char c, int count)
        {
            return new String(c, count);
        }
    }
    public static class ThankYouMessage
    {
        public static void ThankYouEnding()
        {
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                Have a nice day!                   "));

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + " _   _                 _                           "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| | | |               | |                          "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| |_| |__   __ _ _ __ | | ___   _  ___  _   _      "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| __| '_ \\ / _` | '_ \\| |/ / | | |/ _ \\| | | |  "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "| |_| | | | (_| | | | |   <| |_| | (_) | |_| |     "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "\\___|_| |_|\\__,_|_| |_|_|\\_\\__, |\\___/ \\__,__|"));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                            __/  |                 "));
            Console.WriteLine((DivideScreen.spaces.Remove(0, 18) + "                           |____/                  "));
        }
    }
    public static class GameStates
    {
        public static decimal correct = 0;
        public static decimal overallScoreInt = 0;

        public static void IntroScreen()
        {
            Console.WriteLine("Hello and Welcome to the History Testing System");

            Console.WriteLine("Ok, lets begin, how many questions do you want? Select [1] thru [13]");
            int responseNum = Convert.ToInt32(Console.ReadLine()) - 1;
            MakeTest();

            //Selects a random number from counting the total number of questions and 
            //answers in the CSV file divdie by 5 to get the number of questions ONLY
            //Then make a random list of numbers from that range
            int[] ReturnQuestionListNumber()
            {
                if (responseNum >= 0 && responseNum <= 12)
                {
                    //Random Array to generate number 1 thru 12 to use on index of answer selection lists
                    int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                    Random randNum = new Random();
                    int rand = 0;
                    int temp;
                    for (int x = 0; x < 12; x++)
                    {
                        rand = randNum.Next(0, 12 - x);
                        temp = array[rand];
                        array[rand] = array[11 - x];
                        array[11 - x] = temp;
                    }


                    return array;
                }
                else
                {
                    Console.WriteLine("Not a correct number to choose, let's start over again...");
                    IntroScreen();
                    return null;
                }

            }

            void MakeTest()
            {
                Console.WriteLine($"You Selected {responseNum + 1} number of questions");
                Console.WriteLine("Stand-by - compiling test questions now...");
                Console.WriteLine();

                if (Debug.debug == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    //DEBUG - Use to see Random Number list generated 0 thru 12 for Questions
                    Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                    Console.WriteLine("Printing Random Number List of the amount of questions you selected");
                    foreach (var item in ReturnQuestionListNumber())
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("________________________________________________________________________________________________________________");

                    Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                    Console.WriteLine("Printing the Scrapped List off website after the splitting and removing of commas");
                    //DEGUG - Use to see the scrapped list
                    foreach (var item in ListScraper.SplitCSV())
                    {
                        Console.WriteLine(item);

                    }
                    Console.WriteLine("________________________________________________________________________________________________________________");
                    Console.ForegroundColor = ConsoleColor.Green;

                }


                //Stats
                decimal incorrectAnswers = 0;

                //Create Dictionary to store questions and separate them from teh answers - Keys = questions and Values (assigned to properties) = Answers 1 thru 4
                Dictionary<string, DictionaryAnswersProp> questionsDictionary = new Dictionary<string, DictionaryAnswersProp>();
                for (int i = 0; i < responseNum + 1; i++)
                {
                    int number = ReturnQuestionListNumber()[i];
                    int newNumber = number * 5;
                    questionsDictionary.Add(ListScraper.SplitCSV()[newNumber], new DictionaryAnswersProp
                    {
                        answer1 = ListScraper.SplitCSV()[newNumber + 1],
                        answer2 = ListScraper.SplitCSV()[newNumber + 2],
                        answer3 = ListScraper.SplitCSV()[newNumber + 3],
                        answer4 = ListScraper.SplitCSV()[newNumber + 4]
                    });
                    Console.WriteLine($"Question Number: {i + 1}");

                    //Assign Answers to list to pull them out by index calling
                    var listNum = questionsDictionary.Values.ToArray();
                    ArrayList add_array = new ArrayList();
                    foreach (var item in listNum)
                    {
                        add_array.Add(item.answer1);
                        add_array.Add(item.answer2);
                        add_array.Add(item.answer3);
                        add_array.Add(item.answer4);
                        if (Debug.debug == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;

                            Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                            //DEBUG - Use to see the list of answers without randomizing
                            Console.WriteLine("Printing the Answer List in the order from original");
                            Console.WriteLine(add_array[0]); //CORRECT ANSWER IS THIS
                            Console.WriteLine(add_array[1]);
                            Console.WriteLine(add_array[2]);
                            Console.WriteLine(add_array[3]);
                            Console.WriteLine("________________________________________________________________________________________________________________");
                            Console.ForegroundColor = ConsoleColor.Green;

                        }

                    }

                    //Random Array to generate number 1 thru 4 to use on index of answer selection lists
                    int[] array = { 1, 2, 3, 4 };
                    Random randNum = new Random();
                    int rand = 0;
                    int temp;
                    for (int x = 0; x < 4; x++)
                    {
                        rand = randNum.Next(1, 4 - x);
                        temp = array[rand];
                        array[rand] = array[3 - x];
                        array[3 - x] = temp;
                    }
                    //Create random number 0 to 4 for answer index
                    int answer1random = array[0] - 1;
                    int answer2random = array[1] - 1;
                    int answer3random = array[2] - 1;
                    int answer4random = array[3] - 1;

                    if (Debug.debug == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                        Console.WriteLine("Printing the Random List of Numbers to use with the Answers Idexes");
                        ////DEBUG - Use to see Random Number list generated 1 thru 4 for Answers
                        foreach (var item in array)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("________________________________________________________________________________________________________________");
                        Console.ForegroundColor = ConsoleColor.Green;

                    }


                    foreach (KeyValuePair<string, DictionaryAnswersProp> item in questionsDictionary)
                    {
                        Console.WriteLine(item.Key);
                        if (Debug.debug == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("____________________________________________________DEBUGGER____________________________________________________");
                            Console.WriteLine("Answers in the correct order on CSV");
                            Console.WriteLine("[1]" + item.Value.answer1 + " Correct Answer");
                            Console.WriteLine("[2]" + item.Value.answer2);
                            Console.WriteLine("[3]" + item.Value.answer3);
                            Console.WriteLine("[4]" + item.Value.answer4);
                        Console.WriteLine("________________________________________________________________________________________________________________");
                            Console.ForegroundColor = ConsoleColor.Green;
                        }

                    }

                    Console.WriteLine("Answers");
                    Console.WriteLine("[1]" + add_array[answer1random]);
                    Console.WriteLine("[2]" + add_array[answer2random]);
                    Console.WriteLine("[3]" + add_array[answer3random]);
                    Console.WriteLine("[4]" + add_array[answer4random]);
                    Console.WriteLine();
                    Console.WriteLine("Select an Answer [1] thru [4]");

                    int correctAnswer = 0;
                    int responseToQuestion = Convert.ToInt32(Console.ReadLine());
                    if (add_array[0] == add_array[answer1random])
                    {
                        correctAnswer = 1;
                    }
                    if (add_array[0] == add_array[answer2random])
                    {
                        correctAnswer = 2;
                    }
                    if (add_array[0] == add_array[answer3random])
                    {
                        correctAnswer = 3;
                    }
                    if (add_array[0] == add_array[answer4random])
                    {
                        correctAnswer = 4;
                    }


                    if (responseToQuestion == correctAnswer)
                    {
                        Console.WriteLine("Correct, good job!");
                        Console.WriteLine();
                        correct = correct + 1;
                    }
                    else if (responseToQuestion != correctAnswer)
                    {
                        Console.WriteLine("Sorry, that's incorrect");
                        Console.WriteLine();
                        incorrectAnswers = incorrectAnswers + 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not sure I understand, try again?");
                        MakeTest();
                    }
                    questionsDictionary.Clear();
                }
                if (correct > incorrectAnswers)
                {
                    Console.WriteLine($"Congrats, you got {correct} questions correct!");
                }
                else if (incorrectAnswers > correct)
                {
                    Console.WriteLine($"Sorry, you might need some more practice, you got {correct} questions correct");
                }
                Console.WriteLine("");


                try
                {
                    overallScoreInt = ((correct / (correct + incorrectAnswers))) * 100;
                    string grade = "A";

                    if (overallScoreInt <= 100 && overallScoreInt > 89)
                    {
                        grade = "A";
                    }
                    else if (overallScoreInt < 90 && overallScoreInt > 79)
                    {
                        grade = "B";
                    }
                    else if (overallScoreInt < 80 && overallScoreInt > 69)
                    {
                        grade = "C";
                    }
                    else if (overallScoreInt < 70 && overallScoreInt > 59)
                    {
                        grade = "D";

                    }
                    else if (overallScoreInt <= 59)
                    {
                        grade = "F";
                    }
                    else
                    {
                        grade = "F";
                    }
                    string overallScoreStr = overallScoreInt.ToString("00");
                    Console.WriteLine($"That's a score of {correct} out of {correct + incorrectAnswers} = {overallScoreStr}%");
                    Console.WriteLine($"That's a {grade} letter grade");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Sorry, That's strange...");
                }

            }
            GameStates.TryAgain();
        }
        public static void TryAgain()
        {
            Console.WriteLine("Would you like to play again?");
            var response = Console.ReadLine().ToUpper();

            if (response == "Y")
            {
                ListScraper.SplitCSV();
                Console.Clear();
                GameStates.IntroScreen();
            }
            else if (response == "N")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                TryAgain();
            }
        }
    }
    public class DictionaryAnswersProp
    {
        public string question { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
    }
    public class Program
    {
        public static bool exit = true;
        static void Main(string[] args)
        {
            FullScreen.WideScreenMethod();
            MyName.Greet();
            Console.WriteLine("");
            ListScraper.SplitCSV();
            Console.ForegroundColor = ConsoleColor.Green;
            GameStates.IntroScreen();
            ThankYouMessage.ThankYouEnding();
        }
    }
    public class Debug
    {
        public static bool debug = Debugger();
        public static bool Debugger()
        {
            Console.WriteLine("Turn on debugger? [Y] or [N]");
            var response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                return true;
            }
            else if (response == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand you, try again...");
                Debugger();
                return false;
            }
        }
    }
    public class MyName
    {
        public static void Greet()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
           8 8888       .8.                   ,8.       ,8.          8 8888888888     d888888o.                                                                                
           8 8888      .888.                 ,888.     ,888.         8 8888         .`8888:' `88.                                                                              
           8 8888     :88888.               .`8888.   .`8888.        8 8888         8.`8888.   Y8                                                                              
           8 8888    . `88888.             ,8.`8888. ,8.`8888.       8 8888         `8.`8888.                                                                                  
           8 8888   .8. `88888.           ,8'8.`8888,8^8.`8888.      8 888888888888  `8.`8888.                                                                                 
           8 8888  .8`8. `88888.         ,8' `8.`8888' `8.`8888.     8 8888           `8.`8888.                                                                                
88.        8 8888 .8' `8. `88888.       ,8'   `8.`88'   `8.`8888.    8 8888            `8.`8888.                                                                               
`88.       8 888'.8'   `8. `88888.     ,8'     `8.`'     `8.`8888.   8 8888        8b   `8.`8888.                                                                              
  `88o.    8 88'.888888888. `88888.   ,8'       `8        `8.`8888.  8 8888        `8b.  ;8.`8888                                                                              
    `Y888888 ' .8'       `8. `88888. ,8'         `         `8.`8888. 8 888888888888 `Y8888P ,88P'                                                                              
                                                                                                                                                                               
   d888888o.    8 8888 8 8888         ,o888888o.        ,o888888o. 8888888 8888888888 8888888 8888888888 d888888o.                                                             
 .`8888:' `88.  8 8888 8 8888        8888     `88.   . 8888     `88.     8 8888             8 8888     .`8888:' `88.                                                           
 8.`8888.   Y8  8 8888 8 8888     ,8 8888       `8. ,8 8888       `8b    8 8888             8 8888     8.`8888.   Y8                                                           
 `8.`8888.      8 8888 8 8888     88 8888           88 8888        `8b   8 8888             8 8888     `8.`8888.                                                               
  `8.`8888.     8 8888 8 8888     88 8888           88 8888         88   8 8888             8 8888      `8.`8888.                                                              
   `8.`8888.    8 8888 8 8888     88 8888           88 8888         88   8 8888             8 8888       `8.`8888.                                                             
    `8.`8888.   8 8888 8 8888     88 8888           88 8888        ,8P   8 8888             8 8888        `8.`8888.                                                            
8b   `8.`8888.  8 8888 8 8888     `8 8888       .8' `8 8888       ,8P    8 8888             8 8888    8b   `8.`8888.                                                           
`8b.  ;8.`8888  8 8888 8 8888        8888     ,88'   ` 8888     ,88'     8 8888             8 8888    `8b.  ;8.`8888                                                           
 `Y8888P ,88P'  8 8888 8 888888888888 `8888888P'        `8888888P'       8 8888             8 8888     `Y8888P ,88P'                                                           
                                                                                                                                                                               
8888888 8888888888 8 8888888888     d888888o. 8888888 8888888888               ,o888888o.    8 8888888888   b.             8 8888888 8888888888 8 8888888888   8 888888888o.   
      8 8888       8 8888         .`8888:' `88.     8 8888                    8888     `88.  8 8888         888o.          8       8 8888       8 8888         8 8888    `88.  
      8 8888       8 8888         8.`8888.   Y8     8 8888                 ,8 8888       `8. 8 8888         Y88888o.       8       8 8888       8 8888         8 8888     `88  
      8 8888       8 8888         `8.`8888.         8 8888                 88 8888           8 8888         .`Y888888o.    8       8 8888       8 8888         8 8888     ,88  
      8 8888       8 888888888888  `8.`8888.        8 8888                 88 8888           8 888888888888 8o. `Y888888o. 8       8 8888       8 888888888888 8 8888.   ,88'  
      8 8888       8 8888           `8.`8888.       8 8888                 88 8888           8 8888         8`Y8o. `Y88888o8       8 8888       8 8888         8 888888888P'   
      8 8888       8 8888            `8.`8888.      8 8888                 88 8888           8 8888         8   `Y8o. `Y8888       8 8888       8 8888         8 8888`8b       
      8 8888       8 8888        8b   `8.`8888.     8 8888                 `8 8888       .8' 8 8888         8      `Y8o. `Y8       8 8888       8 8888         8 8888 `8b.     
      8 8888       8 8888        `8b.  ;8.`8888     8 8888                    8888     ,88'  8 8888         8         `Y8o.`       8 8888       8 8888         8 8888   `8b.   
      8 8888       8 888888888888 `Y8888P ,88P'     8 8888                     `8888888P'    8 888888888888 8            `Yo       8 8888       8 888888888888 8 8888     `88. 


");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}