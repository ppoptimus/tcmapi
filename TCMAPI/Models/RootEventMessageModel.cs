﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TCMAPI.Models
{
    public class RootEventMessageModel
    {
        public string destination { get; set; }
        public List<Event> events { get; set; }
    }
    public class Source
    {
        public string type { get; set; }
        public string userId { get; set; }
    }

    public class Emoji
    {
        public int index { get; set; }
        public int length { get; set; }
        public string productId { get; set; }
        public string emojiId { get; set; }
    }

    public class Mentionee
    {
        public int index { get; set; }
        public int length { get; set; }
        public string userId { get; set; }
    }

    public class Mention
    {
        public List<Mentionee> mentionees { get; set; }
    }

    public class Message
    {
        public string id { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string title { get; set; }
        public string address { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public List<Emoji> emojis { get; set; }
        public Mention mention { get; set; }
    }

    public class Event
    {
        public string replyToken { get; set; }
        public string type { get; set; }
        public string mode { get; set; }
        public long timestamp { get; set; }
        public Source source { get; set; }
        public Message message { get; set; }
        public Postback postback { get; set; }
    }

    public class Postback
    {
        public string data { get; set; }
        public Params @params { get; set; }
    }

    public class Params
    {
        public string datetime { get; set; }
    }
}
