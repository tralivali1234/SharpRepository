﻿using System;
using SharpRepository.InMemoryRepository;
using NUnit.Framework;
using SharpRepository.Tests.Integration.TestObjects;
using Shouldly;

namespace SharpRepository.Tests.Integration.Spikes
{
    [TestFixture]
    public class AspectSpikes
    {
        [Test]
        public void TestObject_Should_Not_Have_MinValue_For_Created_After_Add()
        {
            var repository = new InMemoryRepository<AspectTestObject>();
            var testObject = new AspectTestObject {AspectTestObjectId = 1, Name = "Test 1"};

            testObject.Created.ShouldBe(DateTime.MinValue);

            repository.Add(testObject);

            testObject.Created.ShouldNotBe(DateTime.MinValue);
        }
    }
}
