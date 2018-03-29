using System;
using System.IO;
using System.Collections.Generic;

class classes
{
	public static void Main(string[] args){
		string s;
		string []input;
		Dictionary<string, int> labels = new Dictionary<string, int>();

		using(StreamReader sr = File.OpenText(args[0]))
		{
			while((s = sr.ReadLine()) != null)	//first pass through file once and find labels
			{
				if(s[0] != '/' && s[0] != '#')	//ignore comments	
				{
					input = s.Split(' ');
					if(input[0][input[0].Length] == ':')	//check for label by looking for colon
					{
						labels.Add(input[0].Substring(0, input.Length-1), Int32.Parse(input[1])); //add to labels
					}
				}
			}
			foreach(var i in labels)	//print all labels for error checking
			{
				Console.WriteLine($"Label: {i.Key}, Address: {i.Value}");
			}
		}
		using(StreamReader sr = File.OpenText(args[0]))
		{
			while((s = sr.ReadLine()) != null)	//first pass through file once and find labels
			{
				if(s[0] != '/' && s[0] != '#')	//ignore comments	
				{
					input = s.Split(' ');
					if(input[0][input[0].Length] != ':')	//check for instructions by looking for colon
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
