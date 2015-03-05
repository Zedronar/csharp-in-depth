﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpInDepth
{
    public class Program
    {
        static Dictionary<string, int> CountWords(string text)
        {
            var frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }

        static void Main()
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am,
                            I do not like green eggs and ham.";

            var frequencies = CountWords(text);

            foreach (KeyValuePair<string, int> entry in frequencies)
            {
                string word = entry.Key;
                int frequency = entry.Value;
                Console.WriteLine("{0}: {1}", word, frequency);
            }
        }
    }
}
