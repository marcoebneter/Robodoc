using System.Collections.Generic;
using Moq;
using robodoc.backend.Common;
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

        public TestVerabreichungsprozessManagement()
        {
            _mock = new Mock<IRepository<Verabreichungsprozess>>();
            _mock.Setup(m => m.GetAll()).Returns(_verabreichungsprozess);
            _service = new VerabreichungsprozessService(_mock.Object);
        }

        [Fact]
        public void GetAll()
        {
            // arrange
            // act
            // assert
        }
    }
}