using dotNETCore_xUnit_FluentAssertions_Example;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using dotNETCore_xUnit_FluentAssertions_Example.exceptions;

namespace dotNETCore_xUnit_FluentAssertions_Example_Test.model
{
    public class HelloTest
    {
        [Fact]
        public void HelloManShouldBeWellFormated()
        {
            // Arrange
            var hello = new Hello("John", "Doe");

            //Act
            var helloMan = hello.HelloMan();

            //Assert
            helloMan
            .Should()
            .StartWith("Hello")
            .And
            .EndWith("!")
            .And
            .Contain("John")
            .And
            .Contain("Doe");
        }

        [Fact]
        public void HelloManShouldBeRaiseExceptionWhenFirstNameIsNotSet()
        {
            // Arrange
            var hello = new Hello("", "Doe");

            //Act
            Action actionHelloMan = () => hello.HelloMan();

            //Assert
            actionHelloMan
            .Should()
            .Throw<MissingFirstNameException>()
            .WithMessage("FirstName is missing");
        }

    }
}
