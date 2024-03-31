using System;

namespace Task_4_1
{
    sealed class OneDimensionalArray<T>
    {
        private T[] array;
        private int capacity;
        private int length;
        Comparer<T> comparer = Comparer<T>.Default;
        private int default_capacity = 5;
        public OneDimensionalArray(int capacity)
        {
            length = 0;
            this.capacity = capacity;
            array = new T[capacity];
        }

        public OneDimensionalArray()
        {
            array = new T[default_capacity];
        }

        public void Add(T el)
        {
            if(length == capacity)
            {
                T[] NewAr = array;
                capacity = capacity * 2 + 1;
                array = new T[capacity];
                for(int i = 0; i < length; i ++)
                {
                    array[i] = NewAr[i];
                }
            }
            array[length] = el;
            length++;
        }
        
        public void Sort()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++) 
                {
                    if (comparer.Compare(array[i], array[j]) < 0)
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
        }

        public void Remove(T el)
        {
            if(!ElInAr(el))
            {
                throw new Exception("Нет такого элемента в массиве");
            }
            T[] NewAr = new T[length-1];
            for(int i = 0, j = 0; i < length; i ++)
            {
                if(comparer.Compare(array[i], el) != 0)
                {
                    NewAr[j] = array[i];
                    j ++;
                }
            }
            array = NewAr;
            length --;
            
       }

       public T TheFirstElementWithCond(Func<T, bool> condition)
       {
            if(condition==null)
            {
                throw new Exception("Не введено условие");
            }
            for(int i = 0; i < length; i ++)
            {
                if(condition(array[i]))
                {
                    return array[i];
                }
            }
            throw new Exception("Нет элемента, подходящего под условие");
       }

        public int Capacity()
        {
            return capacity;
        }

        public int Elements()
        {
            return length;
        }

        public void Print()
        {
            for(int i = 0; i < length; i ++){
                Console.Write(array[i] + " ");
            }
        }

        public T Min()
        {
            T min = array[0];
            for(int i = 0; i < array.Length; i ++)
            {
                if(comparer.Compare(array[i], min) == -1)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = array[0];
            for(int i = 0; i < array.Length; i ++)
            {
                if(comparer.Compare(array[i], max) == 1)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public TResult MaxProj<TResult>(Func<T, TResult> conv)
        {
            Comparer<TResult> comparerT = Comparer<TResult>.Default;
            TResult max = conv(array[0]);
            for (int i = 1; i < length; ++i)
            {
                if (comparerT.Compare(conv(array[i]), max) > 0)
                {
                    max = conv(array[i]);
                }
            }

            return max;
        }

        public TResult MinProj<TResult>(Func<T, TResult> conv)
        {
            Comparer<TResult> comparerT = Comparer<TResult>.Default;
            TResult min = conv(array[0]);
            for (int i = 1; i < length; ++i)
            {
                if (comparerT.Compare(conv(array[i]), min) > 0)
                {
                    min = conv(array[i]);
                }
            }

            return min;
        }


        public void Reverse()
        {
            T newvar;
            for (int i = 0; i < length/2; i++)
            {
                (array[i], array[length - i -1]) = (array[length - i-1], array[i]);
            }

        }

        public T[] ElementsAfterIndex(int index, int col)
        {
            if((index + col) > length)
            {
                throw new Exception("Количество элементов после указанного индекса превышает длину массива");
            }
            T[] NewAr = new T[col];
            for(int i = 0; i < col; i ++)
            {
                NewAr[i] = array[index];
                index ++;
            }
            return NewAr;
        }

        public bool ElInAr(T el)
        {
            for(int i = 0; i < length; i ++)
            {
                if(comparer.Compare(el, array[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public int CountOfElementsWithCond(Func<T, bool> condition)
        {
            int col = 0;
            for(int i = 0; i < length; i ++)
            {
                if(condition(array[i]))
                {
                    col ++;
                }
            }
            return col;
        }

        public bool ELInArCond(Func<T, bool> condition)
        {
            for(int i = 0; i < length; i ++)
            {
                if(condition(array[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsElementsWithCond(Func<T, bool> condition)
        {
            int col = 0;
            for(int i = 0; i < length; i ++)
            {
                if(condition(array[i]))
                {
                    col ++;
                }
            }
            if(col == length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public T[] ElementsWithCond(Func<T, bool> condition)
        {
            T[] NewAr = new T[CountOfElementsWithCond(condition)];
            for(int i = 0, j = 0; i < NewAr.Length; i ++)
            {
                if(condition(array[i]))
                {
                    NewAr[j] = array[i];
                    j ++;
                }
            }
            return NewAr;
        }

        public void ForEach(Action<T> action)
        {
            for(int i = 0; i < length; i ++)
            {
                action(array[i]);
            }
        }
    }
}