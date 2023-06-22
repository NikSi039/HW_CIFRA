// 1 - FileStream


//Создание FileStream


//Для создания объекта FileStream можно использовать как конструкторы
//этого класса, так и статические методы класса File.

//Конструктор FileStream имеет множество перегруженных версий,
//из которых отмечу лишь одну, самую простую и используемую:

//FileStream(string filename, FileMode mode)

//Здесь в конструктор передается два параметра:
//путь к файлу и перечисление FileMode.
//Данное перечисление указывает на режим доступа к файлу
//и может принимать следующие значения:

//Append: если файл существует, то текст добавляется в конец файл.
//Если файла нет, то он создается. Файл открывается только для записи.

//Create: создается новый файл. Если такой файл уже существует,
//то он перезаписывается

//CreateNew: создается новый файл. Если такой файл уже существует,
//то приложение выбрасывает ошибку

//Open: открывает файл. Если файл не существует, выбрасывается исключение

//OpenOrCreate: если файл существует, он открывается,
//если нет - создается новый

//Truncate: если файл существует, то он перезаписывается.
//Файл открывается только для записи.


//Другой способ создания объекта FileStream представляют
//статические методы класса File:

//FileStream File.Open(string file, FileMode mode);
//FileStream File.OpenRead(string file);
//FileStream File.OpenWrite(string file);

//Первый метод открывает файл с учетом объекта FileMode
//и возвращает файловой поток FileStream.
//У этого метода также есть несколько перегруженных версий.
//Второй метод открывает поток для чтения,
//а третий открывает поток для записи.




//Закрытие потока


//Класс FileStream для освобождения всех реусрсов, связанных с файлом,
//реализует интерфейс IDisposable. Соответственно после завершения работы
//с FileStream необходимо освободить связанный с ним файл вызовом
//метода Dispose. Для корректного закрытия можно вызвать метод Close(),
//который вызывает метод Dispose:

using System.Text;

FileStream? fstream = null;
try
{
    fstream = new FileStream("note3.dat", FileMode.OpenOrCreate);
    // операции с fstream
}
catch (Exception ex)
{ }
finally
{
    fstream?.Close();
}


//Либо можно использовать конструкцию using,
//которая автоматически освободит все связанные с FileStream ресурсы:

using (FileStream fstream1 = new FileStream("note3.dat", FileMode.OpenOrCreate))
{
    // операции с fstream1
}




//Свойства и методы FileStream


//Рассмотрим наиболее важные свойства класса FileStream:

//Свойство Length: возвращает длину потока в байтах

//Свойство Position: возвращает текущую позицию в потоке

//Свойство Name: возвращает абсолютный путь к файлу, открытому в FileStream



//Для чтения/записи файлов можно применять следующие методы класса FileStream:


//void CopyTo(Stream destination): копирует данные из текущего потока
//в поток destination

//Task CopyToAsync(Stream destination): асинхронная версия метода CopyTo

//void Flush(): сбрасывает содержимое буфера в файл

//Task FlushAsync(): асинхронная версия метода Flush

//int Read(byte[] array, int offset, int count): считывает данные из файла
//в массив байтов и возвращает количество успешно считанных байтов.
//Принимает три параметра:

//array - массив байтов, куда будут помещены считываемые из файла данные

//offset представляет смещение в байтах в массиве array, в который
//считанные байты будут помещены

//count - максимальное число байтов, предназначенных для чтения.
//Если в файле находится меньшее количество байтов, то все они будут считаны.

//Task<int> ReadAsync(byte[] array, int offset, int count):
//асинхронная версия метода Read

//long Seek(long offset, SeekOrigin origin): устанавливает позицию в потоке
//со смещением на количество байт, указанных в параметре offset.

//void Write(byte[] array, int offset, int count): записывает в файл данные
//из массива байтов. Принимает три параметра:

//array - массив байтов, откуда данные будут записываться в файл

//offset - смещение в байтах в массиве array,
//откуда начинается запись байтов в поток

//count - максимальное число байтов, предназначенных для записи

//Task WriteAsync(byte[] array, int offset, int count):
//асинхронная версия метода Write




//Чтение и запись файлов


 
string path = @"C:\app\note.txt";   // путь к файлу

string text = "Hello METANIT.COM"; // строка для записи

// запись в файл
using (FileStream fstream2 = new FileStream(path, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] buffer = Encoding.Default.GetBytes(text);
    // запись массива байтов в файл
    await fstream2.WriteAsync(buffer, 0, buffer.Length);
    Console.WriteLine("Текст записан в файл");
}

// чтение из файла
using (FileStream fstream2 = File.OpenRead(path))
{
    // выделяем массив для считывания данных из файла
    byte[] buffer = new byte[fstream2.Length];
    // считываем данные
    await fstream2.ReadAsync(buffer, 0, buffer.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(buffer);
    Console.WriteLine($"Текст из файла: {textFromFile}");
}




//Произвольный доступ к файлам

//С помощью метода Seek() мы можем управлять положением курсора потока,
//начиная с которого производится считывание или запись в файл.
//Этот метод принимает два параметра: offset(смещение) и позиция в файле.
//Позиция в файле описывается тремя значениями:

//SeekOrigin.Begin: начало файла

//SeekOrigin.End: конец файла

//SeekOrigin.Current: текущая позиция в файле


 
string path1 = "note.dat";

string text1 = "hello world";

using (FileStream fstream3 = new FileStream(path1, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] input = Encoding.Default.GetBytes(text1);
    // запись массива байтов в файл
    fstream3.Write(input, 0, input.Length);
    Console.WriteLine("Текст записан в файл");
}
// чтение части файла
using (FileStream fstream3 = new FileStream(path1, FileMode.OpenOrCreate))
{
    // перемещаем указатель в конец файла, до конца файла- пять байт
    fstream3.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока

    // считываем четыре символов с текущей позиции
    byte[] output = new byte[5];
    await fstream3.ReadAsync(output, 0, output.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}"); // world
}


//Рассмотрим чуть более сложный пример -
//с записью начиная с некоторой позиции:


string path2 = "note2.dat";

string text2 = "hello world";

// запись в файл
using (FileStream fstream4 = new FileStream(path2, FileMode.OpenOrCreate))
{
    // преобразуем строку в байты
    byte[] input = Encoding.Default.GetBytes(text2);
    // запись массива байтов в файл
    fstream4.Write(input, 0, input.Length);
    Console.WriteLine("Текст записан в файл");
}
using (FileStream fstream4 = new FileStream(path2, FileMode.OpenOrCreate))
{
    // заменим в файле слово world на слово house
    string replaceText = "house";
    fstream4.Seek(-5, SeekOrigin.End); // минус 5 символов с конца потока
    byte[] input = Encoding.Default.GetBytes(replaceText);
    await fstream4.WriteAsync(input, 0, input.Length);

    // считываем весь файл
    // возвращаем указатель в начало файла
    fstream4.Seek(0, SeekOrigin.Begin);
    byte[] output = new byte[fstream4.Length];
    await fstream4.ReadAsync(output, 0, output.Length);
    // декодируем байты в строку
    string textFromFile = Encoding.Default.GetString(output);
    Console.WriteLine($"Текст из файла: {textFromFile}"); // hello house
}


//Чтобы после этого считать весь файл, сдвигаем курсор на самое начало

//fstream.Seek(0, SeekOrigin.Begin);
