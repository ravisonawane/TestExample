using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftSeat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the aircraft row size.");
            int.TryParse(Console.ReadLine(), out int totalRows);
            Console.WriteLine("Enter no of seat to book.");
            int.TryParse(Console.ReadLine(), out int seatToBook);
            int totalSeats = totalRows * 4;


            int booked = seatToBook < totalSeats? seatToBook : totalSeats;
            Console.WriteLine($"{booked} : aisle seat booked");
            if(totalSeats < seatToBook)
            {
                Console.Write($"{seatToBook - totalSeats } : aisle seat not booked");
            }

            Console.Read();
        }
    }
}
