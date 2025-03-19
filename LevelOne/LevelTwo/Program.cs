using System ;
using System.Text;
using System.Globalization;
using Spectre.Console;

    namespace LevelTwo
    {
        class Program
        {

        static void Main (string[] args)
            {   
                CanvasImage image = new CanvasImage("..\\tux.jpg");
                image.MaxWidth(20);
                if (args.Length > 0) {
                    image = new CanvasImage("..\\" + args[0]);
                    image.MaxWidth(int.Parse(args[1]));
                }
                AnsiConsole.Write(image);


            
                
            }
        }
    }
