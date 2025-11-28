using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class SalesData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [JsonProperty("Receipt number")]
    public string? receipt_number { get; set; }

    [JsonProperty("Receipt Date")]
    public string? sale_date { get; set; }

    [JsonProperty("Transaction Time")]
    public string? transaction_time { get; set; }

    [JsonProperty("Invoice amount")]
    public double? sale_amount { get; set; }

    [JsonProperty("Discount amount")]
    public double? discount_amount { get; set; }

    [JsonProperty("Tax amount")]
    public double? tax_amount { get; set; }

    [JsonProperty("Round Off")]
    public string? round_off { get; set; }

    [JsonProperty("Net sale")]
    public double? net_sale { get; set; }

    [JsonProperty("Payment Mode")]
    public string? payment_mode { get; set; }

    [JsonProperty("Order Type")]
    public string? order_type { get; set; }

    [JsonProperty("Transaction status")]
    public string? transaction_status { get; set; }
}
