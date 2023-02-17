﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.178.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.AWS.Domain.Test
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;

    using global::FakeItEasy;

    using global::Naos.AWS.Domain;
    using global::Naos.Database.Domain;

    using global::OBeautifulCode.AutoFakeItEasy;
    using global::OBeautifulCode.Math.Recipes;
    using global::OBeautifulCode.Serialization;

    /// <summary>
    /// The default (code generated) Dummy Factory.
    /// Derive from this class to add any overriding or custom registrations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    [GeneratedCode("OBeautifulCode.CodeGen.ModelObject", "1.0.178.0")]
#if !NaosAWSSolution
    internal
#else
    public
#endif
    abstract class DefaultAWSDummyFactory : IDummyFactory
    {
        public DefaultAWSDummyFactory()
        {
            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CloudStorageReaderSettings(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () =>
                {
                    var availableTypes = new[]
                    {
                        typeof(CloudStorageReaderSettings),
                        typeof(CloudStorageWriterSettings)
                    };

                    var randomIndex = ThreadSafeRandom.Next(0, availableTypes.Length);

                    var randomType = availableTypes[randomIndex];

                    var result = (CloudStorageSettingsBase)AD.ummy(randomType);

                    return result;
                });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new CloudStorageWriterSettings(
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new S3Credentials(
                                 A.Dummy<string>(),
                                 A.Dummy<string>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new S3ResourceLocator
                             {
                                 Region        = A.Dummy<string>(),
                                 BucketName    = A.Dummy<string>(),
                                 S3Credentials = A.Dummy<S3Credentials>(),
                             });

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new S3StreamConfig(
                                 A.Dummy<string>(),
                                 A.Dummy<StreamAccessKinds>(),
                                 A.Dummy<SerializerRepresentation>(),
                                 A.Dummy<SerializationFormat>(),
                                 A.Dummy<IReadOnlyCollection<IResourceLocator>>()));

            AutoFixtureBackedDummyFactory.AddDummyCreator(
                () => new S3StreamRepresentation(
                                 A.Dummy<string>()));
        }

        /// <inheritdoc />
        public Priority Priority => new FakeItEasy.Priority(1);

        /// <inheritdoc />
        public bool CanCreate(Type type)
        {
            return false;
        }

        /// <inheritdoc />
        public object Create(Type type)
        {
            return null;
        }
    }
}