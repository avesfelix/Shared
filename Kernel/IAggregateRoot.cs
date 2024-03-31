namespace Shared.Kernel;

// This is only to be used as a marker interface to identify the 'root' entity for each business concept/schema. The repository implementations will be restricted to operate only on the aggregate root.
public interface IAggregateRoot
{

}
