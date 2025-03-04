// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class TestWebhookEndpointResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Details of the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Detail { get; set; }
#nullable restore
#else
        public string Detail { get; set; }
#endif
        /// <summary>Reason for the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>The HTTP status code. If the webhook response isn&apos;t received, the status code is set to zero or a negative number.</summary>
        public int? StatusCode { get; set; }
        /// <summary>Result of the communication from the LINE platform to the webhook URL.</summary>
        public bool? Success { get; set; }
        /// <summary>Time of the event in milliseconds. Even in the case of a redelivered webhook, it represents the time the event occurred, not the time it was redelivered.</summary>
        public DateTimeOffset? Timestamp { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.TestWebhookEndpointResponse"/> and sets the default values.
        /// </summary>
        public TestWebhookEndpointResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.TestWebhookEndpointResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.TestWebhookEndpointResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.TestWebhookEndpointResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "detail", n => { Detail = n.GetStringValue(); } },
                { "reason", n => { Reason = n.GetStringValue(); } },
                { "statusCode", n => { StatusCode = n.GetIntValue(); } },
                { "success", n => { Success = n.GetBoolValue(); } },
                { "timestamp", n => { Timestamp = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("detail", Detail);
            writer.WriteStringValue("reason", Reason);
            writer.WriteIntValue("statusCode", StatusCode);
            writer.WriteBoolValue("success", Success);
            writer.WriteDateTimeOffsetValue("timestamp", Timestamp);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
