using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFx
{
    public static class EnhancedRandom
    {
        public static bool RandomBool()
        {
            var rnd = new Random();
            var yuh = rnd.Next(0, 2);
            return yuh == 1;
        }

        public static string RandomWords(int count)
        {
            var sb = new StringBuilder();
            var seed = new Random();
            for (var i = 0; i <= count; i++)
            {
                sb.Append(Words[seed.Next(1, Words.Length)] + " ");
            }
            return sb.ToString();
        }

        private static string[] Words =
        {
            "abacus", "beach", "corpulent", "dromedary", "eclipse", "flames", "giraffe", "hat", "ink", "jumping",
            "kitsch", "lampshade", "monument", "ne'er-do-well", "octopus", "pineapple",
            "quorum", "resurrection", "satisfied", "turbulence", "unify", "viable", "walk", "x-ray", "yams", "zydeco",
            "attenuation", "biscuits", "crochet", "deleterious", "euphonium", "fragile", "gubernatorial", "hijack",
            "importance", "judicious", "kibbutz", "languish", "monotone", "nope", "orienteering", "quail", "risotto",
            "squeegee", "trampoline", "utilitarianism", "visceral", "wallbanger", "xenophobia", "yolo", "zoroastrianism"
        };

    }

}



