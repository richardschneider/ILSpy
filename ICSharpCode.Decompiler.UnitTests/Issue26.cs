using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICSharpCode.Decompiler
{
    /// <summary>
    ///   passing null to a method/constructor that has multiple signatures 
    /// </summary>
    /// <remarks>
    ///   When the method has multiple signatures; such as foo(MyObject o)  and foo(string s), then code calling for with a null argument must have a cast.  
    ///   Currently ILSpy will display foo(null) and it should be foo((string) null)  or foo((MyObject) null).
    ///   
    ///  I found this while looking at the .ctor for System.Xml.Resolvers.XmlPreloadedResolver.
    /// </remarks>
    [TestClass]
    public class Issue26 : DecompilerTest
    {
        public class Sample
        {
            public static int Switch(int i)
            {
                int j;
                switch (i)
                {
                    case 0:
                        {
                            j = i + 1;
                            break;
                        }
                    case 1:
                        {
                            j = i + 2;
                            break;
                        }
                    default:
                        {
                            return -1;
                        }
                }
                return j * 2;
            }
            public static int SwitchNoDefault(int i)
            {
                int j = 0;
                switch (i)
                {
                    case 0:
                        {
                            j = i + 1;
                            break;
                        }
                    case 1:
                        {
                            j = i + 2;
                            break;
                        }
                }
                return j * 2;
            }
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
