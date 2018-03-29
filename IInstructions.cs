using System;

interface IInstructions //Interface for all Vmach instructions
{
	byte[] Exit(int n);
	byte[] Swap();
	byte[] Inpt();
	byte[] Nop();
	byte[] Pop();
	byte[] Push(Int32 val);
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
	byte[] GoTo(Int32 val);
	byte[] If(int cond, Int32 val);
	byte[] IfZ(int cond, Int32 val);
	byte[] Dup(Int32 val);
	byte[] Print();
	byte[] Dump();
}
