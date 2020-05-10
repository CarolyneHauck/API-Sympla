using System;
using Newtonsoft.Json;

namespace HttpClientEventick.Response
{
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

