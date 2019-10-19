using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public static class RandomGenerator
    {
        public static string GenerateEmail()
        {
            return $"{Guid.NewGuid().ToString().Substring(0, 6)}@gmail.com";
        }
    }
}
