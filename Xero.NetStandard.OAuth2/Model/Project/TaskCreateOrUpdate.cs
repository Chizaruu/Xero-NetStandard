/* 
 * Xero Projects API
 *
 * This is the Xero Projects API
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

namespace Xero.NetStandard.OAuth2.Model.Project
{
    /// <summary>
    /// TaskCreateOrUpdate
    /// </summary>
    [DataContract]
    public partial class TaskCreateOrUpdate :  IEquatable<TaskCreateOrUpdate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ChargeType
        /// </summary>
        [DataMember(Name="chargeType", EmitDefaultValue=false)]
        public ChargeType ChargeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskCreateOrUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TaskCreateOrUpdate() 
        { 
        }
        
        /// <summary>
        /// Name of the task. Max length 100 characters.
        /// </summary>
        /// <value>Name of the task. Max length 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public Amount Rate { get; set; }

        /// <summary>
        /// Estimated time to perform the task. EstimateMinutes has to be greater than 0 if provided.
        /// </summary>
        /// <value>Estimated time to perform the task. EstimateMinutes has to be greater than 0 if provided.</value>
        [DataMember(Name="estimateMinutes", EmitDefaultValue=false)]
        public int? EstimateMinutes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCreateOrUpdate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  EstimateMinutes: ").Append(EstimateMinutes).Append("\n");
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
            return this.Equals(input as TaskCreateOrUpdate);
        }

        /// <summary>
        /// Returns true if TaskCreateOrUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskCreateOrUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskCreateOrUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ChargeType == input.ChargeType ||
                    this.ChargeType.Equals(input.ChargeType)
                ) && 
                (
                    this.EstimateMinutes == input.EstimateMinutes ||
                    this.EstimateMinutes.Equals(input.EstimateMinutes)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                hashCode = hashCode * 59 + this.EstimateMinutes.GetHashCode();
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
