using System;

class classes
{
	public static void Main(string[] args){
		var i = "-44";
		Console.WriteLine(string.format("{0:x}", i));
		var s
			using(StreamReader sr = File.OpenText(args[0]))
			{
				while((s = sr.ReadLine()) != null)	//parse through file once and find labels
				{
					if(s[s.Length] == ':')
					{
						//add to labels
					}
				}
				sr.Position = 0;
				while((s = sr.ReadLine()) != null)	//parse through file once and find labels
				{
					if(s[s.Length] != ':')
					{
						//do stuff and print
					}
				}
			}
	}
}
