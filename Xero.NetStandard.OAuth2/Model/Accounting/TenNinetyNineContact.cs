/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.15
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// TenNinetyNineContact
    /// </summary>
    [DataContract]
    public partial class TenNinetyNineContact :  IEquatable<TenNinetyNineContact>, IValidatableObject
    {
        
        /// <summary>
        /// Box 1 on 1099 Form
        /// </summary>
        /// <value>Box 1 on 1099 Form</value>
        [DataMember(Name="Box1", EmitDefaultValue=false)]
        public decimal? Box1 { get; set; }

        /// <summary>
        /// Box 2 on 1099 Form
        /// </summary>
        /// <value>Box 2 on 1099 Form</value>
        [DataMember(Name="Box2", EmitDefaultValue=false)]
        public decimal? Box2 { get; set; }

        /// <summary>
        /// Box 3 on 1099 Form
        /// </summary>
        /// <value>Box 3 on 1099 Form</value>
        [DataMember(Name="Box3", EmitDefaultValue=false)]
        public decimal? Box3 { get; set; }

        /// <summary>
        /// Box 4 on 1099 Form
        /// </summary>
        /// <value>Box 4 on 1099 Form</value>
        [DataMember(Name="Box4", EmitDefaultValue=false)]
        public decimal? Box4 { get; set; }

        /// <summary>
        /// Box 5 on 1099 Form
        /// </summary>
        /// <value>Box 5 on 1099 Form</value>
        [DataMember(Name="Box5", EmitDefaultValue=false)]
        public decimal? Box5 { get; set; }

        /// <summary>
        /// Box 6 on 1099 Form
        /// </summary>
        /// <value>Box 6 on 1099 Form</value>
        [DataMember(Name="Box6", EmitDefaultValue=false)]
        public decimal? Box6 { get; set; }

        /// <summary>
        /// Box 7 on 1099 Form
        /// </summary>
        /// <value>Box 7 on 1099 Form</value>
        [DataMember(Name="Box7", EmitDefaultValue=false)]
        public decimal? Box7 { get; set; }

        /// <summary>
        /// Box 8 on 1099 Form
        /// </summary>
        /// <value>Box 8 on 1099 Form</value>
        [DataMember(Name="Box8", EmitDefaultValue=false)]
        public decimal? Box8 { get; set; }

        /// <summary>
        /// Box 9 on 1099 Form
        /// </summary>
        /// <value>Box 9 on 1099 Form</value>
        [DataMember(Name="Box9", EmitDefaultValue=false)]
        public decimal? Box9 { get; set; }

        /// <summary>
        /// Box 10 on 1099 Form
        /// </summary>
        /// <value>Box 10 on 1099 Form</value>
        [DataMember(Name="Box10", EmitDefaultValue=false)]
        public decimal? Box10 { get; set; }

        /// <summary>
        /// Box 11 on 1099 Form
        /// </summary>
        /// <value>Box 11 on 1099 Form</value>
        [DataMember(Name="Box11", EmitDefaultValue=false)]
        public decimal? Box11 { get; set; }

        /// <summary>
        /// Box 13 on 1099 Form
        /// </summary>
        /// <value>Box 13 on 1099 Form</value>
        [DataMember(Name="Box13", EmitDefaultValue=false)]
        public decimal? Box13 { get; set; }

        /// <summary>
        /// Box 14 on 1099 Form
        /// </summary>
        /// <value>Box 14 on 1099 Form</value>
        [DataMember(Name="Box14", EmitDefaultValue=false)]
        public decimal? Box14 { get; set; }

        /// <summary>
        /// Contact name on 1099 Form
        /// </summary>
        /// <value>Contact name on 1099 Form</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Contact Fed Tax ID type
        /// </summary>
        /// <value>Contact Fed Tax ID type</value>
        [DataMember(Name="FederalTaxIDType", EmitDefaultValue=false)]
        public string FederalTaxIDType { get; set; }

        /// <summary>
        /// Contact city on 1099 Form
        /// </summary>
        /// <value>Contact city on 1099 Form</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Contact zip on 1099 Form
        /// </summary>
        /// <value>Contact zip on 1099 Form</value>
        [DataMember(Name="Zip", EmitDefaultValue=false)]
        public string Zip { get; set; }

        /// <summary>
        /// Contact State on 1099 Form
        /// </summary>
        /// <value>Contact State on 1099 Form</value>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Contact email on 1099 Form
        /// </summary>
        /// <value>Contact email on 1099 Form</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Contact address on 1099 Form
        /// </summary>
        /// <value>Contact address on 1099 Form</value>
        [DataMember(Name="StreetAddress", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }

        /// <summary>
        /// Contact tax id on 1099 Form
        /// </summary>
        /// <value>Contact tax id on 1099 Form</value>
        [DataMember(Name="TaxID", EmitDefaultValue=false)]
        public string TaxID { get; set; }

        /// <summary>
        /// Contact contact id
        /// </summary>
        /// <value>Contact contact id</value>
        [DataMember(Name="ContactId", EmitDefaultValue=false)]
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenNinetyNineContact {\n");
            sb.Append("  Box1: ").Append(Box1).Append("\n");
            sb.Append("  Box2: ").Append(Box2).Append("\n");
            sb.Append("  Box3: ").Append(Box3).Append("\n");
            sb.Append("  Box4: ").Append(Box4).Append("\n");
            sb.Append("  Box5: ").Append(Box5).Append("\n");
            sb.Append("  Box6: ").Append(Box6).Append("\n");
            sb.Append("  Box7: ").Append(Box7).Append("\n");
            sb.Append("  Box8: ").Append(Box8).Append("\n");
            sb.Append("  Box9: ").Append(Box9).Append("\n");
            sb.Append("  Box10: ").Append(Box10).Append("\n");
            sb.Append("  Box11: ").Append(Box11).Append("\n");
            sb.Append("  Box13: ").Append(Box13).Append("\n");
            sb.Append("  Box14: ").Append(Box14).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FederalTaxIDType: ").Append(FederalTaxIDType).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  TaxID: ").Append(TaxID).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TenNinetyNineContact);
        }

        /// <summary>
        /// Returns true if TenNinetyNineContact instances are equal
        /// </summary>
        /// <param name="input">Instance of TenNinetyNineContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenNinetyNineContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Box1 == input.Box1 ||
                    this.Box1.Equals(input.Box1)
                ) && 
                (
                    this.Box2 == input.Box2 ||
                    this.Box2.Equals(input.Box2)
                ) && 
                (
                    this.Box3 == input.Box3 ||
                    this.Box3.Equals(input.Box3)
                ) && 
                (
                    this.Box4 == input.Box4 ||
                    this.Box4.Equals(input.Box4)
                ) && 
                (
                    this.Box5 == input.Box5 ||
                    this.Box5.Equals(input.Box5)
                ) && 
                (
                    this.Box6 == input.Box6 ||
                    this.Box6.Equals(input.Box6)
                ) && 
                (
                    this.Box7 == input.Box7 ||
                    this.Box7.Equals(input.Box7)
                ) && 
                (
                    this.Box8 == input.Box8 ||
                    this.Box8.Equals(input.Box8)
                ) && 
                (
                    this.Box9 == input.Box9 ||
                    this.Box9.Equals(input.Box9)
                ) && 
                (
                    this.Box10 == input.Box10 ||
                    this.Box10.Equals(input.Box10)
                ) && 
                (
                    this.Box11 == input.Box11 ||
                    this.Box11.Equals(input.Box11)
                ) && 
                (
                    this.Box13 == input.Box13 ||
                    this.Box13.Equals(input.Box13)
                ) && 
                (
                    this.Box14 == input.Box14 ||
                    this.Box14.Equals(input.Box14)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FederalTaxIDType == input.FederalTaxIDType ||
                    (this.FederalTaxIDType != null &&
                    this.FederalTaxIDType.Equals(input.FederalTaxIDType))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.StreetAddress == input.StreetAddress ||
                    (this.StreetAddress != null &&
                    this.StreetAddress.Equals(input.StreetAddress))
                ) && 
                (
                    this.TaxID == input.TaxID ||
                    (this.TaxID != null &&
                    this.TaxID.Equals(input.TaxID))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Box1.GetHashCode();
                hashCode = hashCode * 59 + this.Box2.GetHashCode();
                hashCode = hashCode * 59 + this.Box3.GetHashCode();
                hashCode = hashCode * 59 + this.Box4.GetHashCode();
                hashCode = hashCode * 59 + this.Box5.GetHashCode();
                hashCode = hashCode * 59 + this.Box6.GetHashCode();
                hashCode = hashCode * 59 + this.Box7.GetHashCode();
                hashCode = hashCode * 59 + this.Box8.GetHashCode();
                hashCode = hashCode * 59 + this.Box9.GetHashCode();
                hashCode = hashCode * 59 + this.Box10.GetHashCode();
                hashCode = hashCode * 59 + this.Box11.GetHashCode();
                hashCode = hashCode * 59 + this.Box13.GetHashCode();
                hashCode = hashCode * 59 + this.Box14.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FederalTaxIDType != null)
                    hashCode = hashCode * 59 + this.FederalTaxIDType.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Zip != null)
                    hashCode = hashCode * 59 + this.Zip.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.StreetAddress != null)
                    hashCode = hashCode * 59 + this.StreetAddress.GetHashCode();
                if (this.TaxID != null)
                    hashCode = hashCode * 59 + this.TaxID.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
