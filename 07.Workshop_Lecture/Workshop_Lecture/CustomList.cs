﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStructure
{
    /// <summary>
	/// Integer List
	/// </summary>
    class CustomList
    {
        /// <summary>
		/// Default size of interl array
		/// </summary>
		private const int defaultSize = 2;
        /// <summary>
        /// Internal array
        /// </summary>
        private int[] innerArr;
        /// <summary>
        /// Number of elements in the list
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Creates cystom integer list with default size
        /// </summary>
        public CustomList()
        {
            innerArr = new int[defaultSize];
        }
        /// <summary>
        /// Creates cystom integer list with inital size
        /// </summary>
        /// <param name="initialSize">Initial size of the list</param>
        public CustomList(int initialSize)
        {
            innerArr = new int[initialSize];
        }

        public int this[int index]
        {
            get
            {
                CheckIdexRange(index);
                return innerArr[index];
            }
            set
            {
                CheckIdexRange(index);
                innerArr[index] = value;
            }
        }

        public void Add(int element)
        {
            if (innerArr.Length == Count)
            {
                Grow();
            }

            innerArr[Count] = element;
            Count++;
        }

        public void AddRange(int[] list)
        {

            if (list.Length + Count >= innerArr.Length)
            {
                if (list.Length + Count > innerArr.Length * 2) { Grow((list.Length + Count) * 2); }
                else { Grow(); }
            }
            for (int i = 0; i < list.Length; i++)
            {
                innerArr[Count] = list[i];
                Count++;
            }
        }

        /// <summary>
        /// Removes element at postion
        /// </summary>
        /// <param name="index">position</param>
        /// <exception cref="IndexOutOfRangeException">The position is out of range</exception>
        public void RemoveAt(int index)
        {
                CheckIdexRange(index);
                ShiftLeft(index);
                Count--;
                Shrink();
           

        }

        public void InsertAt(int index, int element)
        {
            CheckIdexRange(index);
            ShiftRight(index);
            innerArr[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            bool result = false;
            for (int i = 0; i < Count; i++)
            {
                if (innerArr[i] == element)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            CheckIdexRange(firstIndex);
            CheckIdexRange(secondIndex);
            int tempElement = innerArr[firstIndex];
            innerArr[firstIndex] = innerArr[secondIndex];
            innerArr[secondIndex] = tempElement;
        }

        public void Shrink()
        {
            if (innerArr.Length / 4 > Count)
            {
                int[] tempArr = new int[innerArr.Length / 2];

                for (int i = 0; i < Count; i++)
                {
                    tempArr[i] = innerArr[i];
                }
                innerArr = tempArr;
            }
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(innerArr[i]);
            }
        }

        #region private
        private void Grow()
        {
            Grow(innerArr.Length * 2);
        }

        private void Grow(int newSize)
        {
            int[] tempArr = new int[newSize];

            innerArr.CopyTo(tempArr, 0);
            innerArr = tempArr;
        }

        private void ShiftLeft(int position)
        {
            if (position < Count - 1)
            {
                for (int i = position; i < Count - 1; i++)
                {
                    innerArr[i] = innerArr[i + 1];
                }
            }

            innerArr[Count - 1] = default(int);
        }

        private void ShiftRight(int position)
        {
            if (innerArr.Length == Count) { Grow(); }

            for (int i = Count - 1; i >= position; i--)
            {
                innerArr[i + 1] = innerArr[i];
            }
            innerArr[position] = default(int);
        }

        private void CheckIdexRange(int index)
        {
            if (index < 0 || index >= Count) { throw new IndexOutOfRangeException(); }
        }

        #endregion
    }
}
