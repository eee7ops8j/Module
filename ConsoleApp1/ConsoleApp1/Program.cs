using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleofSong
{

    class Program
    {

        public static int x, y, fo = 5;
        //private songs;

        //Song[] songs = new Song[fo];

        private static Song[] songs = new Song[fo];

        public struct Song
        {
            public string Author { get; set; }
            public string Name { get; set; }
            public double Lengthout { get; set; }
            public Genre Genreout;
        }
        public enum Genre
        { Genre1, Genre2, Genre3 }

        static int Cross()
        {
            Console.WriteLine("nomber of song 1-5");
            x = int.Parse(Console.ReadLine());

            if (x < 1 || x > 5)
            {
                Console.WriteLine("Please reenter(wrong namber):");
                Cross();

            }
            else return x;
            return x;
        }
        static int Cross1()
        {
            Console.WriteLine("что изменять:\n1 - Author\n2 - Genreout\n3 - Name\n4 - Lengthout");
            y = int.Parse(Console.ReadLine());
            if (y < 1 || y > 4)
            {
                Console.WriteLine("Please reenter(wrong namber):");
                Cross1();

            }
            else return y;
            return y;

        }


        static void Rev()
        {
            switch (y)
            {
                case 1:
                    Console.WriteLine("New Autor");
                    songs[x].Author = Console.ReadLine();
                    //string nAut = Console.ReadLine();
                    //songs[x].Author = nAut;
                    break;

                //   case 1: 
                case 2: Ganalize(); break;
                //string nGe = Console.ReadLine();
                //songs[x].Genreout = nGe;
                case 3:
                    Console.WriteLine("New Name");
                    string nNa = Console.ReadLine();
                    songs[x].Name = nNa;
                    break;
                case 4:
                    Console.WriteLine("New Lengthout(examble 4,22)");
                    songs[x].Lengthout = double.Parse(Console.ReadLine()); break;
                default: break;

            }
        }
        static void Ganalize()
        {
            Console.WriteLine("Select new ganre:1-{0},2-{1},3-{2}", Genre.Genre1, Genre.Genre2, Genre.Genre3);
            int z = int.Parse(Console.ReadLine());
            if (z < 1 || z > 3)
            {
                Console.WriteLine("Please reenter(wrong namber):");
                Ganalize();

            }
            else switch (z)
                {
                    case 1: songs[x].Genreout = Genre.Genre1; break;
                    case 2: songs[x].Genreout = Genre.Genre2; break;
                    case 3: songs[x].Genreout = Genre.Genre3; break;
                    default: break;
                }


        }

        static void View()
        {
            Console.WriteLine("info - N.array = N.case - 1");

            switch (x)
            {
                case 1: Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[x - 1].Author, songs[x - 1].Name, songs[x - 1].Lengthout, songs[x - 1].Genreout); break;
                case 2: Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[x - 1].Author, songs[x - 1].Name, songs[x - 1].Lengthout, songs[x - 1].Genreout); break;
                case 3: Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[x - 1].Author, songs[x - 1].Name, songs[x - 1].Lengthout, songs[x - 1].Genreout); break;
                case 4: Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[x - 1].Author, songs[x - 1].Name, songs[x - 1].Lengthout, songs[x - 1].Genreout); break;
                case 5: Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[x - 1].Author, songs[x - 1].Name, songs[x - 1].Lengthout, songs[x - 1].Genreout); break;
                default: break;
            }
        }
        static void Init()
        {
            ////fo = 5;

            songs[0].Author = "a0";
            songs[0].Genreout = Genre.Genre1;
            songs[0].Name = "n0";
            songs[0].Lengthout = 2.23;

            songs[1].Author = "a1";
            songs[1].Genreout = Genre.Genre1;
            songs[1].Name = "n1";
            songs[1].Lengthout = 3.23;

            songs[2].Author = "a2";
            songs[2].Genreout = Genre.Genre2;
            songs[2].Name = "n2";
            songs[2].Lengthout = 4.23;

            songs[3].Author = "a3";
            songs[3].Genreout = Genre.Genre1;
            songs[3].Name = "n3";
            songs[3].Lengthout = 5.23;

            songs[4].Author = "a4";
            songs[4].Genreout = Genre.Genre3;
            songs[4].Name = "n4";
            songs[4].Lengthout = 6.23;
        }
        static void Main(string[] args)
        {

            Init();
            //Cross();
            View1();

            //Cross();
            //Cross1();
            //Rev();
            //Cross();
            //View();


            //           1. Изменить название песни по индексу и распечатать все
            //           2. Найдите самую длинную песню и распечатайте информацию об этом
            //           3. Распечатать все песни выбранного жанра
            //           4. Возможность добавлять и удалять новую песню(удалить по индексу)



            Console.ReadKey();

        }
        static void View1()
        {
            Console.WriteLine("1:-Изменить название песни по индексу и распечатать все");
            Console.WriteLine("2:-Найдите самую длинную песню и распечатайте информацию об этом");
            Console.WriteLine("3:-Распечатать все песни выбранного жанра");
            Console.WriteLine("4:-Возможность добавлять и удалять новую песню(удалить по индексу)");
            x = int.Parse(Console.ReadLine());

            if (x < 1 || x > 4)
            {
                Console.WriteLine("Please reenter(wrong namber):");

                Console.Clear(); View1();

            }
            else switch (x)
                {
                    case 1:
                        Cross();
                        View();
                        Cross1();
                        Rev();
                        Cross();
                        View();
                        break;
                    case 2:
                        MaxLSong();
                        break;
                    case 3: ViewGanre(); break;
                    case 4: PlasDel(); break;




                    default:
                        for (int i = 0; i < songs.Length; i++)
                        {
                            Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
                        }
                        break;
                }
        }
        static void MaxLSong()
        {
            int tempi = 0;
            for (int i = 0; i < songs.Length; i++)
            {
                double tempL = 0.0;

                for (int j = songs.Length; j > 1; j--)
                {
                    if (songs[i].Lengthout > songs[j - 1].Lengthout)
                    {
                        tempL = songs[i].Lengthout;
                        tempi = i;
                    }
                }

            }
            Console.WriteLine("maxLength song is Author.{0} Name.{1} Lenght.{2} Genre.{3}", songs[tempi].Author, songs[tempi].Name, songs[tempi].Lengthout, songs[tempi].Genreout);
            Console.ReadLine();
        }
        static void ViewGanre()
        {
            Console.WriteLine("select Ganre\n1 - {0}\n2 - {1}\n3 - {2}", Genre.Genre1, Genre.Genre2, Genre.Genre3);
            x = int.Parse(Console.ReadLine());

            if (x < 1 || x > 3)
            {
                Console.Clear(); ViewGanre();
            }
            else switch (x)
                {
                    case 1:
                        Console.WriteLine("Ganre :{0}", Genre.Genre1);
                        for (int i = 0; i < songs.Length; i++)
                        {
                            if (songs[i].Genreout == Genre.Genre1)
                            {
                                Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2} \nGanre {3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ganre :{0}", Genre.Genre2);
                        for (int i = 0; i < songs.Length; i++)
                        {
                            if (songs[i].Genreout == Genre.Genre2)
                            {
                                Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2} \nGanre {3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ganre :{0}", Genre.Genre3);
                        for (int i = 0; i < songs.Length; i++)
                        {
                            if (songs[i].Genreout == Genre.Genre3)
                            {
                                Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2} \nGanre {3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
                            }
                        }
                        break;

                    default: break;
                }
            Console.ReadLine();

        }
        static void PlasDel()
        {
            Console.WriteLine("selectn \n1 - Del\n2 - Pluss ");
            int f = int.Parse(Console.ReadLine());

            if (f < 1 || f > 2)
            {
                Console.Clear(); PlasDel();
            }
            else switch (f)
                {
                    case 1: Del(); break;
                    case 2: Plus(); break;
                    default: break;
                }
        }
        static void Del()
        {
            Console.WriteLine("old array 0 to {0}", fo);
            Console.WriteLine("select array del");
            int r = int.Parse(Console.ReadLine());
            songs[r].Author = null;
            songs[r].Genreout = 0;
            songs[r].Name = null;
            songs[r].Lengthout = 0;

            //  Array.Clear(songs, r, 1);



            //songs = Array.Resize<Song>(ref songs, new int [fo]);
            //songs = ResizeArray(songs, new int[] {fo});
            //Array.Resize<songs> (Song[] songs, r);
            //
            Console.WriteLine("new array {0}", fo);
            for (int i = 0; i < songs.Length; i++)
            {
                Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
            }

        }
        static void Plus()
        {
            Console.WriteLine("old array {0}", fo);
            fo = fo + 1;
            x = fo;
            Console.WriteLine("new array {0}", fo);

            Array.Resize(ref songs, x);

            Console.WriteLine("New Autor");
            string nAut = Console.ReadLine();
            songs[x].Author = nAut;

            Ganalize();
           
            //Console.WriteLine("Select new ganre:1-{0},2-{1},3-{2}", Genre.Genre1, Genre.Genre2, Genre.Genre3);
            //int z = int.Parse(Console.ReadLine());
            //if (z < 1 || z > 3)
            //{
            //    Console.WriteLine("Please reenter(wrong namber):");
            //    Plus();

            //}
            //else switch (z)
            //    {
            //        case 1: songs[x].Genreout = Genre.Genre1; break;
            //        case 2: songs[x].Genreout = Genre.Genre2; break;
            //        case 3: songs[x].Genreout = Genre.Genre3; break;
            //        default: break;
            //    }
            Console.WriteLine("New Name");
            string nNa = Console.ReadLine();
            songs[x].Name = nNa;
            Console.WriteLine("New Lengthout(examble 4,22)");
            songs[x].Lengthout = double.Parse(Console.ReadLine());
            for (int i = 0; i < songs.Length; i++)//display all
            {
                Console.WriteLine("\nautor :{0} \nname :{1} \nLength :{2}\n Ganre :{3}", songs[i].Author, songs[i].Name, songs[i].Lengthout, songs[i].Genreout);
            }
            Console.ReadLine();
        }

    }
}

