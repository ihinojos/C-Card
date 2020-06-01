using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Card
{
    class Data
    {
        public static string cn = @"Server=INTLGXCUU24\INTELOGIX;Initial Catalog=TESTTRANS;MultipleActiveResultSets=true;Persist Security Info=True;User ID=Intelogix;Password=Intelogix20XX!";
        public static List<string> accountType { get; set; }
        public static List<string> entities { get; set; }
        public static List<string> jobs { get; set; }
        public static List<string> classes { get; set; }

        public static void getData()
        {
            accountType = new List<string>(Properties.Resources.QBAT.Split(new char[] { ',' }));
            entities = new List<string>(Properties.Resources.ENTITIES.Split(new char[] { ',' }));
            jobs = new List<string>(Properties.Resources.JOBS.Split(new char[] {','}));
            classes = new List<string>(Properties.Resources.CLASS.Split(new char[] {','}));
        }
    }
}
