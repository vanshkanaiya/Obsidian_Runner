public class GenericSingleton<T> where T : class, new()
{
    static T _instance;
    public static T Instance => _instance ??= new();
}