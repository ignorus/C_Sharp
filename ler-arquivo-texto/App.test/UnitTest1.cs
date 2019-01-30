using System;
using Xunit;
using App.SRC;

namespace App.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
           Assert.True(new Tentativa().Ola()); 
        }
    }
}
