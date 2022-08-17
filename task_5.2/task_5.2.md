#Задание 2. Перестановка слов в предложении


##Что нужно сделать
Пользователь вводит в программе длинное предложение. Каждое слово раздельно одним пробелом. После ввода пользователь нажимает клавишу Enter. Необходимо создать два метода:

-Первый метод разделяет слова в предложении;
-Второй метод меняет эти слова местами (в обратной последовательности). 
   При этом важно учесть, что один метод вызывается внутри другого метода, то есть в методе main вызывается метод cо следующей сигнатурой — ReversWords (string inputPhrase). Внутри этого метода вызывается метод по разделению входной фразы на слова.


##Советы и рекомендации
-Для сложения строк можно использовать конкатенацию строк. Выражение вида ResultString += NewString + “ ” добавит к текущей строке, которая представлена переменной ResultString, новую строку из переменной NewString и также добавит пробел к концу строки. 
-Для реализации алгоритма разделения строки на слова можно воспользоваться рекомендациями из задания 1.


##Что оценивается
Вызов метода по разделению на слова происходит внутри метода, который отвечает непосредственно за инвертирование слов в предложении.