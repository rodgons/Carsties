using System.ComponentModel.DataAnnotations.Schema;

using AuctionService.Common;

namespace AuctionService.Entities;

[Table("items")]
public class Item
{
    public Guid Id { get; set;} = UuidV7.NewGuid();
    public string Make { get; set; }= string.Empty;
    public string Model { get; set; }= string.Empty;
    public int Year { get; set; }
    public string Color { get; set; }= string.Empty;
    public int Mileage { get; set; }
    public string ImageUrl { get; set; }= string.Empty;
    public Guid AuctionId { get; set; }
    public Auction Auction { get; set; }
}
