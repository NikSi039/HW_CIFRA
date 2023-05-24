// ZioFile
// DefaultStream
// GZipStream

using System.IO.Compression;

string sourceFile = "sbornik.pdf";
string compressFile = "sbornik.gz";
string targetFile = "newnewnew.pdf";

string zipSourceFolder = "c://Users//C1nb9//Desktop//Test";
string zipFile = "c://Users//C1nb9//Desktop//test.zip";
string targetFolder = "c://Users//C1nb9//Desktop//newTest";

ZipFile.CreateFromDirectory(zipSourceFolder, zipFile);
ZipFile.ExtractToDirectory(zipFile, targetFolder);

await CompressAsync(sourceFile, compressFile);
await DecompressAsync(compressFile, targetFile);	

Console.ReadKey();  


async Task CompressAsync( string sourceFile, string compressFile)
{
	using FileStream sourceStream = new FileStream(sourceFile, FileMode.OpenOrCreate);
	using FileStream targetStream = File.Create(compressFile);	
	using GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress);
	
	await sourceStream.CopyToAsync(compressionStream);
	Console.Write("Сжатие завершено");
}

async Task DecompressAsync(string compressFile, string targetFile)
{
	using FileStream sourceStream = new FileStream(compressFile, FileMode.OpenOrCreate);
	using FileStream targetStream = File.Create(targetFile);
	using GZipStream decompressionStream = new GZipStream(sourceStream, CompressionMode.Decompress);	

	await decompressionStream.CopyToAsync(targetStream);	
}