namespace Exam2._Song_Encryption
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            bool isArtistInvalid = false;
            bool isSongInvalid = false;
            StringBuilder result = new StringBuilder();

            while (text != "end")
            {
                var input = text.Split(':').ToArray();
                string artist = input[0];
                string song = input[1];
                int coefficient = artist.Length;

                if (artist[0] < 65 && artist[0] > 90)
                {
                    break;
                }
                for (int i = 1; i < artist.Length; i++)
                {
                    if (artist[i] < 97 || artist[i] > 122)
                    {
                        if (artist[i] == ' ' || artist[i] == '\'')
                        {
                            continue;
                        }
                        else
                        {
                            isArtistInvalid = true;
                            break;
                        }
                    }
                }
                
                    for (int i = 0; i < song.Length; i++)
                    {
                        if (song[i] < 65 || song[i] > 90)
                        {
                            if (song[i] == ' ')
                            {
                                continue;
                            }                            
                        }
                    else
                    {
                        isSongInvalid = false;
                        break;
                    }
                    }
                
                if (isSongInvalid == false && isArtistInvalid == false)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == ':')
                        {
                            result.Append('@');
                            continue;
                        }                      
                        int number = text[i] + coefficient;                        

                       if (number > 122)
                        {
                            int tes = 122 - text[i];
                            int otherCoef = coefficient - tes - 1;                            
                            number = 97 + otherCoef;
                        }
                        else if (number > 90 || number < 97)
                        {
                            int tes = 90 - text[i];
                            int otherCoef = coefficient - tes - 1;
                            number = 65 + otherCoef;                            
                        }
                        else if (number > 97)
                        {

                        }
                        char forAdd = (char)number;
                        result.Append(forAdd);
                    }
                    Console.WriteLine($"Successful encryption: {result.ToString()}");
                    result = new StringBuilder();
                }

                text = Console.ReadLine();
            }
        }
    }
}
