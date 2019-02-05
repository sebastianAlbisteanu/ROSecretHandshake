using System;
// ReSharper disable All

namespace ConsoleApp1
{
    /// <summary>
    /// Aceasta clasa implementeaza interfata / contractul.
    /// </summary>
    public class Persoana : IPersoana
    {
        public int varsta;

        /// <summary>
        /// Definim metoda virtuala. "Iti dau o implementare, o folosesti sau o suprascrii"
        /// </summary>
        /// <returns></returns>
        public virtual string SalutSecret()
        {
            if (varsta <= 20)
            {
                return "Sal";
            }

            if (varsta >20 && varsta <= 40)
            {
                return "Ziua Buna!";
            }

            if (varsta > 40)
            {
                return "Sanatate!";
            }

            // compilatorul nu este atat de inteligent incat sa vada ca defapt if-urile acopera
            // toate conditiile, asadar tratam aici un caz absurd, dar necesar
            return "undefined";
        }

        /// <summary>
        /// pasam aceeasi instanta de random pentru ca instantierea mai multe obiecte random cauzeaza
        /// erori de logica
        /// </summary>
        /// <param name="random"></param>
        public Persoana(Random random)
        {
            varsta = random.Next(1, 100);
        }
    }
}