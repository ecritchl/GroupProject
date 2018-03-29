using System;
using System.IO;
using System.Collections.Generic;

class classes
{
	public static void Main(string[] args){
		string s;
		string []input;
		int counter = 0;
		byte[] b;
		Dictionary<string, int> labels = new Dictionary<string, int>();
		var a = new Instructions();

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
					input = s.Split(null);
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
		using (FileStream bw = new FileStream("test.bin",FileMode.Create))
		{
			bw.WriteByte(0xfe);
			bw.WriteByte(0xed);
			bw.WriteByte(0xbe);
			bw.WriteByte(0xef);
			using(StreamReader sr = File.OpenText(args[0]))
			{
				while((s = sr.ReadLine()) != null)				//first pass through file once and find labels
				{
					if(s != "" && s[0] != '/' && s[0] != '#')	//ignore comments	
					{
						input = s.Split(null);
						if(input[0][input[0].Length-1] != ':')	//check for instructions by looking for colon
						{
							Console.WriteLine($"{input[0]}");	//split is not seperating lines by whitespace
							switch(input[0])		//call interface function
							{
								case "exit":
									if(input.Length > 1)
									{
										b = a.Exit(int.Parse(input[1]));
									}else
									{
										b = a.Exit(0);	//no exit code	
									}
									break;
								case "swap":
									b = a.Swap();
									break;
								case "inpt":
									b = a.Inpt();
									break;
								case "nop":
									b = a.Nop();
									break;
								case "pop":
									b = a.Pop();
									break;
								case "add":
									b = a.Add();
									break;
								case "sub":
									b = a.Sub();
									break;
								case "mul":
									b = a.Mul();
									break;
								case "div":
									b = a.Div();
									break;
								case "rem":
									b = a.Rem();
									break;
								case "and":
									b = a.And();
									break;
								case "or":
									b = a.Or();
									break;
								case "xor":
									b = a.Xor();
									break;
								case "neg":
									b = a.Neg();
									break;
								case "not":
									b = a.Not();
									break;
								case "goto":
									b = a.GoTo();
									break;
								case "ifeq":			 
									b = IfCase(ref labels, ref input, 0, true);
									break;
								case "ifne":			 
									b = IfCase(ref labels, ref input, 1, true);
									break;
								case "iflt":			 
									b = IfCase(ref labels, ref input, 2, true);
									break;
								case "ifgt":			 
									b = IfCase(ref labels, ref input, 3, true);
									break;
								case "ifle":			 
									b = IfCase(ref labels, ref input, 4, true);
									break;
								case "ifge":			 
									b = IfCase(ref labels, ref input, 5, true);
									break;
								case "ifez":			 
									b = IfCase(ref labels, ref input, 0, false);
									break;
								case "ifnz":			 
									b = IfCase(ref labels, ref input, 1, false);
									break;
								case "ifmi":			 
									b = IfCase(ref labels, ref input, 2, false);
									break;
								case "ifpl":			 
									b = IfCase(ref labels, ref input, 3, false);
									break;
								case "dup":
									b = a.Dup();
									break;
								case "print":
									b = a.Print();
									break;
								case "dump":
									b = a.Dump();
									break;
								case "push":
									b = a.Push();
									break;
								default:
									Console.WriteLine($"unknown instruction: {input[0]}\n");
									b = new byte[] {0x00, 0x00, 0x00, 0x00};
									break;
							}	
							//The data type to write is inferred from the parameter
							foreach(var c in b)
								bw.WriteByte(c);
						}
					}
				}
			}
		}
	}
	//takes the dictionary, intput, and if no for calling the associated function
	public static byte[] IfCase(ref Dictionary<string, int> labels, ref string[] input, int i, bool j)
	{
		var a = new Instructions();
		byte[] b = {0,0,0,0};
		if(input.Length > 1)
		{
			if(labels.ContainsKey(input[1]))
			{
				if(j)
				{
					b = a.If(i, labels[input[1]]);
				}else
				{
					b = a.IfZ(i, labels[input[1]]);	
				}
			}
			else
			{
				Console.WriteLine("label not found");
			}
		}

		return b;
	}
}
