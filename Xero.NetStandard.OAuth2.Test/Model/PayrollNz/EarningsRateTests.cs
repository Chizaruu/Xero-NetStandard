/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollNz;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollNz
{
    /// <summary>
    ///  Class for testing EarningsRate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EarningsRateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for EarningsRate
        //private EarningsRate instance;

        public EarningsRateTests()
        {
            // TODO uncomment below to create an instance of EarningsRate
            //instance = new EarningsRate();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of EarningsRate
        /// </summary>
        [Fact]
        public void EarningsRateInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" EarningsRate
            //Assert.IsInstanceOfType<EarningsRate> (instance, "variable 'instance' is a EarningsRate");
        }


        /// <summary>
        /// Test the property 'EarningsRateID'
        /// </summary>
        [Fact]
        public void EarningsRateIDTest()
        {
            // TODO unit test for the property 'EarningsRateID'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'EarningsType'
        /// </summary>
        [Theory]
        [InlineData("Allowance", EarningsRate.EarningsTypeEnum.Allowance)]
        [InlineData("Backpay", EarningsRate.EarningsTypeEnum.Backpay)]
        [InlineData("Bonus", EarningsRate.EarningsTypeEnum.Bonus)]
        [InlineData("Commission", EarningsRate.EarningsTypeEnum.Commission)]
        [InlineData("DiscretionaryPayments", EarningsRate.EarningsTypeEnum.DiscretionaryPayments)]
        [InlineData("HolidayPay", EarningsRate.EarningsTypeEnum.HolidayPay)]
        [InlineData("LumpSum", EarningsRate.EarningsTypeEnum.LumpSum)]
        [InlineData("OtherEarnings", EarningsRate.EarningsTypeEnum.OtherEarnings)]
        [InlineData("OtherGrossEarnings", EarningsRate.EarningsTypeEnum.OtherGrossEarnings)]
        [InlineData("OvertimeEarnings", EarningsRate.EarningsTypeEnum.OvertimeEarnings)]
        [InlineData("RegularEarnings", EarningsRate.EarningsTypeEnum.RegularEarnings)]
        [InlineData("SalarySacrificeForKiwiSaver", EarningsRate.EarningsTypeEnum.SalarySacrificeForKiwiSaver)]
        [InlineData("TipsDirect", EarningsRate.EarningsTypeEnum.TipsDirect)]
        [InlineData("TipsNonDirect", EarningsRate.EarningsTypeEnum.TipsNonDirect)]
        [InlineData("WithholdingIncome", EarningsRate.EarningsTypeEnum.WithholdingIncome)]
        public void EarningsTypeEnum_ValidInput_Deserialises(string input, EarningsRate.EarningsTypeEnum expected)
        {
            var response = new RestResponse();
            response.Content = $@"""{input}""";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<EarningsRate.EarningsTypeEnum>(response);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EarningsTypeEnum_NullInput_Deserialises(){
            var response = new RestResponse();
            response.Content = "null";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<EarningsRate.EarningsTypeEnum>(response);

            Assert.Equal(0, (int)actual);
        }
        /// <summary>
        /// Test the property 'RateType'
        /// </summary>
        [Theory]
        [InlineData("FixedAmount", EarningsRate.RateTypeEnum.FixedAmount)]
        [InlineData("MultipleOfOrdinaryEarningsRate", EarningsRate.RateTypeEnum.MultipleOfOrdinaryEarningsRate)]
        [InlineData("RatePerUnit", EarningsRate.RateTypeEnum.RatePerUnit)]
        public void RateTypeTest(string input, EarningsRate.RateTypeEnum expected)
        {     
            var response = new RestResponse();
            response.Content = $@"""{input}""";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<EarningsRate.RateTypeEnum>(response);

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void RateTypeEnum_NullInput_Deserialises(){
            var response = new RestResponse();
            response.Content = "null";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<EarningsRate.RateTypeEnum>(response);

            Assert.Equal(0, (int)actual);    
        }
        /// <summary>
        /// Test the property 'TypeOfUnits'
        /// </summary>
        [Fact]
        public void TypeOfUnitsTest()
        {
            // TODO unit test for the property 'TypeOfUnits'
        }
        /// <summary>
        /// Test the property 'CurrentRecord'
        /// </summary>
        [Fact]
        public void CurrentRecordTest()
        {
            // TODO unit test for the property 'CurrentRecord'
        }
        /// <summary>
        /// Test the property 'ExpenseAccountID'
        /// </summary>
        [Fact]
        public void ExpenseAccountIDTest()
        {
            // TODO unit test for the property 'ExpenseAccountID'
        }
        /// <summary>
        /// Test the property 'RatePerUnit'
        /// </summary>
        [Fact]
        public void RatePerUnitTest()
        {
            // TODO unit test for the property 'RatePerUnit'
        }
        /// <summary>
        /// Test the property 'MultipleOfOrdinaryEarningsRate'
        /// </summary>
        [Fact]
        public void MultipleOfOrdinaryEarningsRateTest()
        {
            // TODO unit test for the property 'MultipleOfOrdinaryEarningsRate'
        }
        /// <summary>
        /// Test the property 'FixedAmount'
        /// </summary>
        [Fact]
        public void FixedAmountTest()
        {
            // TODO unit test for the property 'FixedAmount'
        }

    }

}
