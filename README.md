## ИТОГОВАЯ КОНТРОЛЬНАЯ РАБОТА ПО ОСНОВНОМУ БЛОКУ
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

**1. Ввод данных и инициализация переменных**
- *Пользователь вводит строку, содержащую элементы массива, разделенные запятой.*
- *Строка разбивается на массив строк.*
- *Создаются переменные для подсчета количества подходящих строк (count) и для индексации нового массива (index).*

**2. Первый проход**
- *Используется цикл для прохода по каждому элементу входного массива.*
- *Если длина текущей строки меньше или равна 3, увеличивается счетчик count.*

**3. Создание нового массива и второй проход**
- *Создается новый массив строк размером count.*
- *Используется еще один цикл для прохода по входному массиву.*
- *Если длина текущей строки меньше или равна 3, эта строка добавляется в новый массив на соответствующую позицию (с использованием переменной index).*
- *Увеличивается index после добавления каждого элемента.*

**4. Вывод результата**
- *Новый массив выводится на экран.*
