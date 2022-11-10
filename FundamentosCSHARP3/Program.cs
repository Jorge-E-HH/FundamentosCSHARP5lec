using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;


namespace FundamentosCSHARP3
{
    class Program
    {
        static void Main(string[] args)
        {
            CervezaBD cervezaBD = new CervezaBD();
            var cervezas = cervezaBD.Get();


            foreach (var cerveza in cervezas)
            {
                Console.WriteLine(cerveza.Nombre);

            }
        }



    }
}