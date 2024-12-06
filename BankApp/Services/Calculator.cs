using BankApp.Accounts;

namespace BankApp.Services;

/// <summary>
/// Класс для расчета процентных ставок учетных записей.
/// </summary>
public static class Calculator
{
    /// <summary>
    /// Рассчитывает процентную ставку для указанной учетной записи.
    /// </summary>
    /// <param name="account">Учетная запись, для которой требуется рассчитать процентную ставку.</param>
    public static void CalculateInterest(IAccount account)
    {
        account.CalculateInterest();
    }
}