namespace BankApp.Accounts;

/// <summary>
/// Класс для зарплатной учетной записи.
/// </summary>
public class SalaryAccount : IAccount
{
    public double Balance { get; set; }
    public double Interest { get; private set; }

    /// <summary>
    /// Рассчитывает процентную ставку для зарплатной учетной записи.
    /// Всегда фиксированный процент 0.5 от баланса.
    /// </summary>
    public void CalculateInterest()
    {
        Interest = Balance * 0.5;
    }
}