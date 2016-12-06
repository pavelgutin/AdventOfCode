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
    public class Day06Tests
    {
        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void DecodeCorruptedMessagePart1Test1()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\day06simple.txt").Replace("\r", "");

            Assert.AreEqual("easter", Day06.DecodeCorruptedMessagePart1(testData.Split('\n').ToList()));
        }

        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void DecodeCorruptedMessagePart1Test2()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\day06hard.txt").Replace("\r", "");

            Assert.AreEqual("nabgqlcw", Day06.DecodeCorruptedMessagePart1(testData.Split('\n').ToList()));
        }

        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void DecodeCorruptedMessagePart2Test1()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\day06simple.txt").Replace("\r", "");

            Assert.AreEqual("advent", Day06.DecodeCorruptedMessagePart2(testData.Split('\n').ToList()));
        }

        [TestMethod()]
        [DeploymentItem(@"Inputs\", "Inputs")]
        public void DecodeCorruptedMessagePart2Test2()
        {
            string testData = System.IO.File.ReadAllText(@"Inputs\day06hard.txt").Replace("\r", "");

            Assert.AreEqual("ovtrjcjh", Day06.DecodeCorruptedMessagePart2(testData.Split('\n').ToList()));
        }
    }


}