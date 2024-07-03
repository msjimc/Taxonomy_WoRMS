using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomy_WoRMS
{
    public class fieldsToSearch
    {
        private char first;
        private char second;
        private bool firstFromEnd;
        private bool secondFromEnd;
        private bool secondPresent;       
        private int firstFirstIndex;
        private int firstSecondIndex;
        private int secondFirstIndex;
        private int secondSecondIndex;
        private int itemsCount = -1;
        private bool combinetwoFields = false;
        private bool reverseOrder = false;
        private bool ignoreNones = false;
        public fieldsToSearch(char First, bool SecondPresent, char Second, bool FirstFromEnd, int FirstFirstIndex, int FirstSecondIndex, bool SecondFromEnd, int SecondFirstIndex, int SecondSecondIndex, int ItemsCount, bool CombinetwoFields, bool ReverseOrder, bool IgnoreNones)
        {
            first = First;
            secondPresent = SecondPresent;
            second = Second;
            firstFirstIndex = FirstFirstIndex - 1;
            firstSecondIndex = FirstSecondIndex - 1;
            secondFirstIndex = SecondFirstIndex - 1;
            secondSecondIndex = SecondSecondIndex - 1;
            firstFromEnd = FirstFromEnd;
            secondFromEnd = SecondFromEnd;
            itemsCount = ItemsCount;
            combinetwoFields = CombinetwoFields;
            reverseOrder = ReverseOrder;
            ignoreNones = IgnoreNones;
        }

        public int ItemsCount { get { return itemsCount; } }

        public List<string> words(string line)
        {
            List<string> answer = new List<string>(0);

            int localFF = firstFirstIndex;
            int localFS = firstSecondIndex;
            int localSF = secondFirstIndex;
            int localSS = secondSecondIndex;

           string[] items = line.Split(first);

            if (localFF > items.Length - 1)
            {
                return answer;
            }

            if (firstFromEnd)
            {
                localFS = items.Length - 1 - firstFirstIndex;
                localFF = items.Length - 1 - firstSecondIndex;
            }

            if (secondPresent == true)
            {                             
                 items = items[localFF].Split(second);

                if (ignoreNones == true) { items = RemoveNones(items); }

                if (secondFromEnd)
                {
                    localSS = items.Length - 1 - secondFirstIndex;
                    localSF = items.Length - 1 - secondSecondIndex;
                }

                if (localSF < items.Length && localSS < items.Length)
                {
                    if (combinetwoFields == false)
                    {
                        for (int index = localSS; index > localSF - 1; index--)
                        {
                            if (index > -1 && index < items.Length)
                            { answer.Add(items[index].Replace("\"","")); }
                        }
                    }
                    else
                    {
                        for (int index = localSS; index > localSF; index--)
                        {
                            if (index > -1 && index < items.Length)
                            { answer.Add(items[index - 1].Replace("\"", "") + " " + items[index].Replace("\"", "")); }
                        }
                    }
                }                
            }
            else
            {
                if (localFF < items.Length && localFS < items.Length)
                {
                    if (combinetwoFields == false)
                    {
                        for (int index = localFS; index > localFF -1 ; index--)
                        {
                            if (index > -1 && index < items.Length)
                            { answer.Add(items[index].Replace("\"", "")); }
                        }
                    }
                    else
                    {
                        for (int index = localSS; index > localSF; index--)
                        {
                            if (index > -1 && index < items.Length)
                            { answer.Add(items[index - 1].Replace("\"", "") + " " + items[index].Replace("\"", "")); }
                        }
                    }
                }
            }

            if (reverseOrder == false)
            { answer = ReverseOrder(answer); }    

            return answer;
        }

        private string[] RemoveNones(string[] itemsIn)
        {
            List<string> answer = new List<string>();
            for (int index = 0; index < itemsIn.Length; index++)
            {
                if (itemsIn[index].ToLower().Equals("none") == false)
                {
                    answer.Add(itemsIn[index]);
                }
            }

            return answer.ToArray();
        }

        private List<string> ReverseOrder(List<string> answer)
        {
            List<string> result = new List<string>();
            for (int index = answer.Count - 1;index > -1;index--)
            { result.Add(answer[index]); }
            return result;
        }

        public string BaseLine(string line)
        {
            string[] items = line.Split(first);
            int localFF = firstFirstIndex;
            int localFS = firstSecondIndex;

            if (firstFromEnd)
            {
                localFS = items.Length - 1 - (firstFirstIndex);
                localFF = items.Length - 1 - (firstSecondIndex );
            }

            string answer = "";
            for (int index = 0; index < items.Length; index++)
            {
                if (index < localFF || index > localFS)
                { answer += "\t" + items[index] ; }
            }

            return answer.Substring(1);
        }

        public char FirstDelimitor
        { get { return first; } }
    }
}
