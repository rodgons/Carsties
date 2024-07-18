using System.ComponentModel.DataAnnotations.Schema;

using AuctionService.Common;

namespace AuctionService.Entities;

[Table("auctions")]
public class Auction
{
    public Guid Id { get; set; } = UuidV7.NewGuid();
    public int ReservePrice { get; set; } = 0;
    public string Seller { get; set; } = string.Empty;
    public string Winner { get; set; } = string.Empty;
    public int? SoldAmount { get; set; }
    public int? CurrentHighBid { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public DateTime AuctionEnd { get; set; }
    public Status Status { get; set; } = Status.Live;
    public Item Item { get; set; }
}
