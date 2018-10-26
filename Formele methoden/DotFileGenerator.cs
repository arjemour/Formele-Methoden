using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formele_methoden
{
    public class DotFileGenerator
    {
        /// <summary>
        /// Schrijf Automata naar een dot file voor graphviz
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="automata"></param>
        /// <param name="filename"></param>
        /// <param name="path">Moet eindigen op / als het geen lege string is</param>
        /// <param name="leftRight">default zal de graph van boven naar beneden worden getekend</param>
        public void WriteToDotFile<T>(Automata<T> automata, string filename, string path = "", bool leftRight = false) where T : IComparable
        {
            Dictionary<T, int> labels = new Dictionary<T, int>();

            for(int i = 1; i < automata.States.Count + 1; i++)
                labels.Add(automata.States.ElementAt(i - 1), i);

            using (StreamWriter writer = new StreamWriter($"{path}{filename}.dot"))
            {
                writer.WriteLine("digraph dfa {");

                if(leftRight)
                    writer.WriteLine("rankdir=LR;");
                
                //Labels
                writer.WriteLine(@"NOTHING [label="""", shape=none]");
                foreach(var label in labels)
                {
                    if(automata.StartStates.Contains(label.Key))
                        writer.WriteLine($@"{label.Value} [label=""{label.Key}"", shape=ellipse, style=filled, color=lightblue]");
                    else if (automata.FinalStates.Contains(label.Key))
                        writer.WriteLine($@"{label.Value} [label=""{label.Key}"", shape=ellipse, style=filled, color=yellowgreen]");
                    else
                        writer.WriteLine($@"{label.Value} [label=""{label.Key}"", shape=ellipse, style=filled]");
                }

                //Transitions
                foreach(var state in automata.StartStates)
                {
                    writer.WriteLine($"NOTHING -> {labels[state]}");
                }
                foreach(var transition in automata.Transitions)
                {
                    int from = labels[transition.FromState];
                    int to = labels[transition.ToState];
                    writer.WriteLine($@"{from} -> {to} [label=""{transition.Symbol}""]");
                }

                writer.WriteLine("}");
            }
        }
    }
}
