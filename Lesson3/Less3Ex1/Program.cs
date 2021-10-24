using System;

namespace Less3Ex1
{
    /*
        Долгуев Владимир.
        1. В класс банковский счет, созданный в упражнениях, добавить метод, который переводит деньги с одного счета на другой.
        У метода два параметра: ссылка на объект класса банковский счет, откуда снимаются деньги, второй параметр – сумма.
     */

    internal class Program
    {
        private static void Main()
        {
            var account = new BankAccount(1000, AccountType.Savings);
            Console.WriteLine(account);

            var newAccount = new BankAccount(1000, AccountType.Savings);
            Console.WriteLine(newAccount);

            account.TransferFrom(ref newAccount, 500);
            Console.WriteLine($"Переводим 500 рублей со счета {newAccount.Id} на счет {account.Id}.");
            Console.WriteLine(account);
            Console.WriteLine(newAccount);

            BankAccount a = null;

            account.TransferFrom(ref a, 500);

            Console.ReadKey();
        }
    }
}