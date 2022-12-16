using Penneo;
using Sharprompt;

var environmentOptions = Prompt.Bind<EnvironmentOptions>();

string apiUrl = $"https://{environmentOptions.Environment}.penneo.com/api/v3/";
PenneoConnector c = new PenneoConnector(environmentOptions.Key, environmentOptions.Secret, apiUrl);

var webhook = new WebhookSubscription
{
    Endpoint = environmentOptions.WebhookEndpoint,
    Topic = environmentOptions.Topic
};

webhook.Persist(c);

var confirmation = Prompt.Bind<Confirmation>();

Console.WriteLine(webhook.Confirm(c, confirmation.Token) ? "Success!" : $"Error: {c.LastResponseContent}");