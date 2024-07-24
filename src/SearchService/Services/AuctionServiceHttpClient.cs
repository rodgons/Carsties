using MongoDB.Entities;

using SearchService.Models;

namespace SearchService;

public class AuctionServiceHttpClient(HttpClient httpClient, IConfiguration config)
{
    private readonly HttpClient _httpClient = httpClient;
    private readonly IConfiguration _config = config;

    public async Task<List<Item>> GetItemsForSearchDb()
    {
        var lastUpdated = await DB.Find<Item, string>()
        .Sort(x => x.Descending(y => y.UpdatedAt))
        .Project(x => x.UpdatedAt.ToString())
        .ExecuteFirstAsync();

        return await _httpClient.GetFromJsonAsync<List<Item>>(
            $"{_config["AuctionServiceUrl"]}/api/auctions?date={lastUpdated}"
        );
    }
}
