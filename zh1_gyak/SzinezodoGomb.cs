using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1_gyak
{
    internal class SzinezodoGomb: Button
    {
        public SzinezodoGomb()
        {
            Width = 50;
            Height = 50;
            MouseClick += SzinezodoGomb_MouseClick;
        }

        private void SzinezodoGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
