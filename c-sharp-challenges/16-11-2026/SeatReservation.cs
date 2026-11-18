namespace c_sharp_challenges._16_11_2026;

public class SeatReservation
{
    private readonly bool[] _reservedSeats;

    public SeatReservation(int seatCount)
    {
        if (seatCount == 0 || seatCount < 0) throw new ArgumentOutOfRangeException();
        _reservedSeats = new bool[seatCount];
    }

    public bool ReserveSeat(int seatNumber)
    {
        if (seatNumber < 1 || seatNumber > _reservedSeats.Length) throw new ArgumentOutOfRangeException();
        if (!_reservedSeats[seatNumber - 1])
        {
            _reservedSeats[seatNumber - 1] = true;
            return true;
        };
        return false;
    }

    public int GetAvailableSeatCount()
    {
        var availableSeats = _reservedSeats.Where(seat => !seat);
        if (availableSeats.Count() > 0) return availableSeats.Count();
        return 0;
    }
}