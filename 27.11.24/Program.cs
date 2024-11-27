
namespace _27._11._24
{

    class Play : IDisposable
    {
        #region Areas
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int PublicDate { get; set; }
        #endregion

        #region Constr|Final
        public Play() { }
        public Play(string name, string author, string genre, int publicDate)
        {
            Name = name;
            Author = author;
            Genre = genre;
            if (publicDate < 0 || publicDate > 2024)
                throw new Exception("Invalid date");
            else
                PublicDate = publicDate;
        }
        ~Play()
        {
            Console.WriteLine("All areas deleted");
        }

        #endregion

        public override string ToString()
        {
            return "Play: " + Name + "\n" + "Author: " + Author + "\n" + "Genre: " + Genre + "\n" + "PublicDate: " + PublicDate + "\n";
        }

        public void Dispose()
        {
            Console.WriteLine("Space cleared");
        }
    }

    class Shop : IDisposable
    {
        #region Areas
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Type { get; set; }
        #endregion
        #region Constr|Disp
        public Shop() { }
        public Shop(string name, string adress, string type)
        {
            Name = name;
            Adress = adress;
            Type = type;
        }

        public void Dispose()
        {
            Console.WriteLine("Space clearing");
        }
        #endregion
        ~Shop()
        {
            Console.WriteLine("All areas deleted");
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
