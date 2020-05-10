using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.InterfacesFolder
{
    interface IKeyboardFull
    {
        void CheckIfUpper(char oldValue, out char value);
        void btnUnderscore_Click(object sender, EventArgs e);
        void btn1_Click(object sender, EventArgs e);
        void btn2_Click(object sender, EventArgs e);
        void btn3_Click(object sender, EventArgs e);
        void btn4_Click(object sender, EventArgs e);
        void btn5_Click(object sender, EventArgs e);
        void btn6_Click(object sender, EventArgs e);
        void btn7_Click(object sender, EventArgs e);
        void btn8_Click(object sender, EventArgs e);
        void btn9_Click(object sender, EventArgs e);
        void btn0_Click(object sender, EventArgs e);
    }
}
