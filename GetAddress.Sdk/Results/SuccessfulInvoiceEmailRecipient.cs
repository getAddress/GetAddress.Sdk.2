﻿using Newtonsoft.Json;

namespace GetAddress.Sdk
{
    public class SuccessfulInvoiceEmailRecipient
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email-address")]
        public string EmailAddress { get; set; }
    }
}
