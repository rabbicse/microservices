using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Mehedi.Application.SharedKernel.Services;

namespace KYC.EventStore.Infrastructure.Mappings;

internal class EventStoreConfiguration : IEntityTypeConfiguration<EventStoreEvent>
{
    public void Configure(EntityTypeBuilder<EventStoreEvent> builder)
    {
        builder
            .HasKey(eventStore => eventStore.Id);

        builder
            .Property(eventStore => eventStore.Id)
            .IsRequired() // NOT NULL
            .ValueGeneratedNever();

        builder
            .Property(eventStore => eventStore.AggregateId)
            .IsRequired(); // NOT NULL

        builder
            .Property(eventStore => eventStore.MessageType)
            .IsRequired() // NOT NULL
            .HasMaxLength(100);

        builder
            .Property(eventStore => eventStore.Data)
            .IsRequired() // NOT NULL
            .HasComment("JSON serialized event");

        builder
            .Property(eventStore => eventStore.OccurredOn)
            .IsRequired() // NOT NULL
            .HasColumnName("CreatedAt");
    }
}
