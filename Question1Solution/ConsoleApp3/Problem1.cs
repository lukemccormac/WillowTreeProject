using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

class WillowTree
{
    public static void CountWordsInDocument()
    {
        string outputFile = "C:\\Users\\lukem\\WillowTreeProject\\Question1Output.txt";
        string inputFile = "C:\\Users\\lukem\\Downloads\\Paragraph.txt";
        Dictionary<string, int> finalList = new Dictionary<string, int>();
        using (StreamReader sr = new StreamReader(inputFile))
        {
            using (StreamWriter sw = new StreamWriter(outputFile, true))
            {
                while (!sr.EndOfStream)
                {
                    string words = sr.ReadLine();
                    string textToLower = words.ToLower();
                    string[] splitWords = textToLower.Split(new char[]
                    { '.', ',', ' ', '?', '!', ';', ':', '"' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < splitWords.Length; i++)
                    {
                        if (finalList.ContainsKey(splitWords[i]))
                        {
                            int count = finalList[splitWords[i]];
                            finalList[splitWords[i]] = count + 1;
                        }
                        else
                        {
                            finalList.Add(splitWords[i], 1);
                        }
                    } 
                }
                foreach (KeyValuePair<string, int> kvp in finalList.OrderByDescending(key => key.Value))
                {
                    sw.WriteLine(kvp.Value + " " + kvp.Key);
                }
            }
        }
    }
}
