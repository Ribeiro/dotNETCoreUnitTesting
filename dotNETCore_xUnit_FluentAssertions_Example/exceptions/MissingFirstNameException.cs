using System;
using System.Collections.Generic;
using System.Text;

namespace dotNETCore_xUnit_FluentAssertions_Example.exceptions
{
    public class MissingFirstNameException : Exception
    {
        public MissingFirstNameException() : base("FirstName is missing")
        {
        }
    }
}
