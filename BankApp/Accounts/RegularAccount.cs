namespace BankApp.Accounts;

/// <summary>
/// Класс для обычной учетной записи.
/// </summary>
public class RegularAccount : IAccount
{
    public double Balance { get; set; }
    public double Interest { get; private set; }

    /// <summary>
    /// Рассчитывает процентную ставку для обычной учетной записи.
    /// Ставка зависит от баланса: меньше 1000 — снижение, больше или равно 1000 — другое снижение.
    /// </summary>
    public void CalculateInterest()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
        {
            Interest -= Balance * 0.2;
        }
        else
        {
            Interest -= Balance * 0.1;
        }
    }
}