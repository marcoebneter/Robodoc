using System;
using System.Collections.Generic;
using System.Linq;
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

            _mapper = new Mapper(new MapperConfiguration(conf => conf.AddProfile(typeof(Medikament))));
            _mock = new Mock<IRepository<Medikament>>();
            _mock.Setup(m => m.GetAll()).Returns(_medikaments);
            _mock.Setup(m => m.Get(It.IsNotNull<Guid>())).Returns(_medikaments);
            _mock.Setup(m => m.Insert(It.IsAny<Medikament>()));
            _mock.Setup(m => m.Delete(It.IsAny<Guid>()));
            _mock.Setup(m => m.Update(It.IsAny<Medikament>()));
            _service = new MedikamentService(_mock.Object);
        }

        [Fact]
        public void TestMedGetAll()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            var result = controller.Get();

            // assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public void TestMedGet()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            var result = controller.Get(_medikaments.First().Id);

            // assert
            result.Should().NotBeEmpty();
        }

        [Fact]
        public void TestMedInsert()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);
            var newMedi = new Medikament()
            {
                Id = Guid.NewGuid(),
                Name = "TestMedi",
                Einheit = Einheiten.Kapseln,
                Verabreichungsprozess = Verabreichungsprozesse.oral
            };

            // act
            var result = controller.Post(newMedi);

            // assert
            _mock.Verify(m => m.Insert(It.IsAny<Medikament>()));
        }

        [Fact]
        public void TestMedDelete()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);

            // act
            controller.Delete(_medikaments.First().Id);

            // assert
            _mock.Verify(m => m.Delete(It.IsAny<Guid>()));
        }

        [Fact]
        public void TestMedUpdate()
        {
            // arrange
            var controller = new MedikamentController(_service, _mapper);
            _medikaments.First().Name = "Update";

            // act
            controller.Put(_medikaments.First().Id, _medikaments.First());

            // assert
            _mock.Verify(m => m.Update(It.IsAny<Medikament>()));
        }
    }
}
