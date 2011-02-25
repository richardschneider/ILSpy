using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICSharpCode.Decompiler
{
    /// <summary>
    ///   continue statements are inserted at end of block; they are not needed.
    /// </summary>
    [TestClass]
    public class Issue32 : DecompilerTest
    {
        public class Sample
        {
            public void ArrayLoop(string[] list) 
            {
                foreach (string s in list)
                {
                    s.ToLower();
                }
            }

            public void ListLoop(List<string> list)
            {
                foreach (string s in list)
                {
                    s.ToLower();
                }
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Assert.AreEqual("private void Call1(){this.Foo((Issue27.Sample)null);}", DecompileMethod(typeof(Sample), "Call1"));

        }
    }
}
