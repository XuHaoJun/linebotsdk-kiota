// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class RichMenuBatchProgressResponse : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accepted time in milliseconds of the request of batch control the rich menu.Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z)Timezone: UTC</summary>
        public DateTimeOffset? AcceptedTime { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The completed time in milliseconds of rich menu batch control. Returned when the phase property is succeeded or failed.Format: ISO 8601 (e.g. 2023-06-08T10:15:30.121Z)Timezone: UTC</summary>
        public DateTimeOffset? CompletedTime { get; set; }
        /// <summary>The current status. One of:`ongoing`: Rich menu batch control is in progress.`succeeded`: Rich menu batch control is complete.`failed`: Rich menu batch control failed.          This means that the rich menu for one or more users couldn&apos;t be controlled.           There may also be users whose operations have been successfully completed.</summary>
        public KiotaPosts.Client.Models.RichMenuBatchProgressPhase? Phase { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.RichMenuBatchProgressResponse"/> and sets the default values.
        /// </summary>
        public RichMenuBatchProgressResponse()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.RichMenuBatchProgressResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.RichMenuBatchProgressResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.RichMenuBatchProgressResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "acceptedTime", n => { AcceptedTime = n.GetDateTimeOffsetValue(); } },
                { "completedTime", n => { CompletedTime = n.GetDateTimeOffsetValue(); } },
                { "phase", n => { Phase = n.GetEnumValue<KiotaPosts.Client.Models.RichMenuBatchProgressPhase>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("acceptedTime", AcceptedTime);
            writer.WriteDateTimeOffsetValue("completedTime", CompletedTime);
            writer.WriteEnumValue<KiotaPosts.Client.Models.RichMenuBatchProgressPhase>("phase", Phase);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
