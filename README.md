# final_test
Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение:
1. Задан первый массив 
2. Задан второй массив с длинной первого массива
3. Используется метод SecondArray, в котором:
    
    -*При соблюденных условиях задачи (длина строки меньше либо равна 3 символа), значения соотвествующего индекса первого массива присваиваются значениям во втором массиве.*

    -*При несоответствии условию (длина строки меньше либо равна 3 символа), строка пропускается и не присваивается во второй массив.*

    -*Данный цикл производит проверку по всей длине первого массива.*

    -*Блок-схему метода можно увидеть в файле algorithm_scheme.jpg*

4. Используется метод вывода массива на экран.
