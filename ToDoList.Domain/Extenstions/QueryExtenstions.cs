using System.Linq.Expressions;

namespace ToDoList.Domain.Extenstions;

public static class QueryExtenstions
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> source, bool condition,
        Expression<Func<T, bool>> predicate)
    {
        return condition ? source.Where(predicate) : source;
    }
}