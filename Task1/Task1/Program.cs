using Task1.Classes;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car(180, 5);
            Transport plane = new Plane(900, 400, 63.7, 60.93);
            Transport train = new Train(120, 3300, 11);
            Transport truck = new Truck(160, 3, 5000);

            car.Move();
            plane.Move();
            train.Move();
            truck.Move();
        }
    }
}
