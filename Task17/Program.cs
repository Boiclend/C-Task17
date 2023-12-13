// Организовать ввод строки, каждое слово в строке отделяется от других слов пробелами,
// их может быть неограниченное количество. Найти самое короткое слово в строке.

Console.Write("Введите текст: ");
string text = Console.ReadLine();
findMin(text); // вызов функции

void findMin(string txt) { // функция поиска минимального слова по длине
    string[] words = text.Split(' '); // разбиение строки по словам 
    string minText = words[1];
        for (int i = 0; i < words.Length; i++)
        {
            if(minText.Length > words[i].Length) {
                minText = words[i];
            }
        }
    Console.WriteLine($"Самое маленькое слово в строке: {minText}");
}