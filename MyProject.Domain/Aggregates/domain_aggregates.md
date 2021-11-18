#Domain model

An aggregate is an encapsulation of entities and value objects (domain objects) which conceptually belong together (Bounded context). 
It should also contain a set of operations which those domain objects can be operated on. An entity without methods is an anemic model.

An aggregate should have one AggregateRoot which can contain other entities and value types.
