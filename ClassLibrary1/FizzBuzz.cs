using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        private SortedDictionary<int, string> fbDict;
        private int upperBound = 0;
        public FizzBuzz()
        {
            this.fbDict = new SortedDictionary<int, string>();
        }

        public FizzBuzz(int upBound)
        {
            this.fbDict = new SortedDictionary<int, string>();
            if (upBound > 0)
            {
                this.upperBound = upBound;
            }
        }

        public FizzBuzz(KeyValuePair<int, string>[] wordNumPairs)
        {
            foreach(KeyValuePair<int, string> kvp in wordNumPairs)
            {
                if (kvp.Key < 1)
                {
                    //lets skip them 0s and negatives
                    continue;
                }
                try
                {
                    this.fbDict.Add(kvp.Key, kvp.Value);
                }
                catch(ArgumentNullException)
                {
                    //Do not add a null
                }
                catch(ArgumentException)
                {
                    //OverWrite previous one
                    this.fbDict[kvp.Key] = kvp.Value;
                }
                
            }
            
            upperBound = this.fbDict.Keys.Max();

        }

        public FizzBuzz(KeyValuePair<int, string>[] wordNumPairs, int upBound)
        {
            foreach (KeyValuePair<int, string> kvp in wordNumPairs)
            {
                if(kvp.Key < 1)
                {
                    //lets skip them 0s and negatives
                    continue;
                }
                try
                {
                    this.fbDict.Add(kvp.Key, kvp.Value);
                }
                catch (ArgumentNullException)
                {
                    //Do not add a null
                }
                catch (ArgumentException)
                {
                    //OverWrite previous one
                    this.fbDict[kvp.Key] = kvp.Value;
                }

            }
            if(upBound > 0)
            {
                this.upperBound = upBound;
            }
           
        }

        public ArrayList getCustomFizzBuzz()
        {
            ArrayList b = new ArrayList();
            if(upperBound < 1)
            {
                b.Add("");
                return b;
            }
            
            for (int i = 1; i <= upperBound; i++)
            {
                string fizzBuzz = "";
                foreach (KeyValuePair<int, string> kvp in fbDict)
                {
                    if(i%kvp.Key == 0)
                    {
                        fizzBuzz += kvp.Value;
                    }
                }
                if(fizzBuzz.Length < 1)
                {
                    fizzBuzz = i.ToString();
                }
                b.Add(fizzBuzz);
            }
            return b;
        }

        public ArrayList getFizzBuzz()
        {
            ArrayList a = new ArrayList();
            
            if (upperBound < 1)
            {
                a.Add("");
                return a;
            }

            for (int i = 1; i <= upperBound; i++)
            {
                string fizzBuzz = "";
                if(i%3 == 0)
                {
                    fizzBuzz += "Fizz";
                }
                if(i%5==0)
                {
                    fizzBuzz += "Buzz";
                }
                if (fizzBuzz.Length < 1)
                {
                    fizzBuzz = i.ToString();
                }
                a.Add(fizzBuzz);
            }
            return a;
        }

        public int getUpperBound()
        {
            return this.upperBound;
        }

        public void setUpperBound(int upBound)
        {
            if (upBound > 0)
            {
                this.upperBound = upBound;
            }
        }

        public SortedDictionary<int, string> getFizzBuzzDictionary()
        {
            return this.fbDict;
        }

        public void addFizzBuzzPair(KeyValuePair<int, string> kVP)
        {
            if(kVP.Key < 1 || kVP.Key > this.upperBound)
            {
                return;
            }
            if(fbDict.ContainsKey(kVP.Key))
            {
                this.fbDict[kVP.Key] = kVP.Value; 
            }
            else
            {
                this.fbDict.Add(kVP.Key, kVP.Value);
            }
           
        }

        public void addFizzBuzzPair(int key, string value)
        {
            if(key < 1 || key > this.upperBound)
            {
                return;
            }
            if (fbDict.ContainsKey(key))
            {
                this.fbDict[key] = value;
            }
            else
            {
                this.fbDict.Add(key, value);
            }
            
        }

        public bool fbDictIsEmpty()
        {
            return this.fbDict.Count < 1;
        }


    }
}
