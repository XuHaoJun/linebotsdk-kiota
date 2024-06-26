using KiotaPosts.Client;
using KiotaPosts.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

// API requires no authentication, so use the anonymous
// authentication provider

TokenProvider tokenProvider = new();
var authProvider = new BaseBearerTokenAuthenticationProvider(tokenProvider);

// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider);

// Create the API client
var client = new PostsClient(adapter);

try
{
    // GET /posts
    var body = new BroadcastRequest()
    {
        Messages = [new TextMessage() { Type = "text", Text = "kiota test" },],
    };
    var allPosts = await client.V2.Bot.Message.Broadcast.PostAsync(body);
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}

class TokenProvider : IAccessTokenProvider
{
    public AllowedHostsValidator AllowedHostsValidator => throw new NotImplementedException();

    public Task<string> GetAuthorizationTokenAsync(
        Uri uri,
        Dictionary<string, object>? additionalAuthenticationContext = null,
        CancellationToken cancellationToken = default(CancellationToken)
    )
    {
        return Task.FromResult("<YOUR_CHANNEL_TOKEN>");
    }
}
