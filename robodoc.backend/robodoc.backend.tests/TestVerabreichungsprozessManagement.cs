using System;
using System.Collections.Generic;
using FluentAssertions;
using Moq;
using robodoc.backend.Common;
using robodoc.backend.Controllers;
using robodoc.backend.Services;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;
using Xunit;

namespace robodoc.backend.tests
{
    public class TestVerabreichungsprozessManagement
    {
        private readonly Mock<IRepository<Verabreichungsprozess>> _mock;
        private readonly IVerabreichungsprozessService _service;
        private readonly IEnumerable<Verabreichungsprozess> _verabreichungsprozess;
        private readonly Guid _guid;

        public TestVerabreichungsprozessManagement()
        {
            _guid = Guid.NewGuid();
            _verabreichungsprozess = new List<Verabreichungsprozess>()
            {
                new Verabreichungsprozess()
                {
                    Id = _guid,
                    Name = "testVerabreichung"
                }
            };

            _mock = new Mock<IRepository<Verabreichungsprozess>>();
            _mock.Setup(m => m.GetAll()).Returns(_verabreichungsprozess);
            _mock.Setup(m => m.Get(It.IsNotNull<Guid>())).Returns(_verabreichungsprozess);
            _service = new VerabreichungsprozessService(_mock.Object);
        }

        [Fact]
        public void GetAll()
        {
            // arrange
            var controller = new VerabreichungsprozessController(_service);

            // act
            var result = controller.Get();

            // assert
            result.Should().NotBeEmpty().And.BeEquivalentTo(_verabreichungsprozess, o => o.ExcludingMissingMembers());
        }

        [Fact]
        public void Get()
        {
            // arrange
            var controller = new VerabreichungsprozessController(_service);

            // act
            var result = controller.Get(_guid);

            // assert
            result.Should().NotBeEmpty();
        }
    }
}