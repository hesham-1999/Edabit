using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Edabit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TestCases
            //Console.WriteLine( CircuitPower(230, 10));
            //Console.WriteLine( ReverseAndNot(123));
            //Console.WriteLine(Interview(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130));
            //Console.WriteLine(Uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
            //Console.WriteLine(Uncensor("abcd", ""));
            //Console.WriteLine(Uncensor("*PP*RC*S*", "UEAE"));
            //Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));
            //Console.WriteLine(IsSmooth("Someone is outside the doorway"));
            //Console.WriteLine(IsSmooth("She eats super righteously"));
            //Console.WriteLine(IsValidHexCode("#CD5C5C"));
            //Console.WriteLine(IsValidHexCode("#EAECEE"));
            //Console.WriteLine(IsValidHexCode("#eaecee"));
            //Console.WriteLine(IsValidHexCode("#CD5C58C"));
            //Console.WriteLine(IsValidHexCode("#CD5C5Z"));
            //Console.WriteLine(IsValidHexCode("#CD5C&C"));
            //Console.WriteLine(IsValidHexCode("#CD5C5C"));
            //Console.WriteLine(CupSwapping(["AB", "CA"]));
            //Console.WriteLine(CupSwapping(["AC", "CA", "CA", "AC"]));
            //Console.WriteLine(CupSwapping(["BA", "AC", "CA", "BC"]));
            //  Console.WriteLine("beautiful".Contains("at"));
            //Console.WriteLine(CanFind(new string[] { "at", "be", "th", "au" }, new string[] { "beautiful", "the", "hat" }));
            //Console.WriteLine(CanFind(new string[] { "th", "fo", "ma", "or" }, new string[] { "the", "many", "for", "forest" }));
            //Console.WriteLine(CanFind(new string[] { "oo", "mi", "ki", "la" }, new string[] { "milk", "chocolate", "cooks" }));     


            //Console.WriteLine(WeekAfter("12/03/2020"));
            //Console.WriteLine(WeekAfter("21/12/1989"));
            //Console.WriteLine(WeekAfter("01/01/2000"));

            //Console.WriteLine(Brackets("(a*(b-c)..... )"));
            //Console.WriteLine(Brackets(")(a-b-45/7*(a-34))"));
            //Console.WriteLine(Brackets("sin(90...)+.............cos1)"));

            //Console.WriteLine(ReverseOdd("Bananas"));
            //Console.WriteLine(ReverseOdd("One two three four"));
            //Console.WriteLine(reversedBinaryInteger(10));
            //Console.WriteLine(reversedBinaryInteger(12));
            //Console.WriteLine(reversedBinaryInteger(25));
            //Console.WriteLine(reversedBinaryInteger(45));

            //Console.WriteLine(Fibonacci(10));
            //Console.WriteLine(Fibonacci(20));
            //Console.WriteLine(Fibonacci(30));
            //Console.WriteLine(Fibonacci(40));
            //Console.WriteLine(Fibonacci(50));
            //Console.WriteLine(Fibonacci(60));
            //Console.WriteLine(ToCamelCase("hello_edabit"));
            //Console.WriteLine(ToCamelCase("is_modal_open"));
            // Console.WriteLine(16.0/ "What a gorgeous day.".Length );


            //Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero one"));
            //Console.WriteLine(TextToNumberBinary("Zero one zero ONE zero one zero one"));
            //Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero one one two"));
            //Console.WriteLine(TextToNumberBinary("zero one zero one zero one zero three"));
            //Console.WriteLine(TextToNumberBinary("one one"));

            //var postion1 = TrackRobot(new int[] { 20, 30, 10, 40 }); 
            //Console.WriteLine($"Rebot Postion is ({postion1[0]} , {postion1[1]})");

            //var postion2 = TrackRobot(new int[] { });
            //Console.WriteLine($"Rebot Postion is ({postion2[0]} , {postion2[1]})");

            //var postion3 = TrackRobot(new int[] { -10, 20, 10 });
            //Console.WriteLine($"Rebot Postion is ({postion3[0]} , {postion3[1]})");
            //Console.WriteLine(IsStrangePair("ratio", "orator"));
            //Console.WriteLine(IsStrangePair("sparkling", "groups"));
            //Console.WriteLine(IsStrangePair("bush", "hubris"));
            //Console.WriteLine(IsStrangePair("", ""));

            //Console.WriteLine(gcd(32, 8));
            //Console.WriteLine(gcd(8, 12));
            //Console.WriteLine(gcd(17, 13));

            //Console.WriteLine(ValidateEmail("@gmail.com"));
            //Console.WriteLine(ValidateEmail("hello.gmail@com"));
            //Console.WriteLine(ValidateEmail("gmail"));
            //Console.WriteLine(ValidateEmail("hello@gmail"));
            //Console.WriteLine(ValidateEmail("hello@edabit.com"));
            //Console.WriteLine(IsSymmetrical(7227));
            //Console.WriteLine(IsSymmetrical(12567));
            //Console.WriteLine(IsSymmetrical(44444444));
            //Console.WriteLine(IsSymmetrical(9939));
            //Console.WriteLine(IsSymmetrical(1112111));


            //Console.WriteLine(Bomb("There is a bomb."));
            //Console.WriteLine(Bomb("Hey, did you think there is a bomb?"));
            //Console.WriteLine(Bomb("This goes boom!!!"));

            //Console.WriteLine(count_all("Hello World"));
            //Console.WriteLine(count_all("H3ll0 Wor1d"));
            //Console.WriteLine(count_all("149990"));

            //Console.WriteLine(CheckPerfect(6));
            //Console.WriteLine(CheckPerfect(28));
            //Console.WriteLine(CheckPerfect(496));
            //Console.WriteLine(CheckPerfect(12));
            //Console.WriteLine(CheckPerfect(97));

            //Console.WriteLine(square_areas_difference(5));
            //Console.WriteLine(square_areas_difference(6));
            //Console.WriteLine(square_areas_difference(7));


            //Console.WriteLine(ValidatePIN("1234"));
            //Console.WriteLine(ValidatePIN("12345"));
            //Console.WriteLine(ValidatePIN("a234"));
            //Console.WriteLine(ValidatePIN(""));

            //Console.WriteLine(Accum("abcd"));
            //Console.WriteLine(Accum("RqaEzty"));
            //Console.WriteLine(Accum("cwAt"));
            //foreach (string item in Arrow(4))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (string item in Arrow(3))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(Simplify("4/6"));
            //Console.WriteLine(Simplify("10/11"));
            //Console.WriteLine(Simplify("100/400"));
            //Console.WriteLine(Simplify("8/4"));
            //Console.WriteLine(License("Eric", 2, "Adam Caroline Rebecca Frank"));
            //Console.WriteLine(License("Zebediah", 1, "Bob Jim Becky Pat"));
            //Console.WriteLine(License("Aaron", 3, "Jane Max Olivia Sam"));

            //Console.WriteLine(ValidatePassword("P1zz@"));
            //Console.WriteLine(ValidatePassword("iLoveYou"));
            //Console.WriteLine(ValidatePassword("Fhg93@"));


            //foreach(var item in   FindLargest([[4, 2, 7, 1], [20, 70, 40, 90], [1, 2, 0]]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in FindLargest([[-34, -54, -74], [-32, -2, -65], [-54, 7, -43]]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in FindLargest([[0.4321, 0.7634, 0.652], [1.324, 9.32, 2.5423, 6.4314], [9, 3, 6, 3]]))
            //{
            //    Console.WriteLine(item);
            //}


            //foreach (var item in CountPosSumNeg([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in CountPosSumNeg([92, 6, 73, -77, 81, -90, 99, 8, -85, 34]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in CountPosSumNeg([91, -4, 80, -73, -28]))
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item in FilterArray([1, 2, "a", "b"]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in FilterArray([1, "a", "b", 0, 15]))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------------------------------");
            //foreach (var item in FilterArray([1, 2, "aasf", "1", "123", 123,1]))
            //{
            //    Console.WriteLine(item);
            //}

            //GetFrame(4, 5, '#');
            //Console.WriteLine("---------------");
            //GetFrame(10, 3, '*');
            //Console.WriteLine("--------------------------------");
            //GetFrame(2, 5, '0');
            #endregion
            #region ReverseCoding
            /*
             This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. 
            Here, you must generate your own function to satisfy the relationship between the inputs and outputs.

               Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

                Examples
                    "A4B5C2" ➞ "AAAABBBBBCC"
                    "C2F1E5" ➞ "CCFEEEEE"
                    "T4S2V2" ➞ "TTTTSSVV"
                    "A1B2C3D4" ➞ "ABBCCCDDDD"
             */
            //Console.WriteLine(ReverseCoding01("A4B5C2"));
            //Console.WriteLine(ReverseCoding01("C2F1E5"));
            //Console.WriteLine(ReverseCoding01("T4S2V2"));
            //Console.WriteLine(ReverseCoding01("A1B2C3D4"));


            /*
             This is a reverse coding challenge.
            Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.

                Examples
                3 ➞ 21
                9 ➞ 2221
                17 ➞ 22221
                24 ➞ 22228 
                Console.WriteLine(ReverseCoding02(3));
            Console.WriteLine(ReverseCoding02(9));
            Console.WriteLine(ReverseCoding02(17));
            Console.WriteLine(ReverseCoding02(24));
             */
       

            /* 
              This is a reverse coding challenge. Normally you're given explicit directions with how to create a function. 
            Here, you must generate your own function to satisfy the relationship between the inputs and outputs.
        Your task is to create a function that, when fed the inputs below, produces the sample outputs shown.

                Examples
                MysteryFunc(152) ➞ 10

                MysteryFunc(832) ➞ 48

                MysteryFunc(19) ➞ 9

                MysteryFunc(133) ➞ 9
            Console.WriteLine(ReverseCoding03(152));
            Console.WriteLine(ReverseCoding03(832));
            Console.WriteLine(ReverseCoding03(19));
            Console.WriteLine(ReverseCoding03(9));
             */
            #endregion

        }
        public static double[] FindMinMax(double[] values)
        {
            double[] result = new double[2];
            result[0] = values.Min();
            result[1] = values.Max();
            return result;
        }
        public static int CircuitPower(int voltage, int current)
        {
            return voltage * current;
        }
        public static string GiveMeSomething(string a)
        {
            return "something " + a;
        }
        public static double[] GetMinAndMax(double[] a)
        {
            var result = new double[2];
            result[0] = a.Min();
            result[1] = a.Max();
            return result;
        }
        public static string NameShuffle(string str)
        {
            var names  = str.Split(" ");
            string temp = names[0];
            string firstName = names[1];
            string lastName = temp;

            return firstName + lastName;
        }
        public static string MonthName(int num)
        {
            string[] MonthName = 
                { "January", "February" , "March" ,"April",
            "May","June","July","August","September",
            "October","November","December"
            };
            return MonthName[--num];
        }
        public static long CalculateExponent(long number, long exponent)
        {
            long result = number;
            while (exponent > 1)
            {
                result *= number; 
                exponent--;

            }
            return result;
        }
        public static int[] MultiplyByLength(int[] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = arr[i] * arr.Length;
            }
            
                
            return result;
        }
        public static int CountVowels(string str)
        {
            int count = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0;i < str.Length;i++)
            {
               for (int j = 0;j < vowels.Length;j++)
                {
                    if (str[i]==vowels[j])
                        count++;
                }
            }
            return count;

        }
        public static int GetAbsSum(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += Math.Abs( i);
            return sum;
        }
        public static string ReverseAndNot(int i)
        {
            string num = i.ToString();
            var reversed = num.Reverse().ToList();
            string result = string.Empty;
            foreach (var item in reversed)
            {
               result +=item.ToString();
            }
            return result + num;
        }
        public static string Interview(int[] arr, int tot)
        {
            int[] modelAnswerTime = { 5, 5, 10, 10, 15, 15, 20, 20 };

            if (tot > 120)
                return "disqualified";
            if (arr.Length < 8)
                return "disqualified";
            bool flag = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > modelAnswerTime[i])
                { flag = false; }
            }
            if (!flag)
                return "disqualified";

            return "qualified";
        }
        public static string Uncensor(string txt, string vowels)
        {
          int counter = 0;
          var chars =  txt.ToCharArray();
            for (int i = 0;i < chars.Length; i++)
            {
                if (chars[i] == '*')
                {
                    chars[i] = vowels[counter];
                    counter++;
                }
            }
            
            string result = string.Empty;
            foreach (char c in chars)
            {
                result += c;
            }
            return result;
        }
        public static bool IsSmooth(string sentence)
        {
            var words = sentence.Split(' ');
            for (int i = 0;i < words.Length - 1;i++)
            {
                if (!words[i].EndsWith(words[i + 1][0]))
                    return false;
            }
            return true;
        }
        public static bool IsValidHexCode(string sentence)
        {
            if(string.IsNullOrEmpty( sentence) || sentence.Length != 7)
                return false;
            if(!sentence.StartsWith('#'))
                return false;
            char ch = char.MinValue;
            char[] chars = { 'a', 'b', 'c','d','e','f'};
            sentence = sentence.ToLower();
            for (int i = 1; i < sentence.Length; i++)
            {
                ch = sentence[i];
                if(!char.IsDigit(ch) && !chars.Contains(ch))
                    return false;
                
            }
            return true;
        }
        public static string CupSwapping(string[] swaps)
        {
            char ballIn = 'B';
            foreach (string str in swaps)
            {
                if (str[0]== ballIn)
                {
                    ballIn = str[1];
                }
                else if (str[1]== ballIn)
                {
                    ballIn = str[0];
                }
                else
                {
                    continue;
                }
            }

            return ballIn.ToString();
        }
        public static bool CanFind(string[] bigrams, string[] words)
        {
            
            foreach (string bigram in bigrams)
            {
                var flagBigramExists = false;
                foreach(string word in words)
                {
                   
                    if (word.Contains(bigram))
                    {
                        flagBigramExists = true;
                        break;
                    }
                }
                if (!flagBigramExists)
                {
                    return false;
                }
            }
            return true;
        }
        public static string WeekAfter(string date)
        {
            // day/month/year 
            var dateArry = date.Split('/').Select(e => Convert.ToInt32(e)).ToList();
            var GivenDate = new DateOnly(dateArry[2], dateArry[1],dateArry[0]);
            return GivenDate.AddDays(7).ToString("dd/MM/yyyy");
        }
        public static bool Brackets(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            string correctStr = str.Trim();
            Stack<char> stack = new Stack<char>();

            foreach (char c in correctStr)
            {
                if(c =='(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    var item = stack.Peek();
                    if (item == '(')
                    {
                        
                        stack.Pop();
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        public static string ReverseOdd(string str)
        {
            var words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 != 0)
                {
                    string item = string.Empty;
                    foreach(char ch in  words[i].Reverse())
                    {
                       item += ch;
                    }
                    words[i] = item;
                }

            } 
            string result = string.Empty;
            foreach (string word in words)
            {
                result += " "+ word;
            }
            return result;
        }
        public static int reversedBinaryInteger(int num)
        {
            var binaryString = Convert.ToString(num,2);
            string ReversedString = string.Empty;
            foreach (char ch in binaryString.Reverse())
            {
                ReversedString += ch;
            }
            var dicimalString = Convert.ToInt32(ReversedString, 2);
            return dicimalString;
        }
        public static string Fibonacci(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0)
                return a.ToString();

            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return b.ToString();

        }
        public static string ToCamelCase(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";
            var words = str.Split('_');
            if (words.Length == 0)
                return "";
            string result = words[0];
            for (int i = 1; i < words.Length; i++)
            {
                result += words[i][0].ToString().ToUpper() + words[i].Substring(1);
            }
            return result;

        }
        public static string TextToNumberBinary(string str)
        {
            str = str.ToLower();
            string result = string.Empty;
            var words = str.Split(' ');
            foreach (var word in words)
            {
                if(word == "one")
                {
                    result += "1";
                }
                else if(word == "zero")
                {
                    result += "0";
                }
                else
                {
                    continue;
                }
            }

            if(result.Length>=8)
                return result;
            return "";
        }
        public static int[] TrackRobot(int[] steps)
        {
            int[] postion = new int[2] { 0,0};
            if (steps.Length == 0)
                return postion;
            int arrryindex = 0;
            for (int i = 1; i <= steps.Length; i++)
            {
                if(i == 1)
                {
                    postion[1] += steps[arrryindex++];
                }
                else if (i == 2)
                {
                    postion[0] += steps[arrryindex++];
                }
                else if (i == 3)
                {
                    postion[1] -= steps[arrryindex++];
                }
                else if (i == 4)
                {
                    postion[0] -= steps[arrryindex++];
                }
                else { continue; }
            }
            return postion;
        }
        public static bool IsStrangePair(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1))
                return true;
            string firstStr = str1.ToLower();
            string secondStr = str2.ToLower();
            if (firstStr.StartsWith(secondStr.Last()) && firstStr.EndsWith(secondStr.First()))
                return true;

            return false;
        }
        public static int gcd(int n1, int n2)
        {
            int GCD = 0;
            for(int i = 1; i <= n1; i++)
            {
                if((n1 % i) == 0 && (n2%i)==0)
                { GCD = i; }
            }

            return GCD;
        }
        public static bool ValidateEmail(string str)
        {
            if(string.IsNullOrEmpty(str)) return false;
            if(!str.Contains('@') || !str.Contains('.'))
            {
                return false;
            }
            int firstIndexOfAt= str.IndexOf("@");
            int firstIndexOfDot = str.IndexOf(".");
            int lastIndexOfAt = str.LastIndexOf("@");
            int lastIndexOfdot = str.LastIndexOf(".");
            if (firstIndexOfAt != lastIndexOfAt)
                return false;
            if(lastIndexOfdot < lastIndexOfAt) return false;

            return true;
        }
        public static bool IsSymmetrical(int num)
        {
            string reversenumber = string.Empty;
            foreach (var n in num.ToString().Reverse())
                reversenumber += n;

            return reversenumber == num.ToString();
           
        }
        public static string Bomb(string txt)
        {
            if (txt.ToLower().Contains("bomb"))
                return "Duck!!!";
            return "There is no bomb, relax.";
        }
        public static string count_all(string txt)
        {
            int numberOfDigits = 0, numberOfLetters = 0;
            foreach (char Ch in txt)
            {
                if (char.IsDigit(Ch))
                    numberOfDigits++;
                else if (char.IsLetter(Ch))
                    numberOfLetters++;
                else
                    continue;
            }
            return $"  LETTERS = {numberOfLetters},DIGITS = {numberOfDigits}";
        }
        public static bool CheckPerfect(int num)
        {
            if (num == 0)
                return false;

            List<int> divisors = new List<int>();
            divisors.Add(1);
            for (int i = 2; i < num; i++)
            {
                if(num % i == 0)
                    divisors.Add(i);
            }
            if(divisors.Sum() == num)   
                return true;
            return false;
        }
        public static int square_areas_difference(int radius)
        {
            int squreSide = radius * 2 , diagonal = radius *2;
            int areaOfLargeSqure = squreSide * squreSide;
            int areaOfSmallSqure = (diagonal * diagonal) / 2;
            return Math.Abs(areaOfLargeSqure - areaOfSmallSqure);
            
        }
        public static bool ValidatePIN(string pin)
        {
            if(string.IsNullOrEmpty(pin))
                return false;
            if(pin.Length !=4) 
                return false;
            foreach (var ch in pin)
            {
                if(!char.IsDigit(ch))
                    return false;
            }
            return true;

        }
        public static string Accum(string str)
        {
            string result = string.Empty;
            for (int i = 0;i< str.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                    result += str[i];

                result += "-";
            }
            return result;
        }
        public static string RepeateArrow(int count)
        {
            var result = string.Empty;
            for (int i = 0; i < count; i++)
                result += ">";
            return result;
        }
        public static string[] Arrow(int num)
        {
            int length = num % 2 == 0 ? num * 2 : (num * 2) - 1;
            string[] result = new string[length];
            if(num % 2 == 0)
            {
                for(int i = 0; i < num; i++)
                {
                    int count = i + 1;
                    result[i] = result[length - i - 1] = RepeateArrow(count);
                }
            }
            else
            {
                for (int i = 0; i < num; i++)
                {
                    int count = i + 1;
                    result[i] = result[length - i - 1] = RepeateArrow(count);
                }
            }

            return result;
        }

        // 3
        public static string Simplify(string str)
        {
            string result = string.Empty;
            var strArray = str.Split('/');
            int[] fraction = new int[2];
            fraction[0] = Convert.ToInt32(strArray[0]);
            fraction[1] = Convert.ToInt32(strArray[1]);

            int mygcd =  gcd(fraction[0], fraction[1]);
            fraction[0] /= mygcd;
            fraction[1] /= mygcd;
            if (fraction[1] == 1)
                 result = $"{fraction[0]}";
            else
                 result = $"{fraction[0]} /{fraction[1]}";
            return result;
        }
        public static int License(string me, int agents, string others)
        {
            var All = others + " " + me;
            var peopleArray = All.Split(" ");
            var sortedPeople = peopleArray.OrderBy(x => x).ToList();
            int myPostion  = sortedPeople.IndexOf(me) +1;
            int postionDividedByAgents =(int)Math.Ceiling((float)myPostion / agents);
            if (postionDividedByAgents > 1)
                return postionDividedByAgents * 20;
            else
                return 20;
        }
        public static bool ValidatePassword(string password)
        {
            if(string.IsNullOrEmpty(password))
                return false;
            if(password.Length <6 || password.Length >24)
                return false;
            var capitalchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            var smallChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            bool flag = false;
            for (int i = 0; i< capitalchars.Length; i++)
            {
                if (password.Contains(capitalchars[i]))
                 {
                    flag = true;
                    break;
                 }
            }
            if (!flag)
            {
                return false;
            }
            flag = false;
            for (int i = 0; i < smallChars.Length; i++)
            {
                if (password.Contains(smallChars[i]))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }
            flag = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return false;
            }

            return true;
        }
        public static double[] FindLargest(double[][] values)
        {
            double[] result = new double[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                double max = values[i][0];
                for (int j = 1; j < values[i].Length; j++)
                {
                    if(max < values[i][j] )
                        max = values[i][j];
                }
                result[i] = max;
            }

            return result;
        }
        public static int[] CountPosSumNeg(double[] arr)
        {
            if(arr.Length == 0)
                return new int[0];
            int[] results = new int[2];
            int countOfPostiveNumber = 0, sumOfNegativeNumber = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    countOfPostiveNumber++;
                else if (arr[i] < 0)
                    sumOfNegativeNumber += (int)arr[i];
                else
                    continue;

            }
            results[0] = countOfPostiveNumber;
            results[1] = sumOfNegativeNumber;
            return results;

        }
        public static int[] FilterArray(object[] arr)
        {

            List<int> ints = new List<int>();
            foreach (object o in arr)
            {
                if (o is int)
                {
                    int item = (int)o;
                    if(!ints.Contains(item)) 
                        ints.Add(item);
                }
                   
            }
            return ints.ToArray();

        } 
        public static void GetFrame(int w, int h, char ch)
        {
            if(w < 3 || h < 3)
            {
                Console.WriteLine("Frame's width And Height Must Be Greater than 3");
                return;
            }
            for (int row = 1; row <= h;row++)
            {
                for(int col = 1; col <= w;col++)
                {
                    if (row == 1 || row == h || col ==1 || col == w)
                    {
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(' '); 
                    }
                }
                Console.WriteLine();
            }
        }
        public static string ReverseCoding01(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "";
            if (input.Length % 2 != 0)
                return "";
            char[] letters = new char[input.Length / 2];
            int[] numbers = new int[input.Length / 2];
            string result = string.Empty;
            for(int i = 0;i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers[i/2] = int.Parse(input[i].ToString());
                    continue;
                }
                
                letters[i/2] =(char) input[i];

            }
            for(int i = 0;i < letters.Length; i++ )
            {
                for(int j = 0; j < numbers[i];j++)
                {
                    result += letters[i];
                }
            }
            return result;
        }
        public static string ReverseCoding02(int input)
        {
            int max = 0, dif = 0; string result = string.Empty;
            for(int i = 2;i < int.MaxValue ;i*=2)
            {
                if(i < input)
                {
                    result += "2";
                }
                else
                {
                    max = i/2;
                    break;
                }
            }
            dif = input - max;
            result += dif.ToString();
            return result;
        }
        public static int ReverseCoding03(int input)
        {
            int result = 1;
            while(input %10 !=0)
            {
                result *= (input % 10);
                input /= 10;
            }

            return result;
        }
    }
}
