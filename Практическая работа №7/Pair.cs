using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа__7
{
    /// <summary>
    /// Класс для сравнения пар чисел с использованием операторов
    /// </summary>
    public class Pair
    {
        /// <summary>
        /// Автоматическое свойство для первого числа пары
        /// </summary>
        public double First { get; set; }
        /// <summary>
        /// Автоматическое свойство для второго числа пары
        /// </summary>
        public double Second { get; set; }

        /// <summary>
        /// Параметризованный конструктор для класс Pair
        /// </summary>
        /// <param name="first">Первое число в паре чисел</param>
        /// <param name="second">Второе число в паре чисел</param>
        public Pair(double first, double second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Метод для установки параметров объекта
        /// </summary>
        /// <param name="first">Первое число в паре чисел</param>
        /// <param name="second">Второе число в паре чисел</param>
        public void SetParams(double first, double second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Перегруженный метод для установки параметров объекта
        /// </summary>
        /// <param name="pair">Переменная обозначающая пару чисел</param>
        public void SetParams(Pair pair)
        {
            First = pair.First;
            Second = pair.Second;
        }

        /// <summary>
        /// Перегруженный оператор для сравнения пар со знаком "больше"
        /// </summary>
        /// <param name="p1">Переменная обозначающая первую пару чисел</param>
        /// <param name="p2">Переменная обозначающая вторую пару чисел</param>
        /// <returns>Результата сравнения пар</returns>
        public static bool operator >(Pair p1, Pair p2)
        {
            return (p1.First > p2.First) || (p1.First == p2.First && p1.Second > p2.Second);
        }

        /// <summary>
        /// Перегруженный оператор для сравнения пар со знаком "меньше"
        /// </summary>
        /// <param name="p1">Переменная обозначающая первую пару чисел</param>
        /// <param name="p2">Переменная обозначающая вторую пару чисел</param>
        /// <returns>Результат сравнения пар</returns>
        public static bool operator <(Pair p1, Pair p2)
        {
            return (p1.First < p2.First) || (p1.First == p2.First && p1.Second < p2.Second);
        }

        /// <summary>
        /// Перегруженный оператор для сравнения пар со знаком "равно"
        /// </summary>
        /// <param name="p1">Переменная обозначающая первую пару чисел</param>
        /// <param name="p2">Переменная обозначающая вторую пару чисел</param>
        /// <returns>Результат сравнения пар</returns>
        public static bool operator ==(Pair p1, Pair p2)
        {
            return p1.First == p2.First && p1.Second == p2.Second;
        }

        /// <summary>
        /// Перегруженный оператор для сравнения пар со знаком "не равно"
        /// </summary>
        /// <param name="p1">Переменная обозначающая первую пару чисел</param>
        /// <param name="p2">Переменная обозначающая вторую пару чисел</param>
        /// <returns>Результат сравнения пар</returns>
        public static bool operator !=(Pair p1, Pair p2)
        {
            return !(p1 == p2);
        }
    }

    public class Fraction : Pair
    {
        /// <summary>
        /// Параметризированный конструктор
        /// </summary>
        /// <param name="first">Первое число в паре чисел</param>
        /// <param name="second">Второе число в паре чисел</param>
        public Fraction(double first, double second) : base(first, second) { }

        /// <summary>
        /// Перегруженный оператор для сложения пар чисел со знаком "плюс"
        /// </summary>
        /// <param name="p1">Переменная обозначающая первую пару чисел</param>
        /// <param name="p2">Переменная обозначающая вторую пару чисел</param>
        /// <returns>Вывод новой пары чисел со сложенными значениями</returns>
        public static Fraction operator +(Fraction p1, Fraction p2)
        {
            double first = p1.First + p2.First;
            double second = p1.Second + p2.Second;

            if(second >= 1)
            {
                first = first + 1;
                second = Math.Round((second - 1), 2);
            }

            return new Fraction(first, second);
        }

        /// <summary>
        /// Переопределение метода
        /// </summary>
        /// <returns>Вывод значений в стринговом типе</returns>
        public override string ToString()
        {
            return $"{First};{Second}";
        }
    }
}
