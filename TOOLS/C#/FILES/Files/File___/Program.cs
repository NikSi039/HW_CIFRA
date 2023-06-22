// 5 - File


//Класс File реализует похожую функциональность с помощью статических методов:

//Copy(): копирует файл в новое место

//Create(): создает файл

//Delete(): удаляет файл

//Move: перемещает файл в новое место

//Exists(file): определяет, существует ли файл



// Чтение и запись файлов



// В дополнение к вышерассмотренным методам класс File
// также предоставляет ряд методов для чтения-записи текстовых
// и бинарных файлов:

//AppendAllLines(String, IEnumerable<String>) /
//    AppendAllLinesAsync(String, IEnumerable<String>, CancellationToken)

// добавляют в файл набор строк. Если файл не существует,
// то он создается

//AppendAllText(String, String) /
//    AppendAllTextAsync(String, String, CancellationToken)

// добавляют в файл строку. Если файл не существует, то он создается

//byte[] ReadAllBytes (string path) /
//    Task<byte[]> ReadAllBytesAsync(string path, CancellationToken cancellationToken)

// считывают содержимое бинарного файла в массив байтов

//string[] ReadAllLines (string path) /
//    Task<string[]> ReadAllLinesAsync(string path, CancellationToken cancellationToken)

// считывают содержимое текстового файла в массив строк

//string ReadAllText (string path) /
//    Task<string> ReadAllTextAsync(string path, CancellationToken cancellationToken)

// считывают содержимое текстового файла в строку

//IEnumerable<string> ReadLines (string path)

// считывают содержимое текстового файла в коллекцию строк

//void WriteAllBytes (string path, byte[] bytes) /
//    Task WriteAllBytesAsync(string path, byte[] bytes, CancellationToken cancellationToken)

// записывают массив байт в бинарный файл.
// Если файл не существует, он создается.
// Если существует, то перезаписывается

//void WriteAllLines (string path, string[] contents) /
//    Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken)

// записывают массив строк в текстовый файл.
// Если файл не существует, он создается.
// Если существует, то перезаписывается

//WriteAllText (string path, string? contents) /
//    Task WriteAllTextAsync(string path, string ? contents, CancellationToken cancellationToken)

// записывают строку в текстовый файл.
// Если файл не существует, он создается.
// Если существует, то перезаписывается

//Как видно, эти методы покрывают практически все основные сценарии
//- чтение и запись текстовых и бинарных файлов.
//Причем в зависимости от задачи можно применять как синхронные методы,
//так и их асинхронные аналоги.


// Например, запишем и считаем обратно в строку текстовый файл:

using System.Text;

string path = @"c:\app\content.txt";

string originalText = "Hello Metanit.com";
// запись строки
await File.WriteAllTextAsync(path, originalText);
// дозапись в конец файла
await File.AppendAllTextAsync(path, "\nHello work");

// чтение файла
string fileText = await File.ReadAllTextAsync(path);
Console.WriteLine(fileText);


// Кодировка


string path1 = "/Users/eugene/Documents/app/content.txt";

string originalText1 = "Привет Metanit.com";
// запись строки
await File.WriteAllTextAsync(path1, originalText1, Encoding.Unicode);
// дозапись в конец файла
await File.AppendAllTextAsync(path1, "\nПривет мир", Encoding.Unicode);

// чтение файла
string fileText1 = await File.ReadAllTextAsync(path1, Encoding.Unicode);
Console.WriteLine(fileText1);


