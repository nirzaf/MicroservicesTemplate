#Repositories

all repositories implements interface `IRepository<T>` located in the Domain, where T is of type `IAggregateRoot`

	public class OrderRepository : IRepository<Order>
	{
		//IRepository Methods
	}

where `IRepository<T>` looks like

    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }

