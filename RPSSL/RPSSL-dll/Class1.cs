using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL_dll
{
    public class RPSSL_dll
    {
        public static string Spielablauf(string meldung, int wert)
        {
            Random rnd = new Random();
            int gegner = rnd.Next(1, 6);
            if (wert == 1 && gegner == 1 || wert == 2 && gegner == 2 || wert == 3 && gegner == 3 || wert == 4 && gegner == 4 || wert == 5 && gegner == 5)
            {
                meldung = "Unentschieden";
            }
            if (wert == 1 && gegner == 5 || wert == 1 && gegner == 3 || wert == 2 && gegner == 1 || wert == 2 && gegner == 4 || wert == 3 && gegner == 2 || wert == 3 && gegner == 5 || wert == 4 && gegner == 3 || wert == 4 && gegner == 1 || wert == 5 && gegner == 2 || wert == 5 && gegner == 4)
            {
                meldung = "Gewonnen";
            }
            if (wert == 5 && gegner == 1 || wert == 3 && gegner == 1 || wert == 1 && gegner == 2 || wert == 4 && gegner == 2 || wert == 2 && gegner == 3 || wert == 5 && gegner == 3 || wert == 3 && gegner == 4 || wert == 1 && gegner == 4 || wert == 2 && gegner == 5 || wert == 4 && gegner == 5)
            {
                meldung = "Verloren";
            }
            return meldung;
        }

        //Patrick sein Zeugs
        //private void pbx_robot(object sender, EventArgs e)
        //{
        //    int wert = 1;
        //    RPSSL_dll.Spielablauf(string meldung, int wert);
        //}
        //private void pbx_pirate(object sender, EventArgs e)
        //{
        //    int wert = 2;
        //    RPSSL_dll.Spielablauf(string meldung, int wert);
        //}
        //private void pbx_ninja(object sender, EventArgs e)
        //{
        //    int wert = 3;
        //    RPSSL_dll.Spielablauf(string meldung, int wert);
        //}
        //private void pbx_monkey(object sender, EventArgs e)
        //{
        //    int wert = 4;
        //    RPSSL_dll.Spielablauf(string meldung, int wert);
        //}
        //private void pbx_zombie(object sender, EventArgs e)
        //{
        //    int wert = 5;
        //    RPSSL_dll.Spielablauf(string meldung, int wert);
        //}

    }
}
