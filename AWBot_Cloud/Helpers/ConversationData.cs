﻿namespace AWBot_Cloud.Helpers
{
    public class ConversationData
    {
        public string Timestamp { get; set; }

        public string ChannelId { get; set; }

        public bool PromptedUserForName { get; set; } = false;
    }
}
