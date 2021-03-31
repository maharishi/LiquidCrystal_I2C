**Liquid Display I2C library for 16x2 or 20x4 for Raspberry Pi**

[![Whats-App-Image-2021-03-31-at-10-01-42-AM.jpg](https://i.postimg.cc/yYn6FGgJ/Whats-App-Image-2021-03-31-at-10-01-42-AM.jpg)](https://postimg.cc/1fnZSJKP)


__Sample Code__
```csharp
using System;
using LCDLibrary;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace lcdtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Pi.Init<BootstrapWiringPi>(); //Boot strap the WiringPi 
            Pi.I2C.AddDevice(0x3f); //Add the I2C device address
            ILiquidCrystal_I2C lcd = new LiquidCrystal_I2C((I2CDevice)Pi.I2C.Devices[0]); //Initialize the LiquidCrystal obj
            lcd.CursorLine(LiquidCrystal_I2C.LINE1); //Navigate to Line 1
            lcd.PrintLine("Hello World"); // Print String
            lcd.ClearLCD(); //Clear the LCD Screen
        }
    }
}
```