// Организовать ввод строки, каждое слово в строке отделяется от других слов пробелами,
// их может быть неограниченное количество. Найти самое короткое слово в строке.

Console.Write("Введите текст: ");
string text = Console.ReadLine();
findMin(text); // вызов функции

void findMin(string txt) { // функция поиска минимального слова по длине
    string[] words = text.Split(' '); // разбиение строки по словам 
    int temp = 0;
    string minText = words[1];
        for (int i = 0; i < words.Length; i++)
        {
            if(minText.Length > words[i].Length) {
                minText = words[i];
            }
        }
        for (int i = 0; i < words.Length; i++)
        {
            if(minText == words[i]) {
                temp = i + 1;
                Console.WriteLine($"Самое короткое слово в строке под номером {temp}: {minText}");
            } 
        }
    
}