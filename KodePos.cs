using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400048
{
    public class KodePos
    {
        private string[] kelurahan =
        {
        "Batununggal",
        "Kujangsari",
        "Mengger",
        "Wates",
        "Cijaura",
        "Jatisari",
        "Margasari",
        "Sekejati",
        "Kebonwaru",
        "Maleer"
    };
        private int[] kodepos =
        {
        40266,
        40287,
        40267,
        40256,
        40287,
        40286,
        40286,
        40286,
        40272,
        40274
    };
        public int getKodePos(string kel)
        {
            for (int i = 0; i < kelurahan.Length; i++)
            {
                if (kelurahan[i].ToLower() == kel.ToLower())
                {
                    return kodepos[i];
                }
            }
            return -1;
        }
    }
}
