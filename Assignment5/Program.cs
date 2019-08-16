/* Created By:      George Zhou
 * Student Number:  300613283
 * Date Last Modified: August 16, 2019
 * This program gets database from store and lets customer choose their order, and proceed to save, load, and place their order
 * Revision:        1.1
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

            //Initiate a new dictionary of Form Names
            Forms = new Dictionary<FormNames, Form>();

            //Add the Various forms into the dictionary
            Forms.Add(FormNames.SPLASH_SCREEN, new Views.SplashScreen());
            Forms.Add(FormNames.START_FORM, new Views.StartForm());
            Forms.Add(FormNames.SELECT_FORM, new Views.SelectForm());
            Forms.Add(FormNames.PRODUCTINFO_FORM, new Views.ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new Views.OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new Views.AboutForm());

            //Initiate a new Product
            product = new Product();

            Application.Run(Forms[FormNames.SPLASH_SCREEN]);

        }
    }
}
