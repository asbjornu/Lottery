namespace Lottery.Web;

public static class Extensions
{
    private static readonly Random Random = new Random();

    public static T SelectRandom<T>(this IEnumerable<T> enumerable)
    {
        if (enumerable == null)
        {
            throw new ArgumentNullException(nameof(enumerable));
        }

        var collection = enumerable as ICollection<T> ?? enumerable.ToArray();

        if (!collection.Any())
        {
            throw new ArgumentException("The enumerable is empty.");
        }

        return collection.ElementAt(Random.Next(collection.Count));
    }
}
