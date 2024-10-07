using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1calculadora
{
    internal class Operaciones
    {
        public double add( double num1, double num2) {  return num1 + num2; }
        public double Subtracion(double num1, double num2) {  return num1 - num2; }
        public double Multiplication(double num1 , double num2) { return num1 * num2; }
        public double diviction (double num1, double num2) { 
        try
            {
                return num1 / num2;
            }
            catch (Exception ex) 
            { Console.WriteLine(ex.message); }
            return 0;
        }
        public double power(double num1, double num2) { return Math.Pow(num1 * num2); }
        public double squarer(double num) {  return Math.Sqrt(num); }
        public string shutdown()
        {
            return "Adios";
        }
    }
}
