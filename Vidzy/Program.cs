using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();
            //context.AddVideo("Pagal Nilavu", DateTime.Parse("1980/9/21"), "Family");
            //context.AddVideo("Nayagan", DateTime.Parse("1987/4/11"), "Family");
            //context.AddVideo("Thalapathi", DateTime.Parse("1990/2/9"), "Action");
            //context.AddVideo("Roja", DateTime.Parse("1992/8/15"), "Thriller");
            //context.AddVideo("Aval", DateTime.Parse("2018/5/19"), "Horror");
            //context.AddVideo("Thillumullu", DateTime.Parse("1983/11/14"), "Comedy");
            context.AddVideo("Panchathanthiram", DateTime.Parse("2002/8/15"), "Comedy", (byte)Classification.Platinum);
            context.AddVideo("Ratchasan", DateTime.Parse("2018/4/14"), "Thriller", (byte)Classification.Gold);
        }
    }
}
