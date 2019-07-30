/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: July 26, 2019
 * This program calculates the user's BMI after user inputs their weight and height
 * Revision:        1.0
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_SCREEN, new SplashScreen());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCTINFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());

            Application.Run(Forms[FormNames.SPLASH_SCREEN]);
        }
    }
}
