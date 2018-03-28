using System;

class classes
{
	public static void Main(string[] args){
		using(StreamReader sr = File.OpenText(args[0])){
			string s;
			while((s = sr.ReadLine()) != null)	//parse through file once and find labels
			{
				if(s[s.Length] == ':')
				{
					//add to labels
				}
			}
		}
		sr.Position = 0;
		while((s = sr.ReadLine()) != null)	//parse through file once and find labels
		{
			if(s[s.Length] != ':')
			{
				//add to labels
			}
		}
	}
}
