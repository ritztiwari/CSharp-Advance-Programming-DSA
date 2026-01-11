using System;

interface IURLStorage
{
	void Save(string shortUrl, string longUrl);
	void GetUrl(string shortUrl);
}

internal class StorageAdd : IURLStorage
{
	Dictionary<string,string> dict = new Dictionary<string, string>();
	
	public void Save(string shortUrl, string longUrl)
	{
		dict[shortUrl] = longUrl;
	}

	public void GetUrl(string shortUrl)
	{
		if (dict.ContainsKey(shortUrl))
		{
			Console.WriteLine(dict[shortUrl]);
		}
		else 
		{
			Console.WriteLine("url not found");
		}
	}
}
