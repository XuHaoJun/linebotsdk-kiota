// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace KiotaPosts.Client.Models
{
    #pragma warning disable CS1591
    public class FlexBox : KiotaPosts.Client.Models.FlexComponent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Action</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.ActionObject? Action { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.ActionObject Action { get; set; }
#endif
        /// <summary>The alignItems property</summary>
        public KiotaPosts.Client.Models.FlexBox_alignItems? AlignItems { get; set; }
        /// <summary>The background property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KiotaPosts.Client.Models.FlexBoxBackground? Background { get; set; }
#nullable restore
#else
        public KiotaPosts.Client.Models.FlexBoxBackground Background { get; set; }
#endif
        /// <summary>The backgroundColor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundColor { get; set; }
#nullable restore
#else
        public string BackgroundColor { get; set; }
#endif
        /// <summary>The borderColor property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BorderColor { get; set; }
#nullable restore
#else
        public string BorderColor { get; set; }
#endif
        /// <summary>The borderWidth property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BorderWidth { get; set; }
#nullable restore
#else
        public string BorderWidth { get; set; }
#endif
        /// <summary>The contents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KiotaPosts.Client.Models.FlexComponent>? Contents { get; set; }
#nullable restore
#else
        public List<KiotaPosts.Client.Models.FlexComponent> Contents { get; set; }
#endif
        /// <summary>The cornerRadius property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CornerRadius { get; set; }
#nullable restore
#else
        public string CornerRadius { get; set; }
#endif
        /// <summary>The flex property</summary>
        public int? Flex { get; set; }
        /// <summary>The height property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Height { get; set; }
#nullable restore
#else
        public string Height { get; set; }
#endif
        /// <summary>The justifyContent property</summary>
        public KiotaPosts.Client.Models.FlexBox_justifyContent? JustifyContent { get; set; }
        /// <summary>The layout property</summary>
        public KiotaPosts.Client.Models.FlexBox_layout? Layout { get; set; }
        /// <summary>The margin property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Margin { get; set; }
#nullable restore
#else
        public string Margin { get; set; }
#endif
        /// <summary>The maxHeight property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaxHeight { get; set; }
#nullable restore
#else
        public string MaxHeight { get; set; }
#endif
        /// <summary>The maxWidth property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MaxWidth { get; set; }
#nullable restore
#else
        public string MaxWidth { get; set; }
#endif
        /// <summary>The offsetBottom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetBottom { get; set; }
#nullable restore
#else
        public string OffsetBottom { get; set; }
#endif
        /// <summary>The offsetEnd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetEnd { get; set; }
#nullable restore
#else
        public string OffsetEnd { get; set; }
#endif
        /// <summary>The offsetStart property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetStart { get; set; }
#nullable restore
#else
        public string OffsetStart { get; set; }
#endif
        /// <summary>The offsetTop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OffsetTop { get; set; }
#nullable restore
#else
        public string OffsetTop { get; set; }
#endif
        /// <summary>The paddingAll property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaddingAll { get; set; }
#nullable restore
#else
        public string PaddingAll { get; set; }
#endif
        /// <summary>The paddingBottom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaddingBottom { get; set; }
#nullable restore
#else
        public string PaddingBottom { get; set; }
#endif
        /// <summary>The paddingEnd property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaddingEnd { get; set; }
#nullable restore
#else
        public string PaddingEnd { get; set; }
#endif
        /// <summary>The paddingStart property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaddingStart { get; set; }
#nullable restore
#else
        public string PaddingStart { get; set; }
#endif
        /// <summary>The paddingTop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PaddingTop { get; set; }
#nullable restore
#else
        public string PaddingTop { get; set; }
#endif
        /// <summary>The position property</summary>
        public KiotaPosts.Client.Models.FlexBox_position? Position { get; set; }
        /// <summary>The spacing property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Spacing { get; set; }
#nullable restore
#else
        public string Spacing { get; set; }
#endif
        /// <summary>The width property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Width { get; set; }
#nullable restore
#else
        public string Width { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KiotaPosts.Client.Models.FlexBox"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KiotaPosts.Client.Models.FlexBox CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KiotaPosts.Client.Models.FlexBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "action", n => { Action = n.GetObjectValue<KiotaPosts.Client.Models.ActionObject>(KiotaPosts.Client.Models.ActionObject.CreateFromDiscriminatorValue); } },
                { "alignItems", n => { AlignItems = n.GetEnumValue<KiotaPosts.Client.Models.FlexBox_alignItems>(); } },
                { "background", n => { Background = n.GetObjectValue<KiotaPosts.Client.Models.FlexBoxBackground>(KiotaPosts.Client.Models.FlexBoxBackground.CreateFromDiscriminatorValue); } },
                { "backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                { "borderColor", n => { BorderColor = n.GetStringValue(); } },
                { "borderWidth", n => { BorderWidth = n.GetStringValue(); } },
                { "contents", n => { Contents = n.GetCollectionOfObjectValues<KiotaPosts.Client.Models.FlexComponent>(KiotaPosts.Client.Models.FlexComponent.CreateFromDiscriminatorValue)?.ToList(); } },
                { "cornerRadius", n => { CornerRadius = n.GetStringValue(); } },
                { "flex", n => { Flex = n.GetIntValue(); } },
                { "height", n => { Height = n.GetStringValue(); } },
                { "justifyContent", n => { JustifyContent = n.GetEnumValue<KiotaPosts.Client.Models.FlexBox_justifyContent>(); } },
                { "layout", n => { Layout = n.GetEnumValue<KiotaPosts.Client.Models.FlexBox_layout>(); } },
                { "margin", n => { Margin = n.GetStringValue(); } },
                { "maxHeight", n => { MaxHeight = n.GetStringValue(); } },
                { "maxWidth", n => { MaxWidth = n.GetStringValue(); } },
                { "offsetBottom", n => { OffsetBottom = n.GetStringValue(); } },
                { "offsetEnd", n => { OffsetEnd = n.GetStringValue(); } },
                { "offsetStart", n => { OffsetStart = n.GetStringValue(); } },
                { "offsetTop", n => { OffsetTop = n.GetStringValue(); } },
                { "paddingAll", n => { PaddingAll = n.GetStringValue(); } },
                { "paddingBottom", n => { PaddingBottom = n.GetStringValue(); } },
                { "paddingEnd", n => { PaddingEnd = n.GetStringValue(); } },
                { "paddingStart", n => { PaddingStart = n.GetStringValue(); } },
                { "paddingTop", n => { PaddingTop = n.GetStringValue(); } },
                { "position", n => { Position = n.GetEnumValue<KiotaPosts.Client.Models.FlexBox_position>(); } },
                { "spacing", n => { Spacing = n.GetStringValue(); } },
                { "width", n => { Width = n.GetStringValue(); } },
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
            writer.WriteObjectValue<KiotaPosts.Client.Models.ActionObject>("action", Action);
            writer.WriteEnumValue<KiotaPosts.Client.Models.FlexBox_alignItems>("alignItems", AlignItems);
            writer.WriteObjectValue<KiotaPosts.Client.Models.FlexBoxBackground>("background", Background);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteStringValue("borderColor", BorderColor);
            writer.WriteStringValue("borderWidth", BorderWidth);
            writer.WriteCollectionOfObjectValues<KiotaPosts.Client.Models.FlexComponent>("contents", Contents);
            writer.WriteStringValue("cornerRadius", CornerRadius);
            writer.WriteIntValue("flex", Flex);
            writer.WriteStringValue("height", Height);
            writer.WriteEnumValue<KiotaPosts.Client.Models.FlexBox_justifyContent>("justifyContent", JustifyContent);
            writer.WriteEnumValue<KiotaPosts.Client.Models.FlexBox_layout>("layout", Layout);
            writer.WriteStringValue("margin", Margin);
            writer.WriteStringValue("maxHeight", MaxHeight);
            writer.WriteStringValue("maxWidth", MaxWidth);
            writer.WriteStringValue("offsetBottom", OffsetBottom);
            writer.WriteStringValue("offsetEnd", OffsetEnd);
            writer.WriteStringValue("offsetStart", OffsetStart);
            writer.WriteStringValue("offsetTop", OffsetTop);
            writer.WriteStringValue("paddingAll", PaddingAll);
            writer.WriteStringValue("paddingBottom", PaddingBottom);
            writer.WriteStringValue("paddingEnd", PaddingEnd);
            writer.WriteStringValue("paddingStart", PaddingStart);
            writer.WriteStringValue("paddingTop", PaddingTop);
            writer.WriteEnumValue<KiotaPosts.Client.Models.FlexBox_position>("position", Position);
            writer.WriteStringValue("spacing", Spacing);
            writer.WriteStringValue("width", Width);
        }
    }
}
