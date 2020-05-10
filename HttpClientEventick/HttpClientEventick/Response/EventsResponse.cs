using System;
using Newtonsoft.Json;

namespace HttpClientEventick.Response
{
    public partial class EventsResponse
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

        [JsonProperty("start_date")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTimeOffset EndDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }

        [JsonProperty("private_event")]
        public bool PrivateEvent { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }

        [JsonProperty("host")]
        public Host Host { get; set; }

        [JsonProperty("category_prim")]
        public Category CategoryPrim { get; set; }

        [JsonProperty("category_sec")]
        public Category CategorySec { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string AddressAddress { get; set; }

        [JsonProperty("address_num")]
        public string AddressNum { get; set; }

        [JsonProperty("address_alt")]
        public string AddressAlt { get; set; }

        [JsonProperty("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Host
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
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
