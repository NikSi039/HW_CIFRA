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

// sbornik 15.8

using (FileStream f = new FileStream("File.txt",FileMode.Open,FileAccess.Read))
{
	byte[] buffer = new byte[f.Length];

	await f.ReadAsync(buffer, 0, buffer.Length);

	string text = Encoding.Default.GetString(buffer);

	Console.WriteLine(text);

	int count = 0;

	for (int i = 0; i < text.Length; i++)
	{
		if (text[i] == '\n')
		{
			count++;
		}
	}

	Console.WriteLine(count);

	Console.ReadKey();
}


