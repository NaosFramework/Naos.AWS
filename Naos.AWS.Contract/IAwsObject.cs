﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAwsObject.cs" company="Naos">
//   Copyright 2015 Naos
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.AWS.Contract
{
    /// <summary>
    /// Interface on all AWS objects.
    /// </summary>
    public interface IAwsObject : IHaveName, IHaveId, IHaveRegion
    {
    }
}
