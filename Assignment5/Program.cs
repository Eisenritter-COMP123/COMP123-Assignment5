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
using Assignment5.Views;
using Assignment5.Models;

namespace Assignment5
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_SCREEN, new Views.SplashScreen());
            Forms.Add(FormNames.START_FORM, new Views.StartForm());
            Forms.Add(FormNames.SELECT_FORM, new Views.SelectForm());
            Forms.Add(FormNames.PRODUCTINFO_FORM, new Views.ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new Views.OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new Views.AboutForm());

            product = new Product();

            Application.Run(Forms[FormNames.SPLASH_SCREEN]);
        }
    }
}
