using System.Linq.Expressions;

public static class ExpressionHelper
{
    public static Expression<Func<T, bool>> ExpressionMaker<T>(T model) where T : class
    {
        var props = model.GetType().GetProperties();
        var parameter = Expression.Parameter(typeof(T), "s");
        Expression combinedExp = null;

        foreach (var prop in props)
        {
            var value = prop.GetValue(model);
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                continue;
            }

            var defaultValue = Activator.CreateInstance(prop.PropertyType); // propun default degerini bul (int icin 0 gelir)
            if (object.Equals(value, defaultValue))
            {
                continue; // Default değerleri atla
            }

            var propAccess = Expression.Property(parameter, prop.Name);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(propAccess, constant);
            combinedExp = combinedExp == null ? equality : Expression.AndAlso(combinedExp, equality);
        }


        return Expression.Lambda<Func<T, bool>>(combinedExp, parameter);

    }
}