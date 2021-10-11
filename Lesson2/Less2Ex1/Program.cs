using System;

namespace Less2Ex1
{
    /*
        Долгуев Владимир.
        1. Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
        Предусмотреть методы для доступа к данным – заполнения и чтения.
        Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.
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