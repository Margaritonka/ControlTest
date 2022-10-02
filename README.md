# Итоговая Контрольная Работа #

## Условия задачи: ##

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## Алгоритм решения ##

1. Задан первый массив из строк.

2. Написан алгоритм по подсчёту количества подходящих под условие задачи элементов первого массива, для создания второго массива определённой размерности.
Пробегаясь по всем элементам первого массива, мы проверяем каждый элемент на соответствие условию задачи (количество символов <= трём). При соблюдении этого условия добавляем 1 к переменой sum. В конце этого цикла переменная sum содержит количество нужных элементов из первого массива.

3. Создан второй массив размерностью sum.

4. Написан алгоритм по копированию нужных элементов из первого массива во второй.
Так же пробегаемся по всем элементам первого массива и делаем ту же проверку на соответствие элементов условию задачи (количество символов <= трём) и копируем нужные элементы в новый массив.

5. Вывод решения - печать второго массива.