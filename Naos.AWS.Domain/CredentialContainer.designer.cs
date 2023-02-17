﻿// --------------------------------------------------------------------------------------------------------------------
// <auto-generated>
//   Generated using OBeautifulCode.CodeGen.ModelObject (1.0.178.0)
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.AWS.Domain
{
    using global::System;
    using global::System.CodeDom.Compiler;
    using global::System.Collections.Concurrent;
    using global::System.Collections.Generic;
    using global::System.Collections.ObjectModel;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Globalization;
    using global::System.Linq;

    using global::OBeautifulCode.Cloning.Recipes;
    using global::OBeautifulCode.Equality.Recipes;
    using global::OBeautifulCode.Type;
    using global::OBeautifulCode.Type.Recipes;

    using static global::System.FormattableString;

    [Serializable]
    public partial class CredentialContainer : IModel<CredentialContainer>
    {
        /// <summary>
        /// Determines whether two objects of type <see cref="CredentialContainer"/> are equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are equal; otherwise false.</returns>
        public static bool operator ==(CredentialContainer left, CredentialContainer right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            var result = left.Equals(right);

            return result;
        }

        /// <summary>
        /// Determines whether two objects of type <see cref="CredentialContainer"/> are not equal.
        /// </summary>
        /// <param name="left">The object to the left of the equality operator.</param>
        /// <param name="right">The object to the right of the equality operator.</param>
        /// <returns>true if the two items are not equal; otherwise false.</returns>
        public static bool operator !=(CredentialContainer left, CredentialContainer right) => !(left == right);

        /// <inheritdoc />
        public bool Equals(CredentialContainer other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            if (ReferenceEquals(other, null))
            {
                return false;
            }

            var result = this.CredentialType.IsEqualTo(other.CredentialType)
                      && this.AccessKeyId.IsEqualTo(other.AccessKeyId, StringComparer.Ordinal)
                      && this.SecretAccessKey.IsEqualTo(other.SecretAccessKey, StringComparer.Ordinal)
                      && this.SessionToken.IsEqualTo(other.SessionToken, StringComparer.Ordinal)
                      && this.Expiration.IsEqualTo(other.Expiration);

            return result;
        }

        /// <inheritdoc />
        public override bool Equals(object obj) => this == (obj as CredentialContainer);

        /// <inheritdoc />
        public override int GetHashCode() => HashCodeHelper.Initialize()
            .Hash(this.CredentialType)
            .Hash(this.AccessKeyId)
            .Hash(this.SecretAccessKey)
            .Hash(this.SessionToken)
            .Hash(this.Expiration)
            .Value;

        /// <inheritdoc />
        public object Clone() => this.DeepClone();

        /// <inheritdoc />
        public CredentialContainer DeepClone()
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = this.CredentialType.DeepClone(),
                                 AccessKeyId     = this.AccessKeyId?.DeepClone(),
                                 SecretAccessKey = this.SecretAccessKey?.DeepClone(),
                                 SessionToken    = this.SessionToken?.DeepClone(),
                                 Expiration      = this.Expiration.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="CredentialType" />.
        /// </summary>
        /// <param name="credentialType">The new <see cref="CredentialType" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CredentialContainer" /> using the specified <paramref name="credentialType" /> for <see cref="CredentialType" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public CredentialContainer DeepCloneWithCredentialType(CredentialType credentialType)
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = credentialType,
                                 AccessKeyId     = this.AccessKeyId?.DeepClone(),
                                 SecretAccessKey = this.SecretAccessKey?.DeepClone(),
                                 SessionToken    = this.SessionToken?.DeepClone(),
                                 Expiration      = this.Expiration.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="AccessKeyId" />.
        /// </summary>
        /// <param name="accessKeyId">The new <see cref="AccessKeyId" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CredentialContainer" /> using the specified <paramref name="accessKeyId" /> for <see cref="AccessKeyId" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public CredentialContainer DeepCloneWithAccessKeyId(string accessKeyId)
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = this.CredentialType.DeepClone(),
                                 AccessKeyId     = accessKeyId,
                                 SecretAccessKey = this.SecretAccessKey?.DeepClone(),
                                 SessionToken    = this.SessionToken?.DeepClone(),
                                 Expiration      = this.Expiration.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SecretAccessKey" />.
        /// </summary>
        /// <param name="secretAccessKey">The new <see cref="SecretAccessKey" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CredentialContainer" /> using the specified <paramref name="secretAccessKey" /> for <see cref="SecretAccessKey" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public CredentialContainer DeepCloneWithSecretAccessKey(string secretAccessKey)
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = this.CredentialType.DeepClone(),
                                 AccessKeyId     = this.AccessKeyId?.DeepClone(),
                                 SecretAccessKey = secretAccessKey,
                                 SessionToken    = this.SessionToken?.DeepClone(),
                                 Expiration      = this.Expiration.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="SessionToken" />.
        /// </summary>
        /// <param name="sessionToken">The new <see cref="SessionToken" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CredentialContainer" /> using the specified <paramref name="sessionToken" /> for <see cref="SessionToken" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public CredentialContainer DeepCloneWithSessionToken(string sessionToken)
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = this.CredentialType.DeepClone(),
                                 AccessKeyId     = this.AccessKeyId?.DeepClone(),
                                 SecretAccessKey = this.SecretAccessKey?.DeepClone(),
                                 SessionToken    = sessionToken,
                                 Expiration      = this.Expiration.DeepClone(),
                             };

            return result;
        }

        /// <summary>
        /// Deep clones this object with a new <see cref="Expiration" />.
        /// </summary>
        /// <param name="expiration">The new <see cref="Expiration" />.  This object will NOT be deep cloned; it is used as-is.</param>
        /// <returns>New <see cref="CredentialContainer" /> using the specified <paramref name="expiration" /> for <see cref="Expiration" /> and a deep clone of every other property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings")]
        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly")]
        [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1711:IdentifiersShouldNotHaveIncorrectSuffix")]
        [SuppressMessage("Microsoft.Naming", "CA1715:IdentifiersShouldHaveCorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords")]
        [SuppressMessage("Microsoft.Naming", "CA1719:ParameterNamesShouldNotMatchMemberNames")]
        [SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames")]
        [SuppressMessage("Microsoft.Naming", "CA1722:IdentifiersShouldNotHaveIncorrectPrefix")]
        [SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration")]
        [SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms")]
        [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly")]
        [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        public CredentialContainer DeepCloneWithExpiration(DateTime expiration)
        {
            var result = new CredentialContainer
                             {
                                 CredentialType  = this.CredentialType.DeepClone(),
                                 AccessKeyId     = this.AccessKeyId?.DeepClone(),
                                 SecretAccessKey = this.SecretAccessKey?.DeepClone(),
                                 SessionToken    = this.SessionToken?.DeepClone(),
                                 Expiration      = expiration,
                             };

            return result;
        }

        /// <inheritdoc />
        [SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public override string ToString()
        {
            var result = Invariant($"Naos.AWS.Domain.CredentialContainer: CredentialType = {this.CredentialType.ToString() ?? "<null>"}, AccessKeyId = {this.AccessKeyId?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, SecretAccessKey = {this.SecretAccessKey?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, SessionToken = {this.SessionToken?.ToString(CultureInfo.InvariantCulture) ?? "<null>"}, Expiration = {this.Expiration.ToString(CultureInfo.InvariantCulture) ?? "<null>"}.");

            return result;
        }
    }
}