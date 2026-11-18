
using c_sharp_challenges._16_11_2026;

Console.WriteLine("Hello, world");

var seatReservation = new SeatReservation(5);
bool reserved = seatReservation.ReserveSeat(3);
Console.WriteLine(reserved);
Console.WriteLine(seatReservation.GetAvailableSeatCount());

Console.WriteLine(seatReservation.ReserveSeat(3));