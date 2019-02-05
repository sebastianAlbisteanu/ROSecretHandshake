using System;

namespace ConsoleApp1
{
    /// <summary>
    /// Managerul extinde / mosteneste persoana.
    /// </summary>
    class Manager : Persoana
    {
        /// <summary>
        /// Deoarece clasa persoana nu are constructor default, trebuie sa definim constructori
        /// cu aceeasi semnatura in clasele care mostenesc din persoana.
        /// </summary>
        /// <param name="random"></param>
        public Manager(Random random) : base(random)
        {

        }

        /// <summary>
        /// vreau sa suprascriu comportamentul.
        /// </summary>
        /// <returns></returns>
        public override string SalutSecret()
        {
            return "Te ignor";
        }

        /// <summary>
        /// supraincarcare / overloading. Aceasta metoda, cu aceasta semnatura va fi accesibila
        /// doar in obiectele de tip Manager.
        /// </summary>
        /// <param name="nume"></param>
        /// <returns></returns>
        public string SalutSecret(string nume)
        {
            // string interpolation
            // alternative:
            // templating: string.Format("Template {0} {1} etc", valoare0, valoare1, valoareEtc)
            // concatenare: "Te ignor, " + "Maria" + "ceva" 
            return $"Te ignor, {nume} {"Maria"}"+"ceva";


        }
    }
}
