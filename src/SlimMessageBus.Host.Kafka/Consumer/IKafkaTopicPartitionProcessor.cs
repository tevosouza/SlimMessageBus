using System;
using System.Threading.Tasks;
using Confluent.Kafka;

namespace SlimMessageBus.Host.Kafka
{
    /// <summary>
    /// The processor of assigned partition (<see cref="TopicPartition"/>).
    /// </summary>
    public interface IKafkaTopicPartitionProcessor : IDisposable
    {        
        TopicPartition TopicPartition { get; }

        Task OnMessage(Message message);
        Task OnPartitionEndReached(TopicPartitionOffset offset);
        Task OnPartitionRevoked();
    }
}