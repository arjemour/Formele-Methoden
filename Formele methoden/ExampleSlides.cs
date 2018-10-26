using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formele_methoden
{
    public static class ExampleSlides
    {
        static public Automata<string> GetExampleSlide8Lesson2()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("q0", 'a', "q1"));
            automata.AddTransition(new Transition<string>("q0", 'b', "q4"));

            automata.AddTransition(new Transition<string>("q1", 'a', "q4"));
            automata.AddTransition(new Transition<string>("q1", 'b', "q2"));

            automata.AddTransition(new Transition<string>("q2", 'a', "q3"));
            automata.AddTransition(new Transition<string>("q2", 'b', "q4"));

            automata.AddTransition(new Transition<string>("q3", 'a', "q1"));
            automata.AddTransition(new Transition<string>("q3", 'b', "q2"));

            // the error state, loops for a and b:
            automata.AddTransition(new Transition<string>("q4", 'a'));
            automata.AddTransition(new Transition<string>("q4", 'b'));

            // only on start state in a dfa:
            automata.DefineAsStartState("q0");

            // two final states:
            automata.DefineAsFinalState("q2");
            automata.DefineAsFinalState("q3");

            return automata;
        }

        static public Automata<string> GetExampleSlide14Lesson2()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("A", 'a', "C"));
            automata.AddTransition(new Transition<string>("A", 'b', "B"));
            automata.AddTransition(new Transition<string>("A", 'b', "C"));

            automata.AddTransition(new Transition<string>("B", 'b', "C"));
            automata.AddTransition(new Transition<string>("B", "C"));

            automata.AddTransition(new Transition<string>("C", 'a', "D"));
            automata.AddTransition(new Transition<string>("C", 'a', "E"));
            automata.AddTransition(new Transition<string>("C", 'b', "D"));

            automata.AddTransition(new Transition<string>("D", 'a', "B"));
            automata.AddTransition(new Transition<string>("D", 'a', "C"));

            automata.AddTransition(new Transition<string>("E", 'a'));
            automata.AddTransition(new Transition<string>("E", "D"));

            // only on start state in a dfa:
            automata.DefineAsStartState("A");

            // two final states:
            automata.DefineAsFinalState("C");
            automata.DefineAsFinalState("E");

            return automata;
        }
    }
}
