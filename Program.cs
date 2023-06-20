using static System.Console;
using static System.String;

namespace FirstStageQualification
{
    static class Program
    {
        // Определим функцию, которая в заданном массиве символьных строк осуществляет поиск элементов,
        // содержащих указанное количество символов, и формирует из найденных элементов новый массив. 
        public static string[] GetItemsOfRequiredLength(string[] array, int length)
        {
            string[] matchedItems;  // Объявление ссылки на новый массив для хранения строк из массива array, 
                                    // длина которых <= length (Массив - это ссылочный тип)

            // Применим конструкцию обработки возможных исключений, чтобы избежать аварийного завершения программы:
            try 
            {
                matchedItems = Array.FindAll(array, item => item.Length <= length);
                // Для поиска строк в исходном массиве, длина которых не более length символов,
                // используется статический метод FindAll класса Array с лямбда-функцией,
                // выполняющей роль предиката для выбора подходящих элементов.
                // Данную операцию можно реализовать также посредством обхода исходного массива в цикле
                // и выбора подходящих строк с помощью условного оператора if, задающего критерий.
                return matchedItems;
            }
            catch(ArgumentNullException)
            {
                // Если исходный массив содержит нулевые ссылки (т.к. это массив строк - ссылочных типов),
                // то в качестве результата возвращается пустой массив:
                return Array.Empty<string>();
            }
        }
        
        // Второй вариант реализации на основе цикла.
        public static string[] FetchItemsOfRequiredLength(string[] array, int length)
        {
            string[] matchedItems;
            int count = 0;  // Инициализация счетчика элементов исходного массива, удовлетворяющих критерию выбора

            if (array.Length > 0)   // Если исходный массив не пустой, то ищем в нем строки по критерию:
            {
                for(int i = 0; i < array.Length; i++)   // Линейный поиск строк в исходном массиве
                {
                    if (array[i].Length <= length)
                    {
                        count += 1; // Определение количества подходящих строк
                    }
                }
                // Если есть в исходном массиве строки заданной длины, то формируем из них новый массив:
                if (count > 0)  
                {
                    matchedItems = new string[count];   // Создание массива для хранения выбранных строк

                    // Формирование нового массива из подходящих строк исходного массива (пошагово):
                    for(int i = (array.Length - 1); i >= 0; i--)    // Линейный поиск с конца исходного массива
                    {
                        if (array[i].Length <= length)
                        {
                            matchedItems[count-1] = array[i];   // Фиксирование в целевом массиве с конца
                            count -= 1;
                        }
                    }
                    return matchedItems;
                }
                // Если строки, удовлетворяющие критерию в исходном массиве отсутствуют, то возвращается пустой массив.
                else return Array.Empty<string>();
            }
            else return Array.Empty<string>();
        }

        public static void Main()   // Точка входа в программу
        {
            // Явно зададим исходные массивы символьных строк:
            string[] initialArray1 = {"Габороне", "Кампала", "Бамако", "Биссау", "Уфа", "Мапуто", "Рим", "Чад",
                                     "Нуакшот", "Рио", "Юта"};
            string[] initialArray2 = {"123456", "135", "246", "1234", "6543", "16", "25", "34", "+/-"};
            string[] initialArray3 = {"Росс 128 b", "Глизе 876 d", "Глизе 581 e", "Глизе 667 Cc"};
            string[] initialArray4 = {};
            // Критерий выбора строк из исходных массивов:
            int length = 3;
            WriteLine($"\nSelection criteria: {length} characters");

            WriteLine($"\nInitial array: [{Join(", ", initialArray1)}]");
            var newArray1 = GetItemsOfRequiredLength(initialArray1, length);
            WriteLine($"Selected items array: [{Join(", ", newArray1)}]");

            WriteLine($"\nInitial array: [{Join(", ", initialArray2)}]");
            var newArray2 = FetchItemsOfRequiredLength(initialArray2, length);
            WriteLine($"Selected items array: [{Join(", ", newArray2)}]");

            WriteLine($"\nInitial array: [{Join(", ", initialArray3)}]");
            var newArray3 = GetItemsOfRequiredLength(initialArray3, length);
            WriteLine($"Selected items array: [{Join(", ", newArray3)}]");

            WriteLine($"\nInitial array: [{Join(", ", initialArray4)}]");
            var newArray4 = FetchItemsOfRequiredLength(initialArray4, length);
            WriteLine($"Selected items array: [{Join(", ", newArray4)}]\n");
        }
    }
}
    
