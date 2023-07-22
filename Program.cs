namespace generateur_de_phrases
{
    internal class Program
    {
        static string ObtenirElementAleatoire(string[] t)
        {
            Random rnd = new Random();
            int index = rnd.Next(t.Length);
            return t[index];
        }
        static void Main(string[] args)
        {
            // sujet verbe complement
            var sujets = new string[]
            {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fée",
                "Une tortue",
            };

            var verbes = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "nettoie",
                "se bat avec",
                "s'accroche à",
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            const int NB_PHRASES = 100;
            int doublons = 0;

            List<string> listPhrases = new List<string>();

            while(listPhrases.Count < NB_PHRASES) 
            {
                string sujet = ObtenirElementAleatoire(sujets);
                string verbe = ObtenirElementAleatoire(verbes);
                string complement = ObtenirElementAleatoire(complements);
                string phrase = sujet + " " + verbe + " " + complement;
                phrase = phrase.Replace("à le", "au");

                if (!listPhrases.Contains(phrase))
                {
                    listPhrases.Add(phrase);
                }
                else
                {
                    doublons++;
                }
            }
            foreach (var item in listPhrases)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            Console.WriteLine("Nombre de phrases = " + listPhrases.Count);
            Console.WriteLine("Nombre de doublons évités = " + doublons);
        }
    }
}