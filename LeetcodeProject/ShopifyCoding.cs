using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class ShopifyCoding
    {
        public static void FindLocation(Dictionary<string, int> input)
        {


            Dictionary<char, List<Stock>> dict = new Dictionary<char, List<Stock>>();

            var lstJ = new List<Stock>();
            lstJ.Add(new Stock()
            {
                Location = "G",
                qtn = 10
            });

            lstJ.Add(new Stock()
            {
                Location = "F",
                qtn = 15
            });

            lstJ.Add(new Stock()
            {
                Location = "N",
                qtn = 7
            });
            dict.Add('J', lstJ);

            var lstH = new List<Stock>();
            lstH.Add(new Stock()
            {
                Location = "G",
                qtn = 12
            });

            lstH.Add(new Stock()
            {
                Location = "F",
                qtn = 10
            });

            lstH.Add(new Stock()
            {
                Location = "N",
                qtn = 5
            });
            dict.Add('H', lstH);


            var lstS = new List<Stock>();
            lstS.Add(new Stock()
            {
                Location = "G",
                qtn = 5
            });

            lstS.Add(new Stock()
            {
                Location = "F",
                qtn = 2
            });

            lstS.Add(new Stock()
            {
                Location = "N",
                qtn = 2
            });
            dict.Add('S', lstS);

            input.TryGetValue("J", out int jquet);
            input.TryGetValue("H", out int hquet);
            input.TryGetValue("S", out int squet);

            if (dict['J'].Where(s => s.qtn >= jquet).Count() > 0 && dict['H'].Where(s => s.qtn >= hquet).Count() > 0 && dict['S'].Where(s => s.qtn >= squet).Count() > 0)
            {
                var lst = new List<string>();
               
                
                lst.AddRange(dict['J'].Where(s => s.qtn >= jquet).Select(s => s.Location).Distinct());
                lst.AddRange(dict['H'].Where(s => s.qtn >= hquet).Select(s => s.Location).Distinct());
                lst.AddRange(dict['S'].Where(s => s.qtn >= squet).Select(s => s.Location).Distinct());

                foreach (var s in lst.Distinct())
                {
                    Console.WriteLine(s);
                }
            }
            //var lst = new List<Invetory>();
            //lst.Add(new Invetory()
            //{
            //    Location = "V",
            //    J = 10,
            //    H = 5,
            //    S = 1

            //});
            //    foreach (var l in lst)
            //    {
            //        input.TryGetValue("J", out int jquet);
            //        input.TryGetValue("H", out int hquet);
            //        input.TryGetValue("S", out int squet);

            //        if (jquet <= l.J && hquet <= l.H && squet <= l.S)
            //            Console.WriteLine(l.Location);


            //    }
            //}
        }
    }
        public class Invetory
    {
        public string Location { get; set; }
        public int H { get; set; }
        public int J { get; set; }
        public int S { get; set; }
    }

    public class Stock { 
        public string Location { get; set; }
        public int qtn { get; set; }
    }
}
