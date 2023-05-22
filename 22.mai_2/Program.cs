using System;
using System.Runtime.ConstrainedExecution;

namespace _22.mai_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            //A246
            // Inheritance asub klassis 'TrainAndVehicle'.
            // Koolon tähistabki seda, et tegu on inheritance'ga e. pärand.
            // Inheritance on see, et mingi alamobjekt või mingi osa, mis kuulub mingi määratud kindla
            // objekti hulka, kus asuvad ka teised alamobjektid (osad) e. osa on niinõnda siis pärija.
            // See näitab, et ta on ühendatud ja kuulub selle hulka.
            // Näiteks see sama 'train' on alamobjekt (pärija), mis kuulub kindla määratud masina hulka 'vehicle'.
            // Ehk rong pärib masinat.
            
            // Create a myCar object
            Train myTrain = new Train();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myTrain.honkTrain();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myTrain.brand + " " + myTrain.modelName);

        }
    }
}