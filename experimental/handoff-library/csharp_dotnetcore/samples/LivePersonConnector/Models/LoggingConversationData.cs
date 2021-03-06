// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Microsoft.Bot.Schema;

namespace LivePersonProxyBot.Bots
{
    public class LoggingConversationData
    {
        public List<Activity> ConversationLog { get; set; } = new List<Activity>();
    }
}