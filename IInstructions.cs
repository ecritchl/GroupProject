using System;

interface IInstructions
{
	byte[] Exit(int n);
	byte[] Swap();
	byte[] Inpt();
	byte[] Nop();
	byte[] Pop();
	byte[] Push(int32 val);
	byte[] Add();
	byte[] Sub();
	byte[] Mul();
	byte[] Div();
	byte[] Rem();
	byte[] And();
	byte[] Or();
	byte[] Xor();
	byte[] Neg();
	byte[] Not();
	byte[] GoTo(int32 val);
	byte[] If(int cond, int32 val);
	byte[] IfZ(int cond, int32 val);
	byte[] Dup(int32 val);
	byte[] Print();
	byte[] Dump();
}
