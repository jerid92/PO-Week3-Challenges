using System;
using System.Collections;

namespace NoStringsInArray
{
    class NoStringInArray
    {
        static void Main(string[] args)
        {
            NoStringInArray array = new NoStringInArray();

            ArrayList list1 = new ArrayList() { 1, 2, "a", "b" };
            ArrayList list2 = new ArrayList() { 1, "a", "b", 0, 15 };
            ArrayList list3 = new ArrayList() { 1, 2, "aasf", "1", "123", 123 };
            ArrayList outcome = new ArrayList();

            outcome = array.ArrayFiltered(list1);
            array.viewOutcome(outcome);

            outcome = array.ArrayFiltered(list2);
            array.viewOutcome(outcome);

            outcome = array.ArrayFiltered(list3);
            array.viewOutcome(outcome);


        }

        public ArrayList ArrayFiltered(ArrayList arl)
        {
            ArrayList outcome = new ArrayList();

            foreach(var item in arl)
            {
                if(item.GetType() == typeof(int))
                {
                    outcome.Add(item);
                }
            }

            return outcome;
        }

        public void viewOutcome(ArrayList arl)
        {
            ArrayList outcome = new ArrayList();
            outcome = ArrayFiltered(arl);
            string st = "[ ";
            for (int i = 0; i <= outcome.Count; i++)
            {
                if( i == outcome.Count - 1)
                {
                    st += $"{outcome[i]} ]";
                }
                else
                {
                    st += $"{outcome[i]}, ";
                }
            }
            Console.WriteLine(st);
        }
    }
}
