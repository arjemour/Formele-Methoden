using System;
using System.Collections.Generic;

namespace Formele_methoden
{
    public class Automata <T> where T : IComparable
    {
        public HashSet<Transition<T>> Transitions { get; private set; }

        public SortedSet<T> States { get; private set; }
        public SortedSet<T> StartStates { get; private set; }
        public SortedSet<T> FinalStates { get; private set; }

        public SortedSet<char> Symbols { get; private set; }

        public Automata() : this(new SortedSet<char>())
        { }

        public Automata(char[] s) : this(new SortedSet<char>(s))
        { }

        public Automata(SortedSet<char> symbols)
        {
            Transitions = new HashSet<Transition<T>>();
            States = new SortedSet<T>();
            StartStates = new SortedSet<T>();
            FinalStates = new SortedSet<T>();

            SetAlphabet(symbols);
        }

        public void SetAlphabet(char[] symbols)
        {
            Symbols = new SortedSet<char>(symbols);
        }

        public void SetAlphabet(SortedSet<char> symbols)
        {
            Symbols = symbols;
        }

        public void AddTransition(Transition<T> transition)
        {
            Transitions.Add(transition);
            States.Add(transition.FromState);
            States.Add(transition.ToState);
        }

        public void DefineAsStartState(T state)
        {
            States.Add(state);
            StartStates.Add(state);
        }

        public void DefineAsFinalState(T state)
        {
            States.Add(state);
            FinalStates.Add(state);
        }

        public void PrintTransitions()
        {
            foreach (Transition<T> transition in Transitions)
                Console.WriteLine(transition);
        }

        public bool IsDFA()
        {
            bool isDFA = true;

            foreach (T from in States)
                foreach (char symbol in Symbols)
                {
                    isDFA = isDFA && GetToStates(from, symbol).Count == 1;
                    if(!isDFA)
                        return false;
                }

            return true;
        }

        public List<T> GetToStates(T from, char symbol)
        {
            List<T> toStates = new List<T>();

            foreach (Transition<T> t in Transitions)
                if (t.FromState.Equals(from) && t.Symbol.Equals(symbol))
                    toStates.Add(t.ToState);

            return toStates;
        }

        /// <summary>
        /// Checks if input is valid, always returns false if ndfa
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool AcceptInputDfa(string input)
        {
            if(!IsDFA())
                return false;

            char[] inputSymbols = input.ToCharArray();

            foreach (char symbol in inputSymbols)
                if (!Symbols.Contains(symbol))
                    return false;

            List<Transition<T>> startStatesTransitions = new List<Transition<T>>();
            foreach(Transition<T> t in Transitions)
                if(StartStates.Contains(t.FromState))
                    startStatesTransitions.Add(t);

            T nextState1Temp = default(T);
            foreach (Transition<T> state in startStatesTransitions)
            {
                if (state.Symbol == inputSymbols[0])
                {
                    nextState1Temp = state.ToState;
                    break;
                }
            }

            List<Transition<T>> nextState1 = new List<Transition<T>>();
            foreach (Transition<T> t in Transitions)
                if (t.FromState.Equals(nextState1Temp))
                    nextState1.Add(t);

            return true;
        }
    }
}
