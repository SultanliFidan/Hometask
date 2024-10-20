namespace AccessModifiers
{
     class Song
    {
        private string _name;
        private string _genre;
        public Singer singer;
        public float[] ratings;

        public Song()
        {
            ratings = new float[0];
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length >0 && value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Ad 100-den boyuk ola bilmez");
                }
            }
        }

        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                string[] genres = { "Pop", "Rock", "Jazz", "Techno" };
                if(genres.Contains(value))
                {
                    _genre = value;
                }
                else
                {
                    Console.WriteLine("Genre yanliz Pop, Rock, Jazz, Techno ola biler ");
                }
            }
        }
        
        

        public void AddRating(float rating)
        {
            if (rating >=0 && rating <=5)
            {
                Array.Resize(ref ratings, ratings.Length + 1);
                ratings[ratings.Length - 1] = rating;
            }
            else
            {
                Console.WriteLine("Rating 0-5 araliginda olmalidir");
            }
        }

        public float GetAverageRating()
        {
            float sum = 0;
            if (ratings.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < ratings.Length; i++)
            {
               sum += ratings [i];
               
            }
            return sum/ratings.Length;

            
        }


    }
}
