using System.Text;

namespace Less7Ex1
{
    /*
     * Создать класс BCoder, реализующий интерфейс ICoder.
     * Класс шифрует строку, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции, на букву того же регистра,
     * расположенную в алфавите на i-й позиции с конца алфавита.
     * (Например, буква В заменяется на букву Э.
     *
     * По факту, методы кодирования и декодирования - один и тот же метод.
     * Если в первом мы меняем В на Э, то во втором обратно меняем Э на В. Работа метода одна и та же.
     */

    public class BCoder : ICoder
    {
        private const string UpperAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string DownerAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string _upperString;
        private string _workAlphabet;
        private StringBuilder _sr;
        private bool _isFound;

        public string Decode(string baseString)
        {
            return Coding(baseString);
        }

        public string Encode(string baseString)
        {
            return Coding(baseString);
        }

        private string Coding(string baseString)
        {
            _sr = new StringBuilder();
            _upperString = baseString.ToUpper();
            for (int i = 0; i < baseString.Length; i++)
            {
                _isFound = false;
                // если символ равен символу в ToUpper строке, то мы имеем дело с UpperAlphabet. Иначе с DownerAlphabet.
                _workAlphabet = baseString[i] == _upperString[i] ? UpperAlphabet : DownerAlphabet;
                for (int j = 0; j < _workAlphabet.Length; j++)
                {
                    if (baseString[i] != _workAlphabet[j]) continue;
                    _sr.Append(_workAlphabet[_workAlphabet.Length - 1 - j]);
                    _isFound = true;
                    break;
                }
                // если в алфавитах ничего не нашли, то оставляем символ как есть
                if (!_isFound)
                {
                    _sr.Append(baseString[i]);
                }
            }
            return _sr.ToString();
        }
    }
}