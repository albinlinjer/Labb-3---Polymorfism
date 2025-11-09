using System.Drawing;

namespace Labb_3___Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Här använder vi polymorfism: 
            // Vi deklarerar objekten som Geometry men instansierar dem som olika underklasser
            List<Geometry> shapes = new List<Geometry>
        {
            new Circle(),
            new Rectangle(),
            new Square()
        };

            // Loopar igenom alla objekt och anropar Area()
            foreach (Geometry shape in shapes)
            {
                // Polymorfism gör att rätt Area()-metod anropas beroende på objektets typ
                // La till "F0" = avrunda till heltal
                Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area():F0}");
            }
        }
    }
}
