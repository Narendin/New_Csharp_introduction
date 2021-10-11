using System;

namespace Less2Ex1
{
    /*
        Долгуев Владимир.
        2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
        Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.
     */

    internal class Program
    {
        private static void Main()
        {
            var account = new BankAccount
            {
                Id = 1,
                Balance = 1000,
                AccountType = AccountType.Deposit
            };

            Console.WriteLine(account);

            Console.ReadKey();
        }
    }
}