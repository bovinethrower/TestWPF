using TestWPF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Markup;
using System.Windows;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ContactDetailWindowTest and is intended
    ///to contain all ContactDetailWindowTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContactDetailWindowTest
    {


        private TestContext testContextInstance;

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

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ContactDetailWindow Constructor
        ///</summary>
        [TestMethod()]
        public void ContactDetailWindowConstructorTest()
        {
            ContactDetailWindow.Mode m = new ContactDetailWindow.Mode(); // TODO: Initialize to an appropriate value
            Contact c = null; // TODO: Initialize to an appropriate value
            ContactDetailWindow target = new ContactDetailWindow(m, c);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ContactDetailWindow Constructor
        ///</summary>
        [TestMethod()]
        public void ContactDetailWindowConstructorTest1()
        {
            ContactDetailWindow target = new ContactDetailWindow();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        public void InitializeComponentTest()
        {
            ContactDetailWindow target = new ContactDetailWindow(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for System.Windows.Markup.IComponentConnector.Connect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestWPF.exe")]
        public void ConnectTest()
        {
            IComponentConnector target = new ContactDetailWindow(); // TODO: Initialize to an appropriate value
            int connectionId = 0; // TODO: Initialize to an appropriate value
            object target1 = null; // TODO: Initialize to an appropriate value
            target.Connect(connectionId, target1);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for cancelButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestWPF.exe")]
        public void cancelButton_ClickTest()
        {
            ContactDetailWindow_Accessor target = new ContactDetailWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.cancelButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for okButton_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TestWPF.exe")]
        public void okButton_ClickTest()
        {
            ContactDetailWindow_Accessor target = new ContactDetailWindow_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            RoutedEventArgs e = null; // TODO: Initialize to an appropriate value
            target.okButton_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
