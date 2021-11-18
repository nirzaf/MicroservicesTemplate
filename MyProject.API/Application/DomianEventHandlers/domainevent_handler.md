#Domain event handlers

the events raised within the domian is using the `INotificationHandler<T>` from the [Mediatr](https://github.com/jbogard/MediatR "MediatR") library.

	public class OrderShippedDomainEventHandler : INotificationHandler<OrderShippedDomainEvent>
    {
		//handle event
		//save data
		//interact with outser microservices
	}