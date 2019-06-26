using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04Froggy
{
    public class Lake : IEnumerable<int>
    {
        private int[] stones;

        public Lake(int[] stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            //1, 2, 3, 4, 5, 6, 7, 8
            //1, 3, 5, 7, 8, 6, 4, 2

            for (int index = 0; index < this.stones.Length; index++)
            {
                if (index%2 == 0)
                {
                    yield return this.stones[index];
                }
            }

            for (int i = this.stones.Length - 1; i >= 0; i--)
            {

                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
