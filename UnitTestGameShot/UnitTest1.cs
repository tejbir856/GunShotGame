using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGameShot
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            {
                GunShotGame.LogicClass test = new GunShotGame.LogicClass();

                int testResult = test.SpinGun();

                Assert.IsTrue(testResult < 7);

            }
        }

         [TestMethod]
        public void TestMethod2()
        {
                GunShotGame.LogicClass test = new GunShotGame.LogicClass();

                int testResult2 = test.FireGun();

                Assert.IsTrue(testResult2 < 4);

            }
        }
    }

