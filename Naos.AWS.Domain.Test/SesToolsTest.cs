﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SesToolsTest.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.AWS.Domain.Test
{
    using Xunit;

    public static class SesToolsTest
    {
        [Fact]
        public static void ConvertSecretKeyToSmtpPassword___Converts___When_called()
        {
            var smtpPassword = SesTools.ConvertSecretKeyToSmtpPassword("YOUR_SECRET_KEY_FROM_IAM_HERE", "us-east-1");
        }
    }
}
