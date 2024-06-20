using System;
using System.Collections;
using System.Collections.Generic;

namespace Enum_Ex1
{
    public class NumberCollection : IEnumerable<int>
    {
        private List<int> numbers;

        public NumberCollection()
        {
            numbers = new List<int>();
        }

        public void Add(int number)
        {
            numbers.Add(number);
        }

        public IEnumerator<int> GetEnumerator()
        {
            foreach (int number in numbers)
            {
                yield return number;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
