// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(EvaluateDataFlowExpressionRequestConverter))]
    public partial class EvaluateDataFlowExpressionRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId");
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(DataFlowName))
            {
                writer.WritePropertyName("dataFlowName");
                writer.WriteStringValue(DataFlowName);
            }
            if (Optional.IsDefined(StreamName))
            {
                writer.WritePropertyName("streamName");
                writer.WriteStringValue(StreamName);
            }
            if (Optional.IsDefined(RowLimits))
            {
                writer.WritePropertyName("rowLimits");
                writer.WriteNumberValue(RowLimits.Value);
            }
            if (Optional.IsDefined(Expression))
            {
                writer.WritePropertyName("expression");
                writer.WriteStringValue(Expression);
            }
            writer.WriteEndObject();
        }

        internal static EvaluateDataFlowExpressionRequest DeserializeEvaluateDataFlowExpressionRequest(JsonElement element)
        {
            Optional<string> sessionId = default;
            Optional<string> dataFlowName = default;
            Optional<string> streamName = default;
            Optional<int> rowLimits = default;
            Optional<string> expression = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataFlowName"))
                {
                    dataFlowName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streamName"))
                {
                    streamName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rowLimits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    rowLimits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("expression"))
                {
                    expression = property.Value.GetString();
                    continue;
                }
            }
            return new EvaluateDataFlowExpressionRequest(sessionId.Value, dataFlowName.Value, streamName.Value, Optional.ToNullable(rowLimits), expression.Value);
        }

        internal partial class EvaluateDataFlowExpressionRequestConverter : JsonConverter<EvaluateDataFlowExpressionRequest>
        {
            public override void Write(Utf8JsonWriter writer, EvaluateDataFlowExpressionRequest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override EvaluateDataFlowExpressionRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeEvaluateDataFlowExpressionRequest(document.RootElement);
            }
        }
    }
}
