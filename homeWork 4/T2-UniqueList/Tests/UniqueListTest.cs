using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exceptions;
using LinkedList;
using UList;
using System;

namespace Tests
{
    [TestClass]
    public class UniqueListTest
    {
        private ILinkedList _uList;

        [TestInitialize]
        public void Init()
        {
            _uList = new UniqueList();
        }

        [TestMethod]
        [ExpectedException(typeof(ValueAlreadyInListException))]
        public void AppendExistedShouldThrowException()
        {
            _uList.Append(1);

            _uList.Append(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ValueAlreadyInListException))]
        public void AddToBeginExistedShouldThrowException()
        {
            _uList.AddToBegin(1);

            _uList.AddToBegin(1);
        }

        [TestMethod]
        [ExpectedException(typeof(ValueAlreadyInListException))]
        public void InsertExistedShouldThrowException()
        {
            _uList.Append(1);
            _uList.Append(2);
            _uList.Append(3);

            _uList.Insert(3, 0);
        }
    }
}
