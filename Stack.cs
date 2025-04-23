using System;
using System.Collections.Generic;

namespace Classes_as_the_basis_of_C__Homework
{
    internal class Stack
    {
        //Доп.задание 3
        /// <summary>
        /// Класс StackItem хранит текущее значение элемента стека и ссылку на предыдущий элемент.
        /// Поле Value хранит значение элемента стека.
        /// Поле Previous ссылается на предыдущий элемент стека.
        /// </summary>
        private class StackItem
        {
            public string Value { get; set; }

            public StackItem Previous { get; set; }

            public StackItem(string value, StackItem previous)
            {
                Value = value;
                Previous = previous;
            }
        }

        /// <summary>
        /// поле для получения количества элементов в стеке
        /// </summary>
        private int size;

        /// <summary>
        /// Поле top указывает на верхний элемент стека.
        /// </summary>
        private StackItem top;

        /// <summary>
        /// Коструктор для добавления элементов
        /// </summary>
        /// <param name="items"></param>
        public Stack(params string[] items)
        {
            foreach (var item in items)
            {
                AddinStask(item);
            }
        }

        /// <summary>
        /// Метод для добавления элемента в StackItem.
        /// Создает новый элемент StackItem, который ссылается на текущий верхний элемент.
        /// Обновляет top на новый элемент и увеличивает размер стека.
        /// </summary>
        /// <param name="items"></param>
        public void AddinStask(string items)
        {
            var newItem = new StackItem(items, top);
            top = newItem;
            size++;
        }

        /// <summary>
        /// Метод PopfromStack проверяет, пуст ли стек. Если он пуст, 
        /// выбрасывается исключение InvalidOperationException с сообщением "Стек пустой". 
        /// Также сохраняет значение верхнего элемента, обновляет top на предыдущий элемент и уменьшает размер стека.
        /// </summary>
        /// <returns>topElement staskList</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public string PopfromStack()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Стек пустой");
            }

            var value = top.Value;
            top = top.Previous;
            size--;
            return value;

        }
        /// <summary>
        /// Возвращает текущее количество элементов в стеке.
        /// </summary>
        public int Size => size;

        /// <summary>
        /// Возвращает значение верхнего элемента, если стек не пустой, иначе возвращает null.
        /// </summary>
        public string Top => IsEmpty() ? "0" : top.Value;

        /// <summary>
        /// Проверяет, пуст ли стек.
        /// </summary>
        /// <returns>bool</returns>
        public bool IsEmpty() => size == 0;

    }
}
