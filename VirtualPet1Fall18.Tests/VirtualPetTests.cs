using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet1Fall18.Tests
{
    [TestFixture]
    class VirtualPetTests
    {
        VirtualPet sut;

        [SetUp]
        public void Test_Setup()
        {
            sut = new VirtualPet();
        }

        [Test]
        public void Should_Set_Hunger_Property()
        {
            sut.Hunger = 20;
            int result = sut.Hunger;

            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Should_Set_Fatigue_Property()
        {
            sut.Fatigue = 40;
            int result = sut.Fatigue;

            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void Should_Set_Health_Property()
        {
            sut.Health = 60;
            int result = sut.Health;

            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void Should_Call_FeedMe_And_Decrease_Hunger()
        {
            sut.Hunger = 20;
            sut.FeedMe();

            Assert.That(sut.Hunger, Is.LessThan(20));
        }

        [Test]
        public void Should_Call_FeedMe_And_Increase_Fatigue()
        {
            sut.Fatigue = 20;
            sut.FeedMe();

            Assert.That(sut.Fatigue, Is.GreaterThan(20));
        }

        [Test]
        public void Should_Call_ExerciseMe_And_Increase_Hunger()
        {
            sut.Hunger = 20;
            sut.ExerciseMe();

            Assert.That(sut.Hunger, Is.GreaterThan(20));
        }

        [Test]
        public void Should_Call_ExerciseMe_And_Increase_Health()
        {
            sut.Health = 20;
            sut.ExerciseMe();

            Assert.That(sut.Health, Is.GreaterThan(20));
        }

        [Test]
        public void Should_Call_RestMe_And_Decrease_Fatigue()
        {
            sut.Fatigue = 20;
            sut.RestMe();

            Assert.That(sut.Fatigue, Is.LessThan(20));
        }

        [Test]
        public void Should_Call_RestMe_And_Increase_Health()
        {
            sut.Health = 20;
            sut.RestMe();

            Assert.That(sut.Health, Is.GreaterThan(20));
        }

        [Test]
        public void Should_Set_Default_Property_Values()
        {
            Assert.That(sut.Health, Is.EqualTo(100));
            Assert.That(sut.Hunger, Is.EqualTo(100));
            Assert.That(sut.Fatigue, Is.EqualTo(100));
        }

    }
}
