using System;

interface IInstructions
{
	byte[4] Exit(int n);
	byte[4] Swap();
	byte[4] Inpt();
	byte[4] Nop();
	byte[4] Pop();
	byte[4] Push();
	byte[4] Add();
	byte[4] Sub();
	byte[4] Mul();
	byte[4] Div();
	byte[4] Rem();
	byte[4] And();
	byte[4] Or();
	byte[4] Xor();
	byte[4] Neg();
	byte[4] Not();
	byte[4] GoTo();
	byte[4] If();
	byte[4] IfZ();
	byte[4] Dup();
	byte[4] Print();
	byte[4] Dump();
}
