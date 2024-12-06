using BankApp.Accounts;
using BankApp.Services;

namespace BankApp;

/// <summary>
/// Точка входа в приложение.
/// Создает учетные записи, рассчитывает процентные ставки и выводит результаты.
/// </summary>
/// <param name="args">Аргументы командной строки.</param>
class Program
{
    static void Main(string[] args)
    {
        var regularAccount = new RegularAccount { Balance = 1200 };
        var salaryAccount = new SalaryAccount { Balance = 2000 };

        Calculator.CalculateInterest(regularAccount);
        Calculator.CalculateInterest(salaryAccount);

        Console.WriteLine($"Процентная ставка для обычного аккаунта: {regularAccount.Interest}");
        Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {salaryAccount.Interest}");
    }
}