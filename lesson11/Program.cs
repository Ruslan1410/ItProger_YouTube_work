using System;
using System.IO;

namespace project {

    class Program {

        static void Main() {
            string word = "Hello";
            word += "!!";

            // Console.WriteLine(word[1]);
            // word = (string.Concat(word, "!"));
            // Console.WriteLine(string.Compare(word, "Hello"));

            //string people = "Alex, Bob, John";
            //string[] names = people.Split(new char[]{','});
            //people = string.Join(" ", names);
            //Console.WriteLine(people);

            System.Console.WriteLine(word.Substring(2));
        }
    }
}