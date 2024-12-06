namespace BankApp.Accounts;

/// <summary>
/// Интерфейс для учетной записи.
/// Определяет общий функционал для всех типов учетных записей.
/// </summary>
public interface IAccount
{
    /// <summary>
    /// Баланс учетной записи.
    /// </summary>
    double Balance { get; set; }

    /// <summary>
    /// Процентная ставка, рассчитанная для учетной записи.
    /// </summary>
    double Interest { get; }
    
    /// <summary>
    /// Рассчитывает процентную ставку для текущей учетной записи.
    /// </summary>
    void CalculateInterest();
}