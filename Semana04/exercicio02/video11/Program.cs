using System;

using video11;
Imposto objE = new Estagiario();

objE.valeAlimentacao(1000);
objE.valeTransporte(1000);

console.WriteLine("-------------");

Imposto objG = new Gerente();

objG.valeAlimentacao(5000);
objG.valeTransporte(5000);

console.WriteLine("-------------");

Imposto objG = new Atendente();

objG.valeAlimentacao(2000);
objG.valeTransporte(2000);

console.WriteLine("-------------");