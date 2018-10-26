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
            var slide1 = ExampleSlides.GetExampleSlide8Lesson2();
            var slide2 = ExampleSlides.GetExampleSlide14Lesson2();

            var beginabbOfEindingbaab = PracticumLes1Voorbeelden.BeginabbOfEindingbaab();
            var evenbOnevena = PracticumLes1Voorbeelden.EvenbOnevena();
            var evenbEindigaab = PracticumLes1Voorbeelden.EvenbEindigaab();
            var beginabbBevatbaab = PracticumLes1Voorbeelden.BeginabbBevatbaab();

            DotFileGenerator dotFileGenerator = new DotFileGenerator();
            dotFileGenerator.WriteToDotFile(slide1, "slide1", "", true);
            dotFileGenerator.WriteToDotFile(slide1, "slide2", "", true);
            dotFileGenerator.WriteToDotFile(beginabbOfEindingbaab, "BeginabbOfEindingbaab", "", true);
            dotFileGenerator.WriteToDotFile(evenbOnevena, "EvenbOnevena", "", true);
            dotFileGenerator.WriteToDotFile(evenbEindigaab, "EvenbEindigaab", "", true);
            dotFileGenerator.WriteToDotFile(beginabbBevatbaab, "BeginabbBevatbaab", "", true);
        }
    }
}
