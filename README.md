Задача решена в функциональном стиле двумя способами.  
Программный код включает в себя три функции: 1-й вариант решения, 2-й вариант решения и главная функция, которая является точкой входа в программу и содержит вызовы первых двух функций.  
Варианты различаются реализацией.  
Результаты (исходные массивы и выборки) выводятся на консоль.  
Программный код снабжен комментариями, поясняющими назначение инструкций.   
  

*1-й вариант.*  
Для поиска строк в исходном массиве, длина которых не более заданного числа символов, используется статический метод FindAll класса Array с лямбда-функцией, выполняющей роль предиката для выбора подходящих элементов.  
*2-й вариант.*  
Задача решается посредством обхода исходного массива в цикле и выбора подходящих строк с помощью условного оператора if, задающего критерий. Строки, удовлетворяющие критерию (если таковые имеются), сохраняются в новом массиве, который считается целевым. Данный способ представлен на рисунке в виде блок-схемы алгоритма функции - файл Program_Block_Diagram.jpeg, который можно просмотреть по ссылке ниже (либо открыв непосредственно)

[Function_Block_Diagram](https://drive.google.com/file/d/100-9e_WYjA1kLjxWyLCoS_SfxCLHm8kL/view?usp=drive_link)
  
![Function_Block_Diagram](https://drive.google.com/file/d/100-9e_WYjA1kLjxWyLCoS_SfxCLHm8kL/view?usp=drive_link "Function_Block_Diagram")
