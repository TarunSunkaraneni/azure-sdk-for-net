// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class ItsmReceiver : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("workspaceId");
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("connectionId");
            writer.WriteStringValue(ConnectionId);
            writer.WritePropertyName("ticketConfiguration");
            writer.WriteStringValue(TicketConfiguration);
            writer.WritePropertyName("region");
            writer.WriteStringValue(Region);
            writer.WriteEndObject();
        }

        internal static ItsmReceiver DeserializeItsmReceiver(JsonElement element)
        {
            string name = default;
            string workspaceId = default;
            string connectionId = default;
            string ticketConfiguration = default;
            string region = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceId"))
                {
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionId"))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketConfiguration"))
                {
                    ticketConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"))
                {
                    region = property.Value.GetString();
                    continue;
                }
            }
            return new ItsmReceiver(name, workspaceId, connectionId, ticketConfiguration, region);
        }
    }
}