using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {
        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "Erreur de saisie : le nombre doit être positif et non nul !");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messageErreurPerso = null)
        {

            int result = DemanderNombre(question);
            if (result >= min && result <= max)
            {
                return result;
            }
            else if(messageErreurPerso == null)
            {
                Console.WriteLine();
                Console.WriteLine("Erreur de saisie : le nombre doit être compris entre " + min + " et " + max + " !");
                Console.WriteLine();
                return DemanderNombreEntre(question, min, max);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(messageErreurPerso);
                Console.WriteLine();
                return DemanderNombreEntre(question, min, max, messageErreurPerso);
            }

            

        }
        static int DemanderNombre(string question)
        {

            // poser la question

            Console.Write(question);
            // récupérer la réponse
            string reponseString = Console.ReadLine();
            // convertir

            // gérer l'erreur de conversion
            try
            {
                int reponseInt = int.Parse(reponseString);
                return reponseInt;
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Erreur de saisie : votre réponse n'est pas un nombre valide");
                Console.WriteLine();
            }
            return DemanderNombre(question);



            //boucler tant qu'on a pas reçu une réponse valide(qui contient des chiffres)

        }
        public static void AffichageListeString(List<string> list)
        {
            for (int j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j]);
            }
        }
    }
}
