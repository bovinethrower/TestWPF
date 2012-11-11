using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestWPF;

namespace TestProject1
{
    [TestClass]
    public class ContactTests
    {
        // add fixture to set up list of contacts

        [TestMethod]
        public void TestToString()
        {
            Contact c1 = new Contact("jim", "bob");
            Assert.AreEqual(c1.ToString(), "jim bob");
        }

        [TestMethod]
        public void TestFullName()
        {
            Contact c1 = new Contact("jim", "bob");
            Assert.AreEqual(c1.FullName, "jim bob");
        }

        // null tests for phone zip

        // validation tests for phone, state, zip

        // update event is fired on edit of any property

        // phone formatting output

        // phone formatting input
    }

    // contactdetailview - set title based on mode
    // set enabled based on mode
    // load contact info

    // button press
    // fake sender info? set selected index to known value, delete 

    // export, import CSV of contacts
}
