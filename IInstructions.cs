using System;

interface IInstructions
{
	byte[] Exit(int n);
	byte[] Swap();
	byte[] Inpt();
	byte[] Nop();
	byte[] Pop();
	byte[] Push();
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
	byte[] GoTo();
	byte[] If();
	byte[] IfZ();
	byte[] Dup();
	byte[] Print();
	byte[] Dump();
}
