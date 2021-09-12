using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Test_GiamGia
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {

        }

        [TestMethod]
        public void TC_MucGiamNull()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string mucgiam = "";
            string ngayapdung = "6/8/2021";

            this.UIMap.TestGiamGiaParams.UICboPercentComboBoxValueAsString = mucgiam.ToString();
            this.UIMap.TestGiamGiaParams.UIDateDateTimeEditValueAsString = ngayapdung.ToString();

            this.UIMap.TestGiamGia();
            this.UIMap.Assert_MucGiamNull();

        }


        [TestMethod]
        public void TC_MucGiamNhoHon0()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string mucgiam = "-2";
            string ngayapdung = "6/8/2021";

            this.UIMap.TestGiamGiaParams.UICboPercentComboBoxValueAsString = mucgiam.ToString();
            this.UIMap.TestGiamGiaParams.UIDateDateTimeEditValueAsString = ngayapdung.ToString();

            this.UIMap.TestGiamGia();
            this.UIMap.Assert_MucGiamNhoHon0();

        }

        [TestMethod]
        public void TC_DuLieuFull()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            string mucgiam = "10";
            string ngayapdung = "6/21/2021";

            this.UIMap.TestGiamGiaParams.UICboPercentComboBoxValueAsString = mucgiam.ToString();
            this.UIMap.TestGiamGiaParams.UIDateDateTimeEditValueAsString = ngayapdung.ToString();

            this.UIMap.TestGiamGia();
            this.UIMap.Assert_DuLieuFull();
          
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
