using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formele_methoden
{
    public static class PracticumLes1Voorbeelden
    {
        /// <summary>
        /// begint met abb of eindigt op baab
        /// </summary>
        /// <returns></returns>
        static public Automata<string> BeginabbOfEindingbaab()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("0", 'a', "1"));
            automata.AddTransition(new Transition<string>("0", 'b', "4"));

            automata.AddTransition(new Transition<string>("1", 'a', "4"));
            automata.AddTransition(new Transition<string>("1", 'b', "2"));

            automata.AddTransition(new Transition<string>("2", 'a', "4"));
            automata.AddTransition(new Transition<string>("2", 'b', "3"));

            automata.AddTransition(new Transition<string>("3", 'a', "3"));
            automata.AddTransition(new Transition<string>("3", 'b', "3"));

            automata.AddTransition(new Transition<string>("4", 'a', "4"));
            automata.AddTransition(new Transition<string>("4", 'b', "5"));

            automata.AddTransition(new Transition<string>("5", 'a', "6"));
            automata.AddTransition(new Transition<string>("5", 'b', "5"));

            automata.AddTransition(new Transition<string>("6", 'a', "7"));
            automata.AddTransition(new Transition<string>("6", 'b', "5"));

            automata.AddTransition(new Transition<string>("7", 'a', "4"));
            automata.AddTransition(new Transition<string>("7", 'b', "8"));

            automata.AddTransition(new Transition<string>("8", 'a', "4"));
            automata.AddTransition(new Transition<string>("8", 'b', "5"));

            automata.DefineAsStartState("0");

            automata.DefineAsFinalState("3");
            automata.DefineAsFinalState("8");

            return automata;
        }

        /// <summary>
        /// bevat een even aantal b’s of bevat een oneven aantal a’s
        /// </summary>
        /// <returns></returns>
        static public Automata<string> EvenbOnevena()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("0", 'a', "2"));
            automata.AddTransition(new Transition<string>("0", 'b', "1"));

            automata.AddTransition(new Transition<string>("1", 'a', "4"));
            automata.AddTransition(new Transition<string>("1", 'b', "3"));

            automata.AddTransition(new Transition<string>("2", 'a', "0"));
            automata.AddTransition(new Transition<string>("2", 'b', "1"));

            automata.AddTransition(new Transition<string>("3", 'a', "2"));
            automata.AddTransition(new Transition<string>("3", 'b', "1"));

            automata.AddTransition(new Transition<string>("4", 'a', "5"));
            automata.AddTransition(new Transition<string>("4", 'b', "3"));

            automata.AddTransition(new Transition<string>("5", 'a', "4"));
            automata.AddTransition(new Transition<string>("5", 'b', "3"));

            automata.DefineAsStartState("0");

            automata.DefineAsFinalState("0");
            automata.DefineAsFinalState("2");
            automata.DefineAsFinalState("3");
            automata.DefineAsFinalState("4");

            return automata;
        }

        /// <summary>
        /// bevat een even aantal b’s en eindigt op aab
        /// </summary>
        /// <returns></returns>
        static public Automata<string> EvenbEindigaab()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("0", 'a', "0"));
            automata.AddTransition(new Transition<string>("0", 'b', "1"));

            automata.AddTransition(new Transition<string>("1", 'a', "2"));
            automata.AddTransition(new Transition<string>("1", 'b', "0"));

            automata.AddTransition(new Transition<string>("2", 'a', "3"));
            automata.AddTransition(new Transition<string>("2", 'b', "0"));

            automata.AddTransition(new Transition<string>("3", 'a', "2"));
            automata.AddTransition(new Transition<string>("3", 'b', "4"));

            automata.AddTransition(new Transition<string>("4", 'a', "2"));
            automata.AddTransition(new Transition<string>("4", 'b', "0"));

            automata.DefineAsStartState("0");

            automata.DefineAsFinalState("4");

            return automata;
        }

        /// <summary>
        /// begint met abb en bevat baab
        /// </summary>
        /// <returns></returns>
        static public Automata<string> BeginabbBevatbaab()
        {
            char[] alphabet = { 'a', 'b' };
            Automata<string> automata = new Automata<string>(alphabet);

            automata.AddTransition(new Transition<string>("0", 'a', "2"));
            automata.AddTransition(new Transition<string>("0", 'b', "1"));

            automata.AddTransition(new Transition<string>("1", 'a', "1"));
            automata.AddTransition(new Transition<string>("1", 'b', "1"));

            automata.AddTransition(new Transition<string>("2", 'a', "3"));
            automata.AddTransition(new Transition<string>("2", 'b', "1"));

            automata.AddTransition(new Transition<string>("3", 'a', "1"));
            automata.AddTransition(new Transition<string>("3", 'b', "4"));

            automata.AddTransition(new Transition<string>("4", 'a', "5"));
            automata.AddTransition(new Transition<string>("4", 'b', "4"));

            automata.AddTransition(new Transition<string>("5", 'a', "6"));
            automata.AddTransition(new Transition<string>("5", 'b', "4"));

            automata.AddTransition(new Transition<string>("6", 'a', "8"));
            automata.AddTransition(new Transition<string>("6", 'b', "7"));

            automata.AddTransition(new Transition<string>("7", 'a', "7"));
            automata.AddTransition(new Transition<string>("7", 'b', "7"));

            automata.AddTransition(new Transition<string>("8", 'a', "8"));
            automata.AddTransition(new Transition<string>("8", 'b', "4"));

            automata.DefineAsStartState("0");

            automata.DefineAsFinalState("7");

            return automata;
        }
    }
}
