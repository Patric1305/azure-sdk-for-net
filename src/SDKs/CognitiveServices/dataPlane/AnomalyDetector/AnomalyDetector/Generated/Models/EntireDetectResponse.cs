// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.AnomalyDetector.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class EntireDetectResponse
    {
        /// <summary>
        /// Initializes a new instance of the EntireDetectResponse class.
        /// </summary>
        public EntireDetectResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntireDetectResponse class.
        /// </summary>
        /// <param name="period">Frequency extracted from the series, zero
        /// means no recurrent pattern has been found.</param>
        /// <param name="expectedValues">ExpectedValues contain expected value
        /// for each input point. The index of the array is consistent with the
        /// input series.</param>
        /// <param name="upperMargins">UpperMargins contain upper margin of
        /// each input point. UpperMargin is used to calculate upperBoundary,
        /// which equals to expectedValue + (100 - marginScale)*upperMargin.
        /// Anomalies in response can be filtered by upperBoundary and
        /// lowerBoundary. By adjusting marginScale value, less significant
        /// anomalies can be filtered in client side. The index of the array is
        /// consistent with the input series.</param>
        /// <param name="lowerMargins">LowerMargins contain lower margin of
        /// each input point. LowerMargin is used to calculate lowerBoundary,
        /// which equals to expectedValue - (100 - marginScale)*lowerMargin.
        /// Points between the boundary can be marked as normal ones in client
        /// side. The index of the array is consistent with the input
        /// series.</param>
        /// <param name="isAnomaly">IsAnomaly contains anomaly properties for
        /// each input point. True means an anomaly either negative or positive
        /// has been detected. The index of the array is consistent with the
        /// input series.</param>
        /// <param name="isNegativeAnomaly">IsNegativeAnomaly contains anomaly
        /// status in negative direction for each input point. True means a
        /// negative anomaly has been detected. A negative anomaly means the
        /// point is detected as an anomaly and its real value is smaller than
        /// the expected one. The index of the array is consistent with the
        /// input series.</param>
        /// <param name="isPositiveAnomaly">IsPositiveAnomaly contain anomaly
        /// status in positive direction for each input point. True means a
        /// positive anomaly has been detected. A positive anomaly means the
        /// point is detected as an anomaly and its real value is larger than
        /// the expected one. The index of the array is consistent with the
        /// input series.</param>
        public EntireDetectResponse(int period, IList<double> expectedValues, IList<double> upperMargins, IList<double> lowerMargins, IList<bool> isAnomaly, IList<bool> isNegativeAnomaly, IList<bool> isPositiveAnomaly)
        {
            Period = period;
            ExpectedValues = expectedValues;
            UpperMargins = upperMargins;
            LowerMargins = lowerMargins;
            IsAnomaly = isAnomaly;
            IsNegativeAnomaly = isNegativeAnomaly;
            IsPositiveAnomaly = isPositiveAnomaly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frequency extracted from the series, zero means no
        /// recurrent pattern has been found.
        /// </summary>
        [JsonProperty(PropertyName = "period")]
        public int Period { get; set; }

        /// <summary>
        /// Gets or sets expectedValues contain expected value for each input
        /// point. The index of the array is consistent with the input series.
        /// </summary>
        [JsonProperty(PropertyName = "expectedValues")]
        public IList<double> ExpectedValues { get; set; }

        /// <summary>
        /// Gets or sets upperMargins contain upper margin of each input point.
        /// UpperMargin is used to calculate upperBoundary, which equals to
        /// expectedValue + (100 - marginScale)*upperMargin. Anomalies in
        /// response can be filtered by upperBoundary and lowerBoundary. By
        /// adjusting marginScale value, less significant anomalies can be
        /// filtered in client side. The index of the array is consistent with
        /// the input series.
        /// </summary>
        [JsonProperty(PropertyName = "upperMargins")]
        public IList<double> UpperMargins { get; set; }

        /// <summary>
        /// Gets or sets lowerMargins contain lower margin of each input point.
        /// LowerMargin is used to calculate lowerBoundary, which equals to
        /// expectedValue - (100 - marginScale)*lowerMargin. Points between the
        /// boundary can be marked as normal ones in client side. The index of
        /// the array is consistent with the input series.
        /// </summary>
        [JsonProperty(PropertyName = "lowerMargins")]
        public IList<double> LowerMargins { get; set; }

        /// <summary>
        /// Gets or sets isAnomaly contains anomaly properties for each input
        /// point. True means an anomaly either negative or positive has been
        /// detected. The index of the array is consistent with the input
        /// series.
        /// </summary>
        [JsonProperty(PropertyName = "isAnomaly")]
        public IList<bool> IsAnomaly { get; set; }

        /// <summary>
        /// Gets or sets isNegativeAnomaly contains anomaly status in negative
        /// direction for each input point. True means a negative anomaly has
        /// been detected. A negative anomaly means the point is detected as an
        /// anomaly and its real value is smaller than the expected one. The
        /// index of the array is consistent with the input series.
        /// </summary>
        [JsonProperty(PropertyName = "isNegativeAnomaly")]
        public IList<bool> IsNegativeAnomaly { get; set; }

        /// <summary>
        /// Gets or sets isPositiveAnomaly contain anomaly status in positive
        /// direction for each input point. True means a positive anomaly has
        /// been detected. A positive anomaly means the point is detected as an
        /// anomaly and its real value is larger than the expected one. The
        /// index of the array is consistent with the input series.
        /// </summary>
        [JsonProperty(PropertyName = "isPositiveAnomaly")]
        public IList<bool> IsPositiveAnomaly { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ExpectedValues == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ExpectedValues");
            }
            if (UpperMargins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UpperMargins");
            }
            if (LowerMargins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LowerMargins");
            }
            if (IsAnomaly == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IsAnomaly");
            }
            if (IsNegativeAnomaly == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IsNegativeAnomaly");
            }
            if (IsPositiveAnomaly == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IsPositiveAnomaly");
            }
        }
    }
}