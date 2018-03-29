using System;

class Instructions : IInstructions //Converts everything to 32 bits with the specified bit ordering
{
	public byte[] Exit(int n) //converts int to a byte and inserts into first byte of empty 4 byte array
	{
		byte[] b = {0,0,0,0};
		b[0] = Convert.ToByte(n);
		return b;
	}

	public byte[] Swap() //returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x01};
		return b;
	}

	public byte[] Inpt()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x02};
		return b;
	}

	public byte[] Nop()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x03};
		return b;
	}

	public byte[] Pop()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x10};
		return b;
	}

	public byte[] Push(Int32 val) //converts to 32 bits and changes last 4 bits to specified order
	{
		byte[] b = BitConverter.GetBytes(val);
		b[3] = (byte) (b[3] & 0xf);
		b[3] = (byte) (b[3] | 0xf0);
		return b;
	}

	public byte[] Add()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x20};
		return b;
	}

	public byte[] Sub()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x21};
		return b;
	}

	public byte[] Mul()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x22};
		return b;
	}

	public byte[] Div()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x23};
		return b;
	}

	public byte[] Rem()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x2};
		return b;
	}

	public byte[] And()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x25};
		return b;
	}

	public byte[] Or()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x26};
		return b;
	}

	public byte[] Xor()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x27};
		return b;
	}

	public byte[] Neg()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x30};
		return b;
	}

	public byte[] Not()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0x31};
		return b;
	}

	public byte[] GoTo(Int32 val)//converts to 32 bits and changes specified bits as needed
	{
		byte[] b = BitConverter.GetBytes(val);
		b[3] = (byte) (b[3] & 0xf);
		b[3] = (byte) (b[3] | 0x70);
		return b;
	}

	public byte[] If(int cond, Int32 val, int pc)//converts to 32 bits and changes specified bits as needed
	{
		cond += 128;
		val = val - pc + 4;
		byte[] b = BitConverter.GetBytes(val);
		b[3] = (byte) (b[3] & 0x00);
		b[3] = (byte) (b[3] | Convert.ToByte(cond));
		return b;
	}

	public byte[] IfZ(int cond, Int32 val, int pc)//converts to 32 bits and changes specified bits as needed
	{
		cond += 144;
		val = val - pc + 4;
		byte[] b = BitConverter.GetBytes(val);
		b[3] = (byte) (b[3] & 0x00);
		b[3] = (byte) (b[3] | Convert.ToByte(cond));
		return b;

	}

	public byte[] Dup(Int32 val)//converts to 32 bits and changes specified bits as needed
	{
		val *= 4;
		byte[] b = BitConverter.GetBytes(val);
		b[3] = (byte) (b[3] & 0xf);
		b[3] = (byte) (b[3] | 0xc0);
		return b;
	}

	public byte[] Print()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0xd0};
		return b;
	}

	public byte[] Dump()//returns 4 byte array with specified 32 bits
	{
		byte[] b = {0,0,0,0xe0};
		return b;
	}

}
