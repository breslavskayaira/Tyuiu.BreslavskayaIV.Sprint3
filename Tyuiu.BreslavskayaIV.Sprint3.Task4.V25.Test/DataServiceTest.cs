﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BreslavskayaIV.Sprint3.Task4.V25.Lib;

namespace Tyuiu.BreslavskayaIV.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 44.313;
            Assert.AreEqual(wait, res);
        }
    }
}
