namespace c_sharp_challenges;

public class ShoppingCart
{
    private readonly List<decimal> _prices = new();

    public void AddItem(decimal price)
    {
        if (price < 0) throw new ArgumentException("Price must be greater than 0");
        _prices.Add(price);
    }

    public decimal GetTotal()
    {
        if (_prices.Count == 0) return 0;
        return _prices.Sum();
    }

    public int GetItemCount()
    {
        if (_prices.Count == 0) return 0;
        return _prices.Count;
    }
}