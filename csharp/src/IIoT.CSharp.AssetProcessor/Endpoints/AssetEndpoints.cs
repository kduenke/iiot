using IIoT.CSharp.AssetProcessor.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace IIoT.CSharp.AssetProcessor.Endpoints;

public static class AssetEndpoints
{
    public static IEndpointRouteBuilder MapAssetEndpoints(this IEndpointRouteBuilder builder)
    {
        var group = builder.MapGroup("/")
            .WithTags(nameof(AssetEndpoints));

        group.MapPost("/process", PostAsync)
            .WithName("")
            .WithOpenApi();

        return builder;
    }

    public static async Task<Ok<Asset>> PostAsync(Asset asset)
    {
        Console.WriteLine("Subscriber received : " + asset);

        return TypedResults.Ok(asset);
    }
}
