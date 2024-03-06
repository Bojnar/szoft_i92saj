using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh1_gyak
{
    internal class VillogóGomb: Button
    {
        public VillogóGomb()
        {
            MouseEnter += VillogóGomb_MouseEnter;
        }

        private void VillogóGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
