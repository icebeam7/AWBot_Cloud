using System;
using Microsoft.Bot.Builder;

namespace AWBot_Cloud
{
    public class AdventureWorksBotAccessors
    {
        public AdventureWorksBotAccessors(ConversationState conversationState)
        {
            ConversationState = conversationState ?? throw new ArgumentNullException(nameof(conversationState));
        }

        public static string CounterStateName { get; } = $"{nameof(AdventureWorksBotAccessors)}.CounterState";

        public IStatePropertyAccessor<CounterState> CounterState { get; set; }

        public ConversationState ConversationState { get; }
    }
}