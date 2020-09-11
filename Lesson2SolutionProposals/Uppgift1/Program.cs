using System;

namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ditt namn > ");
            string name = Console.ReadLine();

            Console.Write("Ange din ålder > ");
            string ageString = Console.ReadLine();
            // Console.ReadLine() returnerar alltid ett string värde
            // vilket kan ses genom att hovra över ReadLine()

            int age = int.Parse(ageString);
            // Det inmatade string-värdet måste konverteras till en
            // heltalsdatatyp (int) för att vi ska kunna göra beräkningar.

            Console.Write("Ange din ort > ");
            string city = Console.ReadLine();

            string story =
                $"Det var en gång elev som hette {name}.\n" +
                $"En dag var hen ute på promenad i {city} och träffade en katt.\n" +
                "Katten frågade: - Vem är du?\n" +
                $"Eleven svarade: - Jag heter {name} och jag är {age} år gammal.\n" +
                $"Katten sa: - Du verkar trevlig och ditt namn {name} låter sympatiskt.\n" +
                $"Katten fortsatte: - Jag {age - 8} år yngre än du är, men vi kan nog bli vänner.\n" +
                $"Eleven sa: - Låt oss slå följe i {city}.\n" +
                "Så var sagan slut.\n";
            // "\n" är en så kallad escape sequence som signalerar en radbrytning.

            Console.Write("Önskar du använda ordet \"hon\" eller \"han\" istället för ordet \"hen\" (J/N)?");
            string reply = Console.ReadLine();

            if (reply.ToLower() == "j")
            {
                Console.WriteLine("1. Ersätt \"hen\" med \"hon\".");
                Console.WriteLine("2. Ersätt \"hen\" med \"han\".");
                Console.Write("-> ");
                reply = Console.ReadLine();
                string gender = string.Empty;

                switch (reply)
                {
                    case "1":
                        gender = "hon";
                        break;
                    case "2":
                        gender = "han";
                        break;
                    default:
                        gender = "hen";
                        break;
                }

                if (gender != "hen")
                    story = story.Replace("hen", gender);
            }

            Console.WriteLine($"\n{story}");
        }
    }
}
