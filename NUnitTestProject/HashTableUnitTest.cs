using System;
using DataStructure;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        LinkedHashMap<string, int> LinkedHashMap;
        [SetUp]
        public void Setup()
        {
            LinkedHashMap = new LinkedHashMap<string, int>(5);
        }

        [Test]
        public void GivenASentence_WheAddedToHashTable_ShouldReturnWordFrequency()
        {
            string sentence = "to be or not to be";
            string[] words = sentence.ToLower().Split(" ");

            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default) {
                    value = 1;
                } 
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("to");
            Console.WriteLine(LinkedHashMap);
            Assert.AreEqual(2, frequency);
        }

        [Test]
        public void GivenParagraph_WheneAddedToHashTable_ShouldReturnWordFrequency()
        {
            string Paragraph = "Paranoids are not " +
               "paranoid because they are paranoid but " +
               "because they keep putting themselves " +
               "deliberately into paranoid avoidable situations";
            string[] words = Paragraph.ToLower().Split(" ");

            foreach (string word in words)
            {
                int value = LinkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                LinkedHashMap.Add(word, value);
            }
            int frequency = LinkedHashMap.Get("paranoid");
            Console.WriteLine(LinkedHashMap);
            Assert.AreEqual(3, frequency);
        }
    }
}