using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamoloGomb
{
    internal class SzamoloGomb : Button
    {
        int szam = 1;
        public SzamoloGomb()
        {
        
            Text = szam.ToString();
            MouseClick += SzamoloGomb_MouseClick;

        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            szam = szam + 1;
            base.Text = szam.ToString();   
        }
    }
}
