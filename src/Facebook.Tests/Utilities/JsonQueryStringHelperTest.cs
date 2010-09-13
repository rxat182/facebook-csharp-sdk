// <copyright file="JsonQueryStringHelperTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Facebook.Utilities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for JsonQueryStringHelper</summary>
    [PexClass(typeof(JsonQueryStringExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonQueryStringHelperTest
    {
        /// <summary>Test stub for ToJsonQueryString(IDictionary`2&lt;String,String&gt;)</summary>
        [PexMethod]
        internal string ToJsonQueryString(IDictionary<string, string> dictionary)
        {
            string result = JsonQueryStringExtensions.ToJsonQueryString(dictionary);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString(IDictionary`2<String,String>)
        }

        /// <summary>Test stub for ToJsonQueryString(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        internal string ToJsonQueryString01(IDictionary<string, object> dictionary)
        {
            string result = JsonQueryStringExtensions.ToJsonQueryString(dictionary);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString01(IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for ToJsonQueryString(NameValueCollection)</summary>
        [PexMethod]
        internal string ToJsonQueryString02(NameValueCollection collection)
        {
            string result = JsonQueryStringExtensions.ToJsonQueryString(collection);
            return result;
            // TODO: add assertions to method JsonQueryStringHelperTest.ToJsonQueryString02(NameValueCollection)
        }
    }
}
