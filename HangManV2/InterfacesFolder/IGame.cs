using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.InterfacesFolder
{
    interface IGame
    {
        void ShowNextPic();
        void CheckIfWon();
        void CheckIfLost();
        void UpdateWord();
    }
}
