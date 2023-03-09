using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Men score");
            ScoringBase scoringBase1=new MenScoring();
            ScoringBase scoringBase2 = new WomenScroing();
            Console.WriteLine("{0}",scoringBase1.CalculateAll(8,new TimeSpan(0,4,34)));
            Console.WriteLine("Women score");
            Console.WriteLine("{0}", scoringBase2.CalculateAll(8, new TimeSpan(0, 4, 34)));
            Console.ReadLine();
        }
    }

    abstract class ScoringBase
    {
        public abstract int CalculateScore(int hits);
        public abstract int CalculateReduction(TimeSpan timeSpan);

        public int CalculateAll(int hits,TimeSpan timeSpan)
        {
            return CalculateScore(hits) - CalculateReduction(timeSpan);
        }
    }

    class MenScoring : ScoringBase
    {
        public override int CalculateReduction(TimeSpan timeSpan)
        {
            return (int)timeSpan.Seconds;
        }

        public override int CalculateScore(int hits)
        {
            return hits * 100;
        }
    }

    class WomenScroing : ScoringBase
    {
        public override int CalculateReduction(TimeSpan timeSpan)
        {
            return (int)timeSpan.Seconds;
        }

        public override int CalculateScore(int hits)
        {
            return hits * 80;
        }
    }
}
