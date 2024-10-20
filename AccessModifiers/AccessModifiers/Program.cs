﻿namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singer singer = new Singer();
            singer.Name = "Michael";
            singer.Surname = "Jackson";
            singer.Age = 50;
            Console.WriteLine($"Müğənni: {singer.Name}, Soyadı: {singer.Surname}, Yaşı: {singer.Age}");

            Song song = new Song();
            song.Name = "Thriller";
            song.Genre = "Pop";
            song.singer = singer;

            Console.WriteLine($"Mahnı Adı: {song.Name}, Janrı: {song.Genre}, Müğənni: {song.singer.Name} {song.singer.Surname}");

            song.AddRating(5.0f);
            song.AddRating(4.5f);
            song.AddRating(3.8f);

            Console.WriteLine($"Ortalama rating: {song.GetAverageRating()}");
            



        }
    }
}
