// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsUrl
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Paths.
    /// </summary>
    public static partial class PathsExtensions
    {
            /// <summary>
            /// Get true Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetBooleanTrue(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetBooleanTrueAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get true Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetBooleanTrueAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetBooleanTrueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get false Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetBooleanFalse(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetBooleanFalseAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get false Boolean value on path
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetBooleanFalseAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetBooleanFalseWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetIntOneMillion(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetIntOneMillionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetIntOneMillionAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetIntOneMillionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetIntNegativeOneMillion(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetIntNegativeOneMillionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-1000000' integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetIntNegativeOneMillionAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetIntNegativeOneMillionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetTenBillion(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetTenBillionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetTenBillionAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetTenBillionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void GetNegativeTenBillion(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).GetNegativeTenBillionAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-10000000000' 64 bit integer value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task GetNegativeTenBillionAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.GetNegativeTenBillionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '1.034E+20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void FloatScientificPositive(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).FloatScientificPositiveAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '1.034E+20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FloatScientificPositiveAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.FloatScientificPositiveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-1.034E-20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void FloatScientificNegative(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).FloatScientificNegativeAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-1.034E-20' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FloatScientificNegativeAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.FloatScientificNegativeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DoubleDecimalPositive(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DoubleDecimalPositiveAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DoubleDecimalPositiveAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DoubleDecimalPositiveWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '-9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DoubleDecimalNegative(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DoubleDecimalNegativeAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '-9999999.999' numeric value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DoubleDecimalNegativeAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DoubleDecimalNegativeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multi-byte string value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void StringUnicode(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringUnicodeAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multi-byte string value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringUnicodeAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringUnicodeWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get 'begin!*'();:@ &amp;=+$,/?#[]end
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void StringUrlEncoded(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringUrlEncodedAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get 'begin!*'();:@ &amp;=+$,/?#[]end
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringUrlEncodedAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringUrlEncodedWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void StringEmpty(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringEmptyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get ''
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringEmptyAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// null string value
            /// </param>
            public static void StringNull(this IPaths operations, string stringPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).StringNullAsync(stringPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stringPath'>
            /// null string value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StringNullAsync(this IPaths operations, string stringPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.StringNullWithHttpMessagesAsync(stringPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get using uri with 'green color' in path parameter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send the value green. Possible values include: 'red color', 'green color',
            /// 'blue color'
            /// </param>
            public static void EnumValid(this IPaths operations, UriColor enumPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).EnumValidAsync(enumPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get using uri with 'green color' in path parameter
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send the value green. Possible values include: 'red color', 'green color',
            /// 'blue color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnumValidAsync(this IPaths operations, UriColor enumPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.EnumValidWithHttpMessagesAsync(enumPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null (should throw on the client before the request is sent on wire)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send null should throw. Possible values include: 'red color', 'green
            /// color', 'blue color'
            /// </param>
            public static void EnumNull(this IPaths operations, UriColor enumPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).EnumNullAsync(enumPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null (should throw on the client before the request is sent on wire)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='enumPath'>
            /// send null should throw. Possible values include: 'red color', 'green
            /// color', 'blue color'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task EnumNullAsync(this IPaths operations, UriColor enumPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.EnumNullWithHttpMessagesAsync(enumPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </param>
            public static void ByteMultiByte(this IPaths operations, byte[] bytePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteMultiByteAsync(bytePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// '啊齄丂狛狜隣郎隣兀﨩' multibyte value as utf-8 encoded byte array
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteMultiByteAsync(this IPaths operations, byte[] bytePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteMultiByteWithHttpMessagesAsync(bytePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '' as byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ByteEmpty(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteEmptyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '' as byte array
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteEmptyAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteEmptyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as byte array (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// null as byte array (should throw)
            /// </param>
            public static void ByteNull(this IPaths operations, byte[] bytePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ByteNullAsync(bytePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as byte array (should throw)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='bytePath'>
            /// null as byte array (should throw)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ByteNullAsync(this IPaths operations, byte[] bytePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ByteNullWithHttpMessagesAsync(bytePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '2012-01-01' as date
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DateValid(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateValidAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '2012-01-01' as date
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateValidAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as date - this should throw or be unusable on the client side,
            /// depending on date representation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// null as date (should throw)
            /// </param>
            public static void DateNull(this IPaths operations, DateTime datePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateNullAsync(datePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as date - this should throw or be unusable on the client side,
            /// depending on date representation
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datePath'>
            /// null as date (should throw)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateNullAsync(this IPaths operations, DateTime datePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateNullWithHttpMessagesAsync(datePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get '2012-01-01T01:01:01Z' as date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void DateTimeValid(this IPaths operations)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateTimeValidAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get '2012-01-01T01:01:01Z' as date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateTimeValidAsync(this IPaths operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateTimeValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null as date-time, should be disallowed or throw depending on
            /// representation of date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// null as date-time
            /// </param>
            public static void DateTimeNull(this IPaths operations, DateTime dateTimePath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).DateTimeNullAsync(dateTimePath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null as date-time, should be disallowed or throw depending on
            /// representation of date-time
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='dateTimePath'>
            /// null as date-time
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DateTimeNullAsync(this IPaths operations, DateTime dateTimePath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DateTimeNullWithHttpMessagesAsync(dateTimePath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get 'lorem' encoded value as 'bG9yZW0' (base64url)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='base64UrlPath'>
            /// base64url encoded value
            /// </param>
            public static void Base64Url(this IPaths operations, byte[] base64UrlPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).Base64UrlAsync(base64UrlPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get 'lorem' encoded value as 'bG9yZW0' (base64url)
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='base64UrlPath'>
            /// base64url encoded value
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task Base64UrlAsync(this IPaths operations, byte[] base64UrlPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.Base64UrlWithHttpMessagesAsync(base64UrlPath, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get an array of string ['ArrayPath1', 'begin!*'();:@ &amp;=+$,/?#[]end' ,
            /// null, ''] using the csv-array format
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='arrayPath'>
            /// an array of string ['ArrayPath1', 'begin!*'();:@ &amp;=+$,/?#[]end' ,
            /// null, ''] using the csv-array format
            /// </param>
            public static void ArrayCsvInPath(this IPaths operations, IList<string> arrayPath)
            {
                Task.Factory.StartNew(s => ((IPaths)s).ArrayCsvInPathAsync(arrayPath), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get an array of string ['ArrayPath1', 'begin!*'();:@ &amp;=+$,/?#[]end' ,
            /// null, ''] using the csv-array format
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='arrayPath'>
            /// an array of string ['ArrayPath1', 'begin!*'();:@ &amp;=+$,/?#[]end' ,
            /// null, ''] using the csv-array format
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ArrayCsvInPathAsync(this IPaths operations, IList<string> arrayPath, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ArrayCsvInPathWithHttpMessagesAsync(arrayPath, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
