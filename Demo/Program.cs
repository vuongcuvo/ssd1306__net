#define FT2232H

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using FTD2XX_NET;


namespace Demo
{
    class Program
    {
        static Oled oled = new Oled();
        static void Main(string[] args)
        {
            oled.ssd1306_clear_screen(0x00);

            oled.ssd1306_refresh_gram();

            Timer timer1 = new Timer(1000);
            timer1.Elapsed += Timer1_Elapsed;
            timer1.AutoReset = true;
            timer1.Enabled = true;

            Console.ReadLine();
        }

        private static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            oled.ssd1306_display_string(24, 0, e.SignalTime.ToLongTimeString(), 16, 1);
            oled.ssd1306_refresh_gram();
        }
    }
}
