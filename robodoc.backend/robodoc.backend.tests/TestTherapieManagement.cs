using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
    public class TestTherapieManagement
    {
        private readonly Mock<IRepository<Therapie>> _mock;
        private readonly IMapper _mapper;
        private readonly ITherapieService _service;
        private readonly IEnumerable<Therapie> _therapies;
        public TestTherapieManagement()
        {
            _therapies = new List<Therapie>()
            {
                new Therapie()
                {
                    Id = Guid.NewGuid(),
                    Name = "Diät"
                }
            };
            _mock = new Mock<IRepository<Therapie>>();
            _mock.Setup(m => m.GetAll()).Returns(_therapies);
            _mock.Setup(m => m.Get(It.IsNotNull<Guid>())).Returns(_therapies);
            _service = new TherapieService(_mock.Object);
        }

        [Fact]
        public void TestTherapieGetAll()
        {
            // arrange
            var controller = new TherapieController(_service, _mapper);

            // act
            var result = controller.Get();

            // assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public void TestTherapieGet()
        {
            // arrange
            var controller = new TherapieController(_service, _mapper);

            // act
            var result = controller.Get(_therapies.First().Id);

            // assert
            result.Should().NotBeEmpty();

        }
    }
}
