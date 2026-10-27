using System;

    internal class Movie
    {
    public int Number { get; set; }
    public string Title { get; set; }
    public int Year { get; set; }
    public Genre MovieGenre { get; set; }
    public int Views { get; set; }
    public int Likes { get; set; }

    public Movie(int Number, string Title, int Year,Genre MovieGenre,int Views,int Likes)
    {
        if (Views <= 0 || Likes <= 0 || Year <= 1900 || Year >= 2027)
        {
            throw new ArgumentException();
        }
        this.Number = Number;
        this.Title = Title;
       this.Year = Year;
        this.MovieGenre = MovieGenre;
        this.Views = Views;
        this.Likes = Likes;
    }

    public double CalculateRating()
    {
        return Math.Sqrt((Math.Pow(Likes, 2) / Views));
    }

    public override string ToString()
    {
        string yearFormatted = $"({Year})";
        double rating = CalculateRating();
        return $"{Number,4} {Title,-15} {yearFormatted,-8} {MovieGenre,-12} {rating,8:F3}";
    }
}

