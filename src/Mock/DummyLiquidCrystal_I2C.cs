using System;

namespace LCDLibrary.Mock
{
    public class DummyLiquidCrystal_I2C : ILiquidCrystal_I2C
    {
        public void ClearLCD()
        {

        }

        public void CursorLine(int line)
        {

        }

        public void DelayMicroseconds(int secs)
        {

        }

        public void PrintLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
