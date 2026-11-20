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
        if (seatNumber == 0 || seatNumber > _reservedSeats.Length) throw new ArgumentOutOfRangeException();
        if (_reservedSeats[seatNumber - 1]) return false;
        _reservedSeats[seatNumber - 1] = true;
        return true;
    }

    public int GetAvailableSeatCount()
    {
        return _reservedSeats.Where(seat => !seat).Count();
    }
}