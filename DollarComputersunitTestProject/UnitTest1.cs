using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment5;
using Assignment5.Views;

namespace DollarComputersunitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            SelectForm selectForm;

            //act
            selectForm = new SelectForm();
            selectForm.ShowInTaskbar = false;
            selectForm.ShowDialog();

            //assert
            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }

        [TestMethod]
        public void TestThatSelectLabelDisplaysItemSelected()
        {
            // arrange
            SelectForm selectForm;

            //act
            selectForm.

            //assert
            Assert.AreEqual("Hello World Item", selectForm.SelectLabel.Text);
        }
    }
}
