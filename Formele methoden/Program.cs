using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formele_methoden
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = getExampleSlide8Lesson2();
            var y = getExampleSlide14Lesson2();

            DotFileGenerator dotFileGenerator = new DotFileGenerator();
            dotFileGenerator.WriteToDotFile(x, "test", "", true);
        }

        static public Automata<string> getExampleSlide8Lesson2()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> m = new Automata<string>(alphabet);

            m.AddTransition(new Transition<string>("q0", 'a', "q1"));
            m.AddTransition(new Transition<string>("q0", 'b', "q4"));

            m.AddTransition(new Transition<string>("q1", 'a', "q4"));
            m.AddTransition(new Transition<string>("q1", 'b', "q2"));

            m.AddTransition(new Transition<string>("q2", 'a', "q3"));
            m.AddTransition(new Transition<string>("q2", 'b', "q4"));

            m.AddTransition(new Transition<string>("q3", 'a', "q1"));
            m.AddTransition(new Transition<string>("q3", 'b', "q2"));

            // the error state, loops for a and b:
            m.AddTransition(new Transition<string>("q4", 'a'));
            m.AddTransition(new Transition<string>("q4", 'b'));

            // only on start state in a dfa:
            m.DefineAsStartState("q0");

            // two final states:
            m.DefineAsFinalState("q2");
            m.DefineAsFinalState("q3");

            return m;
        }


        static public Automata<string> getExampleSlide14Lesson2()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> m = new Automata<string>(alphabet);

            m.AddTransition(new Transition<string>("A", 'a', "C"));
            m.AddTransition(new Transition<string>("A", 'b', "B"));
            m.AddTransition(new Transition<string>("A", 'b', "C"));

            m.AddTransition(new Transition<string>("B", 'b', "C"));
            m.AddTransition(new Transition<string>("B", "C"));

            m.AddTransition(new Transition<string>("C", 'a', "D"));
            m.AddTransition(new Transition<string>("C", 'a', "E"));
            m.AddTransition(new Transition<string>("C", 'b', "D"));

            m.AddTransition(new Transition<string>("D", 'a', "B"));
            m.AddTransition(new Transition<string>("D", 'a', "C"));

            m.AddTransition(new Transition<string>("E", 'a'));
            m.AddTransition(new Transition<string>("E", "D"));

            // only on start state in a dfa:
            m.DefineAsStartState("A");

            // two final states:
            m.DefineAsFinalState("C");
            m.DefineAsFinalState("E");

            return m;
        }
    }
}
