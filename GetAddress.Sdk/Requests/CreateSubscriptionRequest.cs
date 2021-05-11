﻿using Newtonsoft.Json;

namespace GetAddress.Sdk
{
    public class CreateSubscriptionRequest
    {
        [JsonProperty("plan_name")]
        public string PlanName
        {
            get; set;
        }

        [JsonProperty("card_id")]
        public string CardId
        {
            get; set;
        }
    }
}
