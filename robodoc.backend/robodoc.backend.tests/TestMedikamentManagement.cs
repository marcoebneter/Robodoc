using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentAssertions;
using Moq;
using robodoc.backend.Common;
using robodoc.backend.Common.Mapper;
using robodoc.backend.Controllers;
using robodoc.backend.Controllers.DTO;
using robodoc.backend.Services;
using robodoc.backend.Services.Interfaces;
using Robodoc.Data.Models;
using Xunit;

namespace robodoc.backend.tests
{
    public class TestMedikamentManagement
    {
        private readonly Mock<IRepository<Medikament>> _mock;
        private readonly IMedikamentService _service;
        private readonly IMapper _mapper;
        private readonly IEnumerable<Medikament> _medikaments;

        public TestMedikamentManagement()
        {
            _medikaments = new List<Medikament>()
            {
                new Medikament()
                {
                    Id = Guid.NewGuid(),
                    Name = "Antibiotika",
                    Einheit = Einheiten.Tabletten,
                }
            };

            _mapper = new Mapper(new MapperConfiguration(conf => conf.AddProfile(typeof(MedikamentMapper))));
            _mock = new Mock<IRepository<Medikament>>();
            _mock.Setup(m => m.GetAll()).Returns(_medikaments);
            _mock.Setup(m => m.Get(It.IsNotNull<Guid>())).Returns(_medikaments);
            _mock.Setup(m => m.Insert(It.IsAny<Medikament>()));
            _mock.Setup(m => m.Delete(It.IsAny<Guid>()));
            _service = new MedikamentService(_mock.Object);
        }

        [Fact]
        public void GetAll()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            var result = controller.Get();

            // assert
            result.Should().NotBeEmpty().And.BeEquivalentTo(_medikaments, o => o.ExcludingMissingMembers());
        }

        [Fact]
        public void Get()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            var result = controller.Get(_medikaments.First().Id);

            // assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public void Insert()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);
            var newMedi = new MedikamentDTO()
            {
                Id = Guid.NewGuid(),
                Name = "TestMedi",
                Einheit = Einheiten.Kapseln.ToString(),
            };

            // act
            var result = controller.Post(newMedi);

            // assert
            _mock.Verify(m => m.Insert(It.IsAny<Medikament>()));
        }

        [Fact]
        public void Delete()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            controller.Delete(_medikaments.First().Id);

            // assert
            _mock.Verify(m => m.Delete(It.IsAny<Guid>()));

        }
    }
}
