// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    /// <summary>
    /// Rich menu bounds
    /// </summary>
    public class RichMenuBounds : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Height of the area.</summary>
        public long? Height { get; set; }
        /// <summary>Width of the area.</summary>
        public long? Width { get; set; }
        /// <summary>Horizontal position relative to the top-left corner of the area.</summary>
        public long? X { get; set; }
        /// <summary>Vertical position relative to the top-left corner of the area.</summary>
        public long? Y { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.Models.RichMenuBounds"/> and sets the default values.
        /// </summary>
        public RichMenuBounds()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.RichMenuBounds"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KiotaPosts.Client.Models.RichMenuBounds CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.RichMenuBounds();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "height", n => { Height = n.GetLongValue(); } },
                { "width", n => { Width = n.GetLongValue(); } },
                { "x", n => { X = n.GetLongValue(); } },
                { "y", n => { Y = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("height", Height);
            writer.WriteLongValue("width", Width);
            writer.WriteLongValue("x", X);
            writer.WriteLongValue("y", Y);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
