using System.Text;
using System.Text.Json;
using Humanizer;
using Serilog;
using SimpleExec;
using static SimpleExec.Command;

// Setup logger
var logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss}] [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .WriteTo.File(path: "src/generator.log.txt", outputTemplate: "[{Timestamp:HH:mm:ss}] [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

// Download API Catalog
var client = new HttpClient();
var response = await client.GetAsync("https://api.hubspot.com/api-catalog-public/v1/apis");
var json = await response.Content.ReadAsStringAsync();
var apiCatalog =
    JsonSerializer.Deserialize<ApiCatalog>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
json = JsonSerializer.Serialize(apiCatalog, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("src/api-catalog.json", json, Encoding.UTF8);

// Generate ze code
var successes = new List<string>();
var failures = new List<string>();
foreach (var result in apiCatalog.Results)
{
    var name = result.Name.Underscore().Pascalize();
    logger.Information("Generating {name}", name);
    foreach (var feature in result.Features)
    {
        var featureKey = feature.Key.Underscore().Pascalize();
        logger.Information("Generating {featureKey} {openApiUrl}", featureKey, feature.Value.OpenAPI);
        try
        {
            var (standardOutput1, standardError1) = await ReadAsync(
                "docker",
                @$"run --rm -v {Environment.CurrentDirectory}:/local openapitools/openapi-generator-cli generate -i {feature.Value.OpenAPI} -g csharp-netcore -o /local/src/HubSpot.{name}.{featureKey} -p packageName=HubSpot.{name}.{featureKey}" );

            logger.Information("Standard Output: {standardOutput1}", standardOutput1);
            logger.Error("Standard Error: {standardError1}", standardError1);

            successes.Add($"{name} {featureKey} {feature.Value.OpenAPI}");
        }
        catch (ExitCodeException ex)
        {
            logger.Error(ex, "Failed to generate for {name} {featureKey} {openApiUrl}", name, featureKey, feature.Value.OpenAPI);
            failures.Add($"{name} {featureKey} {feature.Value.OpenAPI}");
        }
    }
}

Console.WriteLine("Successes:");
foreach (var success in successes)
{
    logger.Information("  {success}", success);
}
Console.WriteLine("Failures:");
foreach (var failure in failures)
{
    logger.Error("  {failure}", failure);
}

public class ApiCatalog
{
    public List<Result> Results { get; set; }
}

public class Result
{
    public string                      Name     { get; set; }
    public Dictionary<string, Feature> Features { get; set; }
}

public class Feature
{
    public string OpenAPI { get; set; }
    public string Stage   { get; set; }
}