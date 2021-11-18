namespace MyProject.Domain.Validation
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T entity);
    }
}
