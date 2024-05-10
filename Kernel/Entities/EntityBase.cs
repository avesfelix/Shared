namespace Kernel.Data;

// This is a base class for domain entities. It has two purposes - marking up the entity objects to be persisted to the data store, and ensuring a consistent implementation of IDs across the entity objects.
public abstract class EntityBase
{
    // Public Properties
    public Guid Id { get; private set; } = Guid.NewGuid();
}
