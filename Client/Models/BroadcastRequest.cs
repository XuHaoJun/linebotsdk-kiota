// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class BroadcastRequest : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of Message objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaPosts.Client.Models.Message>? Messages { get; set; }
#nullable restore
#else
        public List<KiotaPosts.Client.Models.Message> Messages { get; set; }
#endif
        /// <summary>`true`: The user doesn’t receive a push notification when a message is sent.`false`: The user receives a push notification when the message is sent (unless they have disabled push notifications in LINE and/or their device).The default value is false.</summary>
        public bool? NotificationDisabled { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.BroadcastRequest"/> and sets the default values.
        /// </summary>
        public BroadcastRequest()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.BroadcastRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.BroadcastRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.BroadcastRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<KiotaPosts.Client.Models.Message>(KiotaPosts.Client.Models.Message.CreateFromDiscriminatorValue)?.ToList(); } },
                { "notificationDisabled", n => { NotificationDisabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<KiotaPosts.Client.Models.Message>("messages", Messages);
            writer.WriteBoolValue("notificationDisabled", NotificationDisabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
