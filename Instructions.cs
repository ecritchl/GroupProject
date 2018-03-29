using System;

class Instructions : IInstructions
{
	byte[4] Exit(int n)
	{
		byte[4] b = {0,0,0,0};
		b[0] = Convert.ToByte(n);
		return b;
	}

	byte[4] Swap()
	{
		byte[4] b = {0,0,0,0x01};
		return b;
	}

	byte[4] Inpt()
	{
		byte[4] b = {0,0,0,0x02};
		return b;
	}

	byte[4] Nop()
	{
		byte[4] b = {0,0,0,0x03};
		return b;
	}

	byte[4] Pop()
	{
		byte[4] b = {0,0,0,0x10};
		return b;
	}

	byte[4] Push()
	{
		byte[4] b = {0,0,0,0xf0};
		return b;
	}

	byte[4] Add()
	{
		byte[4] b = {0,0,0,0x20};
		return b;
	}

	byte[4] Sub()
	{
		byte[4] b = {0,0,0,0x21};
		return b;
	}

	byte[4] Mul()
	{
		byte[4] b = {0,0,0,0x22};
		return b;
	}

	byte[4] Div()
	{
		byte[4] b = {0,0,0,0x23};
		return b;
	}

	byte[4] Rem()
	{
		byte[4] b = {0,0,0,0x24};
		return b;
	}

	byte[4] And()
	{
		byte[4] b = {0,0,0,0x25};
		return b;
	}

	byte[4] Or()
	{
		byte[4] b = {0,0,0,0x26};
		return b;
	}

	byte[4] Xor()
	{
		byte[4] b = {0,0,0,0x27};
		return b;
	}

	byte[4] Neg()
	{
		byte[4] b = {0,0,0,0x30};
		return b;
	}

	byte[4] Not()
	{
		byte[4] b = {0,0,0,0x31};
		return b;
	}

	byte[4] GoTo()
	{
		byte[4] b = {0,0,0,0x70};
		return b;
	}

	byte[4] If()
	{
	}

	byte[4] IfZ()
	{
	}

	byte[4] Dup()
	{
	}

	byte[4] Print()
	{
		byte[4] b = {0,0,0,0xd0};
		return b;
	}

	byte[4] Dump()
	{
		byte[4] b = {0,0,0,0xe0};
		return b;
	}

}
