#Commands

Command implements `IRequest<T>` from the [Mediatr](https://github.com/jbogard/MediatR "MediatR") library. 

	[DataContract]
    public class CreateOrderCommand : IRequest<bool>
    {
    	//Properties...  
	}