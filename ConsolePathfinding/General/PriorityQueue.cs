﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ConsolePathfinding.General
{
    public class PriorityQueue<T>
    {
        private List<Tuple<T, double>> elements = new List<Tuple<T, double>>();

        public int Count
        {
            get { return elements.Count; }
        }

        public void Enqueue(T item, double priority)
        {
            elements.Add(Tuple.Create(item, priority));
        }

        public T Dequeue()
        {
            int bestIndex = 0;

            for(int i = 0; i < elements.Count; i++)
            {
                if(elements[i].Item2 < elements[bestIndex].Item2)
                {
                    bestIndex = i;
                }
            }

            T item = elements[bestIndex].Item1;
            elements.RemoveAt(bestIndex);
            return item;
        }
		public T GetPrioritized()
		{
			int bestIndex = 0;

			for (int i = 0; i < elements.Count; i++)
			{
				if (elements[i].Item2 < elements[bestIndex].Item2)
				{
					bestIndex = i;
				}
			}

			T item = elements[bestIndex].Item1;
			return item;
		}
    }
}
