// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class ImagemapMessage : KiotaPosts.Client.Models.Message, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaPosts.Client.Models.ImagemapAction>? Actions { get; set; }
#nullable restore
#else
        public List<KiotaPosts.Client.Models.ImagemapAction> Actions { get; set; }
#endif
        /// <summary>The altText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AltText { get; set; }
#nullable restore
#else
        public string AltText { get; set; }
#endif
        /// <summary>The baseSize property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.ImagemapBaseSize? BaseSize { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.ImagemapBaseSize BaseSize { get; set; }
#endif
        /// <summary>The baseUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl { get; set; }
#nullable restore
#else
        public string BaseUrl { get; set; }
#endif
        /// <summary>The video property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.ImagemapVideo? Video { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.ImagemapVideo Video { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.ImagemapMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KiotaPosts.Client.Models.ImagemapMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.ImagemapMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actions", n => { Actions = n.GetCollectionOfObjectValues<KiotaPosts.Client.Models.ImagemapAction>(KiotaPosts.Client.Models.ImagemapAction.CreateFromDiscriminatorValue)?.ToList(); } },
                { "altText", n => { AltText = n.GetStringValue(); } },
                { "baseSize", n => { BaseSize = n.GetObjectValue<KiotaPosts.Client.Models.ImagemapBaseSize>(KiotaPosts.Client.Models.ImagemapBaseSize.CreateFromDiscriminatorValue); } },
                { "baseUrl", n => { BaseUrl = n.GetStringValue(); } },
                { "video", n => { Video = n.GetObjectValue<KiotaPosts.Client.Models.ImagemapVideo>(KiotaPosts.Client.Models.ImagemapVideo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KiotaPosts.Client.Models.ImagemapAction>("actions", Actions);
            writer.WriteStringValue("altText", AltText);
            writer.WriteObjectValue<KiotaPosts.Client.Models.ImagemapBaseSize>("baseSize", BaseSize);
            writer.WriteStringValue("baseUrl", BaseUrl);
            writer.WriteObjectValue<KiotaPosts.Client.Models.ImagemapVideo>("video", Video);
        }
    }
}
