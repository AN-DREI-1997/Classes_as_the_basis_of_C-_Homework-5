using System;

namespace Classes_as_the_basis_of_C__Homework
{
    internal class Program
    {
        /// <summary>
        /// Метод Main() является
        /// входной точкой работы программы
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            Stack myStack = new("Первый", "Второй", "Третий");

            Console.WriteLine("Размер стека: " + myStack.Size); // Вывод: 3
            Console.WriteLine("Верхний элемент: " + myStack.Top); // Вывод: Третий

            myStack.AddinStask("Четвертый");
            Console.WriteLine("Размер стека после добавления: " + myStack.Size); // Вывод: 4

            Console.WriteLine("Извлеченный элемент: " + myStack.PopfromStack()); // Вывод: Четвертый
            Console.WriteLine("Размер стека после извлечения: " + myStack.Size); // Вывод: 3
            Console.WriteLine("Верхний элемент: " + myStack.Top); // Вывод: Третий

            // Попробуем извлечь все элементы
            myStack.PopfromStack();
            myStack.PopfromStack();
            myStack.PopfromStack();

            try
            {
                myStack.PopfromStack(); // Это вызовет исключение
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message); // Вывод: Стек пустой
            }


            //Првоерка доп.задание 1
            var s1 = new Stack("a", "b", "c");
            var s2 = new Stack("1", "2", "3");
            s1.Merge(s2);
            Console.WriteLine($"Последний элемент из объединенного Stack s1: " + s1.PopfromStack());

        }
    }
}
