﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CredentialManager.cs" company="Naos">
//   Copyright 2015 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.AWS.Core
{
    using System;

    using Amazon;
    using Amazon.SecurityToken.Model;

    using Naos.AWS.Contract;

    /// <inheritdoc />
    public class CredentialManager : IManageCredentials
    {
        /// <inheritdoc />
        public CredentialContainer GetSessionToken(
            string region,
            TimeSpan tokenLifespan,
            string accessKey, 
            string secretKey, 
            string virtualMfaDeviceId, 
            string mfaValue)
        {
            var regionEndpoint = RegionEndpoint.GetBySystemName(region);
            var request = new GetSessionTokenRequest()
                              {
                                  DurationSeconds = (int)tokenLifespan.TotalSeconds,
                                  SerialNumber = virtualMfaDeviceId,
                                  TokenCode = mfaValue,
                              };

            using (var client = AWSClientFactory.CreateAmazonSecurityTokenServiceClient(accessKey, secretKey, regionEndpoint))
            {
                var token = client.GetSessionToken(request);
                return new CredentialContainer()
                           {
                               CredentialType = Enums.CredentialType.Token,
                               AccessKeyId = token.Credentials.AccessKeyId,
                               SecretAccessKey = token.Credentials.SecretAccessKey,
                               SessionToken = token.Credentials.SessionToken,
                               Expiration = token.Credentials.Expiration,
                           };
            }
        }
    }
}
