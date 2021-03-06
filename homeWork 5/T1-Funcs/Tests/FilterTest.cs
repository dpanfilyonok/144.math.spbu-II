using System;
using System.Collections.Generic;
using Xunit;
using FuncsLib;

namespace Tests
{
    public static class FilterTestData
    {
        private static readonly List<object[]> _data = new List<object[]>
        {   // TEST OF
            // correct behavior with int
            new object[] {
                new List<int>() {1, 2, 3},
                new Predicate<int>(num => num % 2 == 0),
                new List<int>() {2},
            },

            // int?
            new object[] {
                new List<int?>() {1, 2, null, 3, null, null, 4},
                new Predicate<int?>(elem => elem.HasValue),
                new List<int?>() {1, 2, 3, 4},
            },
            
            // empty list 
            new object[] {
                new List<int>() {},
                new Predicate<int>(x => x == 1),
                new List<int>() {},
            },
        };
        
        public static IEnumerable<object[]> TestData => _data;
    }

    public class FilterTest
    {
        [Theory]
        [MemberData("TestData", MemberType = typeof(FilterTestData))]
        public void FilterDataDrivenTest<T>(List<T> list, Predicate<T> predicate, List<T> expected)
        {
            var actual = Funcs.Filter<T>(list, predicate);

            Assert.Equal(expected, actual);
        }
    }
}