using System;
using Newtonsoft.Json;

namespace HttpClientEventick.Response.ParticipantsResponse
{
    public partial class ParticipantsResponse
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("sort")]
        public Sort Sort { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("ticket_number")]
        public string TicketNumber { get; set; }

        [JsonProperty("ticket_num_qr_code")]
        public string TicketNumQrCode { get; set; }

        [JsonProperty("ticket_name")]
        public string TicketName { get; set; }

        [JsonProperty("ticket_sale_price")]
        public long TicketSalePrice { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("custom_form")]
        public object[] CustomForm { get; set; }

        [JsonProperty("checkin")]
        public Checkin[] Checkin { get; set; }
    }

    public partial class Checkin
    {
        [JsonProperty("checkin_id")]
        public long CheckinId { get; set; }

        [JsonProperty("check_in")]
        public bool CheckIn { get; set; }

        [JsonProperty("check_in_date")]
        public object CheckInDate { get; set; }
    }

    public partial class Pagination
    {
        [JsonProperty("has_next")]
        public bool HasNext { get; set; }

        [JsonProperty("has_prev")]
        public bool HasPrev { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        [JsonProperty("total_page")]
        public long TotalPage { get; set; }
    }

    public partial class Sort
    {
        [JsonProperty("field_sort")]
        public string FieldSort { get; set; }

        [JsonProperty("sort")]
        public string SortSort { get; set; }
    }
}