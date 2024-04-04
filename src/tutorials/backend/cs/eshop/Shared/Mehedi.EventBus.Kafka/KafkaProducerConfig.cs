﻿namespace Mehedi.EventBus.Kafka;


public record KafkaProducerConfig
{
    public KafkaProducerConfig(string kafkaConnectionString, string topicBaseName)
    {
        if (string.IsNullOrWhiteSpace(kafkaConnectionString))
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(kafkaConnectionString));
        if (string.IsNullOrWhiteSpace(topicBaseName))
            throw new ArgumentException("Value cannot be null or whitespace.", nameof(topicBaseName));

        KafkaConnectionString = kafkaConnectionString;
        TopicName = topicBaseName;
    }

    public string KafkaConnectionString { get; }
    public string TopicName { get; }
}

