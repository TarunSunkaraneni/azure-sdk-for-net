﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;

#nullable enable

namespace Azure.Core.Pipeline
{
    internal partial class ClientDiagnostics
    {
        partial void ExtractFailureContent(
            string? content,
            ref string? message,
            ref string? errorCode,
#pragma warning disable CA1801 // additionalInfo is not used at this time
            ref IDictionary<string, string>? additionalInfo)
#pragma warning restore CA1801
        {
            if (!string.IsNullOrEmpty(content))
            {
                try
                {
                    using JsonDocument doc = JsonDocument.Parse(content);
                    if (doc.RootElement.TryGetProperty("error", out JsonElement errorElement))
                    {
                        foreach (JsonProperty property in errorElement.EnumerateObject())
                        {
                            switch (property.Name)
                            {
                                case "code":
                                    errorCode = property.Value.GetString();
                                    break;

                                case "message":
                                    message = property.Value.GetString();
                                    break;
                            }
                        }
                    }
                }
                catch (JsonException)
                {
                }
            }
        }
    }
}