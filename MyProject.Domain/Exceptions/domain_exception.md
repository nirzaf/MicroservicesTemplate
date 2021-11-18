#Domain exceptions

each domain entity should have specific exceptions thrown so that other layers that is dependent on the Domain kan act acordingly.

	public class OrderDomainException : Exception
	{
		...
	}