using ModernEdi;
using ModernEdi.Model;

// This example reads and plans configuration. It never applies configuration or sends EDI.
if (args.Contains("--package-smoke"))
{
    var plan = WireJson.Deserialize<ConfigurationPlanRequest>("{\"files\":[]}");
    if (WireJson.Serialize(plan) != "{\"files\":[]}") throw new Exception("Package wire serialization failed.");
    Console.WriteLine("Installed package smoke passed; no network calls.");
    return;
}

using var client = new ModernEdiClient(apiKey: Environment.GetEnvironmentVariable("MODERNEDI_API_KEY")
    ?? throw new InvalidOperationException("Set MODERNEDI_API_KEY in your server environment."));
var exported = (await client.ConfigurationAsCode.ExportIntegrationConfigurationAsync()).Data
    ?? throw new InvalidOperationException("Expected an unconditional export.");
var request = new ConfigurationPlanRequest
{
    Files = exported.Files.Select(file => new ConfigurationPlanFile(file)).ToList()
};
var result = await client.ConfigurationAsCode.PlanIntegrationConfigurationAsync(request);
Console.WriteLine($"Plan completed; support request ID: {result.RequestId}");
