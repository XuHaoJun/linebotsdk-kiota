// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class FlexComponent : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.FlexComponent"/> and sets the default values.
        /// </summary>
        public FlexComponent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.FlexComponent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.FlexComponent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            return mappingValue switch
            {
                "box" => new KiotaPosts.Client.Models.FlexBox(),
                "button" => new KiotaPosts.Client.Models.FlexButton(),
                "filler" => new KiotaPosts.Client.Models.FlexFiller(),
                "icon" => new KiotaPosts.Client.Models.FlexIcon(),
                "image" => new KiotaPosts.Client.Models.FlexImage(),
                "separator" => new KiotaPosts.Client.Models.FlexSeparator(),
                "span" => new KiotaPosts.Client.Models.FlexSpan(),
                "text" => new KiotaPosts.Client.Models.FlexText(),
                "video" => new KiotaPosts.Client.Models.FlexVideo(),
                _ => new KiotaPosts.Client.Models.FlexComponent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
