namespace LCDLibrary
{
    public interface ILiquidCrystal_I2C
    {
        public void DelayMicroseconds(int secs);
        public void ClearLCD();
        public void CursorLine(int line);
        public void PrintLine(string s);
    }
}