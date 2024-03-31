using System;
using System.ComponentModel;

namespace generalization
{
    interface IBase<T>
    {
        void Add();
        T Max();
        T Min();
        void Reprint();
        void Print();
        int Capacity();
        int Length();
        void Reverse();
        T[] ElementsAfterIndex(int index, int col);
        bool ElInAr(T el);
        int CountOfElementsWithCond(Func<T, bool> condition);
        bool ELInArCond(Func<T, bool> condition);
        bool IsElementsWithCond(Func<T, bool> condition);
        T[] ElementsWithCond(Func<T, bool> condition);
        void ForEach(Action<T> action);
        TResult MinProj<TResult>(Func<T, TResult> conv);
        TResult MaxProj<TResult>(Func<T, TResult> conv);
        int Elements();
        T TheFirstElementWithCond(Func<T, bool> condition);
        void Remove(T el);
        void Sort();
        void Add(T el);
        

    }
}