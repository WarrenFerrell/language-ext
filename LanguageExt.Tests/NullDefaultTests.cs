﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static LanguageExt.Prelude;

namespace LanguageExt.Tests
{
    public class NullDefaultTests
    {
        [Fact]
        public void IsDefaultTests()
        {
            string x = null;
            string y = "hello";
            int z = 0;
            int w = 100;

            Assert.True(x.IsDefault());
            Assert.True(isDefault(x));

            Assert.False(y.IsDefault());
            Assert.False(isDefault(y));

            Assert.True(z.IsDefault());
            Assert.True(isDefault(z));

            Assert.False(w.IsDefault());
            Assert.False(isDefault(w));
        }

        [Fact]
        public void NotDefaultTests()
        {
            string x = null;
            string y = "hello";
            int z = 0;
            int w = 100;

            Assert.False(notDefault(x));

            Assert.True(notDefault(y));

            Assert.False(notDefault(z));

            Assert.True(notDefault(w));
        }
    }
}
