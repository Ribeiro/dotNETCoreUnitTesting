using dotNETCore_xUnit_FluentAssertions_Example.exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNETCore_xUnit_FluentAssertions_Example
{
    public class Hello
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public Hello(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string HelloMan()
        {
            if (string.IsNullOrEmpty(_firstName))
                throw new MissingFirstNameException();

            return $"Hello {_firstName} {_lastName} !";
        }

        public string Your()
        {
            return $"Hello {_firstName} {_lastName} !";
        }
    }
}
