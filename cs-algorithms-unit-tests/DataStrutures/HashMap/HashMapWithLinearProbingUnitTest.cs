﻿using System.Reflection.PortableExecutable;
using Algorithms.DataStructures.HashMap;
using Algorithms.DataStructures.TreeMap;
using Xunit;
using Xunit.Abstractions;

namespace AlgorithmsUnitTest.DataStrutures.TreeMap
{
    public class HashMapWithLinearProbingUnitTest
    {
        private ITestOutputHelper console;
        public HashMapWithLinearProbingUnitTest(ITestOutputHelper console)
        {
            this.console = console;
        }

        [Fact]
        public void TestHashMap()
        {
            var map = new HashMapWithLinearProbing<int, int>();
            Assert.True(map.IsEmpty);
            map[1] = 1;
            Assert.Equal(1, map[1]);
            map[2] = 2;
            Assert.Equal(2, map[2]);
            Assert.Equal(2, map.Count);

            map.Delete(2);
            Assert.Equal(1, map.Count);
            Assert.True(map.ContainsKey(1));
            Assert.False(map.ContainsKey(2));
            Assert.False(map.IsEmpty);

            foreach(var key in map.Keys)
            {
                console.WriteLine("{0}", key);
            }
        }
    }
}