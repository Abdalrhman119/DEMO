using System.Diagnostics.CodeAnalysis;

namespace DEMO
{
    class MovieEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie? x, Movie? y)
        {
            return x?.Price.Equals(y?.Price) ?? (y is null ? true : false);
        }

        public int GetHashCode([DisallowNull] Movie obj)
        {
            return obj.Price.GetHashCode();
        }
    }

    internal class Movie : IEquatable<Movie>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Price: {Price}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Movie otherMovie)  
            {
                return Id == otherMovie.Id && Title == otherMovie.Title && Price == otherMovie.Price;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Price);
        }

        public bool Equals(Movie? other)
        {
            throw new NotImplementedException();
        }
    }
}