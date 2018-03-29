using System;

class Instructions : IInstructions
{
	public byte[] Exit(int n)
	{
		byte[] b = {0,0,0,0};
		b[0] = Convert.ToByte(n);
		return b;
	}

	public byte[] Swap()
	{
		byte[] b = {0,0,0,0x01};
		return b;
	}

	public byte[] Inpt()
	{
		byte[] b = {0,0,0,0x02};
		return b;
	}

	public byte[] Nop()
	{
		byte[] b = {0,0,0,0x03};
		return b;
	}

	public byte[] Pop()
	{
		byte[] b = {0,0,0,0x10};
		return b;
	}

	public byte[] Push(int32 val)
	{
		byte[] b = ByteConvert.GetBytes(val);
		b[3] = (byte) (b[3] & 0xf);
		b[3] = (byte) (b[3] | 0xf0);
		return b;
	}

	public byte[] Add()
	{
		byte[] b = {0,0,0,0x20};
		return b;
	}

	public byte[] Sub()
	{
		byte[] b = {0,0,0,0x21};
		return b;
	}

	public byte[] Mul()
	{
		byte[] b = {0,0,0,0x22};
		return b;
	}

	public byte[] Div()
	{
		byte[] b = {0,0,0,0x23};
		return b;
	}

	public byte[] Rem()
	{
		byte[] b = {0,0,0,0x2};
		return b;
	}

	public byte[] And()
	{
		byte[] b = {0,0,0,0x25};
		return b;
	}

	public byte[] Or()
	{
		byte[] b = {0,0,0,0x26};
		return b;
	}

	public byte[] Xor()
	{
		byte[] b = {0,0,0,0x27};
		return b;
	}

	public byte[] Neg()
	{
		byte[] b = {0,0,0,0x30};
		return b;
	}

	public byte[] Not()
	{
		byte[] b = {0,0,0,0x31};
		return b;
	}

	public byte[] GoTo(int32 val)
	{
		byte[] b = {0,0,0,0x70};
		return b;
	}

	public byte[] If(int cond, int32 val)
	{
		cond += 128;
		byte[] b = {0,0,0,Convert.ToByte(cond)};
		return b;
	}

	public byte[] IfZ(int cond, int32 val)
	{
		cond += 144;
		byte[] b = {0,0,0,Convert.ToByte(cond)};
		return b;

	}

	public byte[] Dup(int32 val)
	{
		byte[] b = {0,0,0,0xc0};
		return b;
	}

	public byte[] Print()
	{
		byte[] b = {0,0,0,0xd0};
		return b;
	}

	public byte[] Dump()
	{
		byte[] b = {0,0,0,0xe0};
		return b;
	}

}
