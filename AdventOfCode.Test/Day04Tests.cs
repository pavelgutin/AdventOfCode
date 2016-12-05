﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Tests
{
    [TestClass()]
    public class Day04Tests
    {
        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void SumOfSectorIdsShortTest()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\shortListOfRooms.txt");

            Assert.AreEqual(1514, Day04.SumOfSectorIds(testData.Split('\n').ToList()));
        }

        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void SumOfSectorIdsTest()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\listOfRooms.txt");

            Assert.AreEqual(158835, Day04.SumOfSectorIds(testData.Split('\n').ToList()));
        }


        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void NorthPoleObjectStorageTest()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\listOfRooms.txt");

            Assert.AreEqual(993, Day04.SectorOfNorthPoleObjectStorage(testData.Split('\n').ToList()));
        }
    }
}