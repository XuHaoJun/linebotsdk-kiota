// <auto-generated/>
using KiotaPosts.Client.V2.Bot.Room.Item.Leave;
using KiotaPosts.Client.V2.Bot.Room.Item.Member;
using KiotaPosts.Client.V2.Bot.Room.Item.Members;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace KiotaPosts.Client.V2.Bot.Room.Item
{
    /// <summary>
    /// Builds and executes requests for operations under \v2\bot\room\{roomId}
    /// </summary>
    public class WithRoomItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The leave property</summary>
        public KiotaPosts.Client.V2.Bot.Room.Item.Leave.LeaveRequestBuilder Leave
        {
            get => new KiotaPosts.Client.V2.Bot.Room.Item.Leave.LeaveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The member property</summary>
        public KiotaPosts.Client.V2.Bot.Room.Item.Member.MemberRequestBuilder Member
        {
            get => new KiotaPosts.Client.V2.Bot.Room.Item.Member.MemberRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The members property</summary>
        public KiotaPosts.Client.V2.Bot.Room.Item.Members.MembersRequestBuilder Members
        {
            get => new KiotaPosts.Client.V2.Bot.Room.Item.Members.MembersRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Room.Item.WithRoomItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRoomItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/room/{roomId}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="KiotaPosts.Client.V2.Bot.Room.Item.WithRoomItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithRoomItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v2/bot/room/{roomId}", rawUrl)
        {
        }
    }
}
