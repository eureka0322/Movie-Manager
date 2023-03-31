﻿using Microsoft.EntityFrameworkCore;

namespace MovieManager.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Genre = "Action", Title = "Uncharted", ReleaseYear = "2022" },
                new Movie { Id = 2, Genre = "Action", Title = "Shang-Chi and the Legend of the Ten Rings", ReleaseYear = "2021" },
                new Movie { Id = 3, Genre = "Action", Title = "Spider-Man: No Way Home", ReleaseYear = "2022" },
                new Movie { Id = 4, Genre = "Action", Title = "John Wick", ReleaseYear = "2023" },
                new Movie { Id = 5, Genre = "Action", Title = "Captain Marvel", ReleaseYear = "2019" },
                new Movie { Id = 6, Genre = "Action", Title = "Alita: Battle Angel", ReleaseYear = "2019" },
                new Movie { Id = 7, Genre = "Action", Title = "Demon Slayer the Movie: Mugen Train", ReleaseYear = "2020" },
                new Movie { Id = 8, Genre = "Action", Title = "Dragon Ball Super: Broly", ReleaseYear = "2018" },
                new Movie { Id = 9, Genre = "Action", Title = "Dragon Ball Super: Super Hero", ReleaseYear = "2022" },
                new Movie { Id = 10, Genre = "Action", Title = "Jujutsu Kaisen 0", ReleaseYear = "2021" },
                new Movie { Id = 11, Genre = "Action", Title = "Akira", ReleaseYear = "1988" },
                new Movie { Id = 12, Genre = "Adventure", Title = "Interstellar", ReleaseYear = "2014" },
                new Movie { Id = 13, Genre = "Adventure", Title = "Life of Pi", ReleaseYear = "2012" },
                new Movie { Id = 14, Genre = "Adventure", Title = "The Batman", ReleaseYear = "2022" },
                new Movie { Id = 15, Genre = "Adventure", Title = "The Martian", ReleaseYear = "2015" },
                new Movie { Id = 16, Genre = "Adventure", Title = "E.T. the Extra-Terrestrial", ReleaseYear = "1982" },
                new Movie { Id = 17, Genre = "Adventure", Title = "The Jungle Book", ReleaseYear = "2016" },
                new Movie { Id = 18, Genre = "Adventure", Title = "Paprika", ReleaseYear = "2006" },
                new Movie { Id = 19, Genre = "Adventure", Title = "Spirited Away", ReleaseYear = "2001" },
                new Movie { Id = 20, Genre = "Adventure", Title = "The Cat Returns", ReleaseYear = "2002" },
                new Movie { Id = 21, Genre = "Adventure", Title = "Princess Mononoke", ReleaseYear = "1997" },
                new Movie { Id = 22, Genre = "Comedy", Title = "Baywatch", ReleaseYear = "2017" },
                new Movie { Id = 23, Genre = "Comedy", Title = "Rush Hour", ReleaseYear = "1998" },
                new Movie { Id = 24, Genre = "Comedy", Title = "Rush Hour 2", ReleaseYear = "2001" },
                new Movie { Id = 25, Genre = "Comedy", Title = "Rush Hour 3", ReleaseYear = "2007" },
                new Movie { Id = 26, Genre = "Comedy", Title = "Bad Boys", ReleaseYear = "1995" },
                new Movie { Id = 27, Genre = "Comedy", Title = "Bad Boys 2", ReleaseYear = "2003" },
                new Movie { Id = 28, Genre = "Comedy", Title = "Gintama Movie: Kanketsu-hen", ReleaseYear = "2013" },
                new Movie { Id = 29, Genre = "Comedy", Title = "Konosuba: God's Blessing On This Wonderful World!", ReleaseYear = "2016" },
                new Movie { Id = 30, Genre = "Comedy", Title = "Haven't You Heard? I'm SAKAMOTO", ReleaseYear = "2016" },
                new Movie { Id = 31, Genre = "Comedy", Title = "K On! Movie", ReleaseYear = "2013" },
                new Movie { Id = 32, Genre = "Mystery", Title = "Hit", ReleaseYear = "2020" },
                new Movie { Id = 33, Genre = "Mystery", Title = "Vikram", ReleaseYear = "2022" },
                new Movie { Id = 34, Genre = "Mystery", Title = "Freddy", ReleaseYear = "2022" },
                new Movie { Id = 35, Genre = "Mystery", Title = "Source Code", ReleaseYear = "2011" },
                new Movie { Id = 36, Genre = "Mystery", Title = "Talaash: The Answer Lies Within", ReleaseYear = "2012" },
                new Movie { Id = 37, Genre = "Mystery", Title = "American Psycho", ReleaseYear = "2000" },
                new Movie { Id = 38, Genre = "Mystery", Title = "Perfect Blue", ReleaseYear = "1997" },
                new Movie { Id = 39, Genre = "Mystery", Title = "Erased", ReleaseYear = "2016" },
                new Movie { Id = 40, Genre = "Mystery", Title = "When Marnie Was There ", ReleaseYear = "2020" },
                new Movie { Id = 41, Genre = "Mystery", Title = "The Girl Who Leapt Through Time", ReleaseYear = "2006" },
                new Movie { Id = 42, Genre = "Romantic", Title = "Magadheera", ReleaseYear = "2009" },
                new Movie { Id = 43, Genre = "Romantic", Title = "Gurthunda Seethakalam", ReleaseYear = "2022" },
                new Movie { Id = 44, Genre = "Romantic", Title = "Ghajini", ReleaseYear = "2008" },
                new Movie { Id = 45, Genre = "Romantic", Title = "Arjun Reddy", ReleaseYear = "2017" },
                new Movie { Id = 46, Genre = "Romantic", Title = "Sita Ramam", ReleaseYear = "2009" },
                new Movie { Id = 47, Genre = "Romantic", Title = "Geetha Govindam", ReleaseYear = "2018" },
                new Movie { Id = 48, Genre = "Romantic", Title = "Tamako Love Story", ReleaseYear = "2014" },
                new Movie { Id = 49, Genre = "Romantic", Title = "I Want to Eat Your Pancreas", ReleaseYear = "2018" },
                new Movie { Id = 50, Genre = "Romantic", Title = "Your Name", ReleaseYear = "2017" },
                new Movie { Id = 51, Genre = "Romantic", Title = "5 Centimeters per Second", ReleaseYear = "2007" },
                new Movie { Id = 52, Genre = "Drama", Title = "Rangasthalam", ReleaseYear = "2018" },
                new Movie { Id = 53, Genre = "Drama", Title = "Uri: The Surgical Strike", ReleaseYear = "2019" },
                new Movie { Id = 54, Genre = "Drama", Title = "Kesari", ReleaseYear = "2019" },
                new Movie { Id = 55, Genre = "Drama", Title = "Parmanu: The Story of Pokhran", ReleaseYear = "2018" },
                new Movie { Id = 56, Genre = "Drama", Title = "Raazi", ReleaseYear = "2018" },
                new Movie { Id = 57, Genre = "Drama", Title = "Dangal", ReleaseYear = "2016" },
                new Movie { Id = 58, Genre = "Drama", Title = "Singham", ReleaseYear = "2011" },
                new Movie { Id = 59, Genre = "Drama", Title = "Bhavesh Joshi Superhero", ReleaseYear = "2018" },
                new Movie { Id = 60, Genre = "Drama", Title = "Badlapur", ReleaseYear = "2015" },
                new Movie { Id = 61, Genre = "Drama", Title = "RRR", ReleaseYear = "2022" },
                new Movie { Id = 62, Genre = "Horror", Title = "I Am Legend", ReleaseYear = "2007" },
                new Movie { Id = 63, Genre = "Horror", Title = "Prey", ReleaseYear = "2022" },
                new Movie { Id = 64, Genre = "Horror", Title = "Cloverfield", ReleaseYear = "2008" },
                new Movie { Id = 65, Genre = "Horror", Title = "World War Z", ReleaseYear = "2013" },
                new Movie { Id = 66, Genre = "Horror", Title = "The Exorcist", ReleaseYear = "1973" },
                new Movie { Id = 67, Genre = "Horror", Title = "As Above, So Below", ReleaseYear = "2014" },
                new Movie { Id = 68, Genre = "Horror", Title = "Paranormal Activity", ReleaseYear = "2021" },
                new Movie { Id = 69, Genre = "Horror", Title = "The Blair Witch Project", ReleaseYear = "1999" },
                new Movie { Id = 70, Genre = "Horror", Title = "Insidious", ReleaseYear = "2010" },
                new Movie { Id = 71, Genre = "Horror", Title = "The Grudge", ReleaseYear = "2004" }
            );
        }
    }
}
