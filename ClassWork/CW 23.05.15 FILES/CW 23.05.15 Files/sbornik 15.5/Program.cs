// See https://aka.ms/new-console-template for more information
using System.Text;

using (FileStream f = new FileStream("File.txt", FileMode.Append))
{
    byte[] buffer = Encoding.Default.GetBytes("До свидания, люди!");

    await f.WriteAsync(buffer, 0, buffer.Length);
}
