// See https://aka.ms/new-console-template for more information
using System.Text;

string[]mas = new string[]{"А","роза","упала","на","лапу","Азора"};

using(FileStream f = new FileStream("File.txt",FileMode.OpenOrCreate))
{
	for (int i = 0; i < mas.Length; i++)
	{
		byte[] buffer = Encoding.Default.GetBytes(mas[i] + '\n');	
		await f.WriteAsync(buffer, 0, buffer.Length);
	}
}
