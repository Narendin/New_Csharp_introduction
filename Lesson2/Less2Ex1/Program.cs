using System;

namespace Less2Ex1
{
    /*
        Долгуев Владимир.
        5. * Добавить в класс счет в банке два метода: "снять со счета" и "положить на счет".
        Метод "снять со счета" проверяет, возможно ли снять запрашиваемую сумму, и, в случае положительного результата, изменяет баланс.
     */

    internal class Program
    {
        private static void Main()
        {
            var account = new BankAccount(1000, AccountType.Savings);
            Console.WriteLine(account);

            Console.ReadKey();
        }
    }
}