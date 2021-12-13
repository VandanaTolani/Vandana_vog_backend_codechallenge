using System;

namespace VogCodeChallenge.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loop through list
            using (var enumerator = QuestionClass.NamesList.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }

                var testModule1 = QuestionClass.TestModule<int>(2);
                Console.WriteLine($"passing int value to test module result: {testModule1}");

                var testModule2 = QuestionClass.TestModule<string>("hello world");
                Console.WriteLine($"passing string value to test module convert upper case: {testModule2}");

                Console.ReadKey();
            }
        }
    }
}
