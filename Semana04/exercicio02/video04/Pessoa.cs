using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace video04
{
    public class Pessoa
    {
        public double altura;
        public double peso;

        public double calculo()
        {
            return peso/(altura*altura);
        }
        public string situacao()
        {
            double imc = calculo();
            if(imc<=18.5){
                return "Abaixo do peso";
            }
            else if (imc <= 25 && imc >18.5){
                return "Peso normal";
            }
            else if (imc <= 30 && imc >25){
                return "Acima do peso";
            }
            else if (imc <= 35 && imc >30){
                return "Obesidade 1";
            }
            else if (imc < 40 && imc >35){
                return "Obesidade 2";
            }
            else {
                return "Obesidade 3";
            }

        }
        public void mensagem()
        {
            string resultado = situacao();
            Console.WriteLine("Sua situação é: " + resultado);
        }
    }  

}