using System;
using System.IO;
using System.Collections.Generic;

class classes
{
	public static void Main(string[] args){
		string s;
		string []input;
		int counter = 0;
		Dictionary<string, int> labels = new Dictionary<string, int>();
		var a = new Instructions;

		if(args.Length == 0)
		{
			Console.WriteLine("Please enter input file");
			return;
		}
		using(StreamReader sr = File.OpenText(args[0]))
		{
			while((s = sr.ReadLine()) != null)							//first pass through file once and find labels
			{
				if(s != "" && s != "\n" && s[0] != '/' && s[0] != '#')	//ignore comments	
				{
					input = s.Split(' ');
					if(input[0][input[0].Length-1] == ':')				//check for label by looking for colon
					{
						labels.Add(input[0].Trim(':'), counter);		//add to labels dictionary
					}else
					{
						counter += 4;	
					}
				}
			}
		}
		using(StreamReader sr = File.OpenText(args[0]))
		{
			while((s = sr.ReadLine()) != null)				//first pass through file once and find labels
			{
				if(s != "" && s[0] != '/' && s[0] != '#')	//ignore comments	
				{
					input = s.Split(' ');
					if(input[0][input[0].Length-1] != ':')	//check for instructions by looking for colon
					{
						//call interface function
					}
				}
			}
		}
	}
}

//var i = -44;		//conversion from int to hex
//Console.WriteLine(i.ToString("X"));
