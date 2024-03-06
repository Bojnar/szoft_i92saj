using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1_gyak
{
    internal class SzamoloGomb: Button
    {
        int szám = 0;

        public SzamoloGomb()
        {
            Width = 20;
            Height = 20;
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (szám < 5)
            {
                szám++;
                base.Text = szám.ToString();
            }
            else
            {
                szám = 1;
                base.Text = szám.ToString();
            }
                

            

        }
    }
}
