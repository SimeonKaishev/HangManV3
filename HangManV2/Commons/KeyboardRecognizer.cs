using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManV2.Commons
{
    abstract class KeyboardRecognizer
    {
        

        public abstract void Backspace();
        public abstract void ButtonClicked(char imput);
        public abstract bool CheckCaps();
        public abstract void ChangeCaps(bool newValue);
        public void RecogniseKeyboard(string imput)
        {
            switch (imput)
            {
                case "D1":
                    ButtonClicked('1');
                    break;
                case "D2":
                    ButtonClicked('2');
                    break;
                case "D3":
                    ButtonClicked('3');
                    break;
                case "D4":
                    ButtonClicked('4');
                    break;
                case "D5":
                    ButtonClicked('5');
                    break;
                case "D6":
                    ButtonClicked('6');
                    break;
                case "D7":
                    ButtonClicked('7');
                    break;
                case "D8":
                    ButtonClicked('8');
                    break;
                case "D9":
                    ButtonClicked('9');
                    break;
                case "D0":
                    ButtonClicked('0');
                    break;
            }
            if (imput == "Space")
            {
                ButtonClicked('_');
            }
            else
            if (imput == "Back")
            {
                Backspace();
            }
            else
            if (imput == "Capital")
            {
                if (CheckCaps())
                {
                    //CapsLock.Checked = true;
                    ChangeCaps(false);
                }
                else
                {
                   // CapsLock.Checked = false;
                    ChangeCaps(true);
                }
            }
            else
            {
                try
                {
                    //imput.ToLower();
                    char keyValue = char.Parse(imput);
                    keyValue = char.ToLower(keyValue);
                    ButtonClicked(keyValue);
                }
                catch (FormatException)
                {

                }
            }
        }
    }
}
