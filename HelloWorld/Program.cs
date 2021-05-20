using System;
using System.Collections.Generic;

namespace ExampleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            ReturnList returnList = new ReturnList();

            List<int> result = returnList.GetEven(initialList);
            result.ForEach(e => {Console.WriteLine(e);});
        }
    }

    public interface IReturnList
    {
        List<int> GetEven(List<int> listOfNumbers);
    }

    public class ReturnList : IReturnList
    {
        public List<int> GetEven(List<int> listOfNumbers)
        {
            List<int> listOfEven = new List<int>();

            listOfNumbers.ForEach(e=>{if(e  % 2 == 0){listOfEven.Add(e);}});

            return listOfEven;
        }
    }
}