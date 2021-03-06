﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formele_methoden
{
    public class Transition<T> : IComparable<Transition<T>> where T : IComparable
    {
        public readonly static char EPSILON = '$';

        public T FromState { get; private set; }
        public T ToState { get; private set; }
        public char Symbol { get; private set; }

        public Transition(T fromOrTo, char s) : this(fromOrTo, s, fromOrTo)
        {}

        public Transition(T from, T to) : this(from, EPSILON, to)
        {}

        public Transition(T from, char s, T to)
        {
            FromState = from;
            Symbol = s;
            ToState = to;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else if (obj is Transition<T>)
            {
                Transition<T> transition = (Transition<T>)obj;
                return FromState.CompareTo(transition.FromState) == 0 &&
                ToState.CompareTo(transition.ToState) == 0 &&
                Symbol == transition.Symbol;
            }

            return false;
        }

        public int CompareTo(Transition<T> other)
        {
            int fromCompare = FromState.Equals(other.FromState) ? 1 : 0;
            int symbolCompare = Symbol.CompareTo(other.Symbol);
            int toCompare = ToState.Equals(other.ToState) ? 1 : 0;

            return fromCompare != 0 ? fromCompare : (symbolCompare != 0 ? symbolCompare : toCompare);
        }

        public string toString()
        {
            return $"({FromState}, {Symbol}) --> {ToState}";
        }
    }
}
