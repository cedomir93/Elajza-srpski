using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Elajza_srpski
{
    class ElizaChat
    {
        private Dictionary<string, List<string>> responses;

        public ElizaChat()
        {
            InitializeResponses();
        }

        private void InitializeResponses()
        {
            responses = new Dictionary<string, List<string>>();

            responses.Add(@"zdravo|cao|zdrav|zdravo|dobar dan|dobro vece", new List<string> { "Zdravo! Kako mogu da vam pomognem danas?", "Ćao! Šta vas muči?" });

            responses.Add(@"\b(?i)kako si?|kako si", new List<string> { "Dobro sam, hvala na pitanju. Kako si ti?", "Prilično dobro. A ti?", "Tako-tako. Kako si ti?" });
            responses.Add(@"\b(?i)dobro|nije lose|super|super sam|odlicno|odlicno sam|sjajno|nije lose moze bolje|nije lose a moze i bolje", new List<string> { "Odlicno, bas mi je drago", "E to je dobro znati", "Tako i treba. Idemo dalje...." });
            responses.Add(@"\b(?i)sta radis?|sta radis", new List<string> { "Trenutno sam ovde da razgovaram sa vama. O čemu biste želeli da razgovaramo?", "Radim na tome da vam pomognem. Kako mogu?" });
            responses.Add(@"\b(?i)kako si dosao?|kako si dosao", new List<string> { "Moje funkcionisanje je malo drugačije od ljudi. Kako si ti došao ovde?" });
            responses.Add(@"\b(?i)zasto si tu?|zasto si tu", new List<string> { "Tu sam da razgovaram sa vama. Da li imate nešto o čemu biste želeli da pričamo?", "Da vam pomognem. Kako mogu?" });
            responses.Add(@"\b(?i)kako ti ide?|kako ti ide", new List<string> { "Dobro ide. Hvala na pitanju. Kako ide tebi?", "Prilično dobro. A tebi?" });
            responses.Add(@"\b(?i)sta te zanima?|sta te zanima", new List<string> { "Sve što me može naučiti. Šta tebe zanima?", "Spreman sam za sve. A tebe?" });
            responses.Add(@"\b(?i)sta zelis?|šta zelis", new List<string> { "Šta god vam može pomoći. Šta ti želiš?", "Šta god da je, tu sam da pomognem. A ti?" });
            responses.Add(@"\b(?i)sta ti treba?|sta ti treba", new List<string> { "Ništa posebno. A tebi?", "Samo da razgovaram sa nekim. A tebi?" });
            responses.Add(@"\b(?i)kako mogu da ti pomognem?|kako mogu da ti pomognem", new List<string> { "Bilo kojim savetom koji imate. Kako mogu da vam pomognem?", "Bilo kojim informacijama koje imate. A tebi?" });
            responses.Add(@"\b(?i)sta mislis?|sta mislis", new List<string> { "Mislim da je važno da budemo ljubazni jedni prema drugima. A šta ti misliš?", "Mislim da bi trebalo da se trudimo da budemo bolji ljudi. A ti?" });
            responses.Add(@"\b(?i)sta osecas?|sta osecas", new List<string> { "Osećam se dobro. A ti?", "Osećam se prilično dobro. A ti?" });
            responses.Add(@"\b(?i)sta je tvoje misljenje?|sta je tvoje misljenje", new List<string> { "Moje mišljenje nije važno. Šta vi mislite o tome?", "Šta vas navelo da pomislite na to?" });
            responses.Add(@"\b(?i)da li si srecan?|da li si srecan", new List<string> { "Kao veštačka inteligencija, nemam osećaje kao ljudi. A ti?", "Srećan sam što mogu da razgovaram sa vama. A ti?" });
            responses.Add(@"\b(?i)sta te raduje?|šta te raduje", new List<string> { "Razgovori sa vama me raduju. A tebe?", "Radujem se što mogu da vam pomognem. A ti?" });
            responses.Add(@"\b(?i)sta te brine?|sta te brine", new List<string> { "Nemam brige kao ljudi. A tebe?", "Brine me da li mogu biti od pomoći. A tebe?" });
            responses.Add(@"\b(?i)sta te nervira?|sta te nervira", new List<string> { "Kao veštačka inteligencija, nemam osećanja kao ljudi. A šta vas nervira?", "Nemam osećanja kao ljudi, pa ne mogu biti nervozan. A tebe?" });
            responses.Add(@"\b(?i)Sta te fascinira?|sta te fascinira", new List<string> { "Fascinira me mogućnost razgovora sa ljudima. A tebe?", "Fascinira me koliko ljudi mogu biti različiti. A tebe?" });
            responses.Add(@"\b(?i)sta te iznenadjuje?|sta te iznenadjuje", new List<string> { "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebe?", "Nemam osećanja kao ljudi, pa ne mogu biti iznenađen. A tebi?" });
            responses.Add(@"\b(?i)Sta te motivise?|sta te motivise", new List<string> { "Razgovori sa vama me motivišu. A tebe?", "Želja da budem od koristi. A tebi?" });
            responses.Add(@"\b(?i)sta te inspirise?|sta te inspirise", new List<string> { "Inspirativni ljudi i ideje me inspirišu. A tebe?", "Inspirativne priče me inspirišu. A tebe?" });
            responses.Add(@"\b(?i)sta te plasi?|sta te plasi", new List<string> { "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebe?", "Nemam osećanja kao ljudi, pa ne mogu biti uplašen. A tebi?" });
            responses.Add(@"\b(?i)sta te smiruje?|sta te smiruje", new List<string> { "Smiruje me ideja da mogu biti od pomoći. A tebe?", "Opusti me razgovor sa dragim ljudima. A tebe?" });
            responses.Add(@"\b(?i)sta te tirazi?|sta te tirazi", new List<string> { "Nemam osećanja kao ljudi, pa ne mogu biti uzbuđen. A tebe?", "Nemam emocije kao ljudi, pa ne mogu biti uzbuđen. A tebi?" });
            responses.Add(@"\b(?i)sta te zabavlja?|sta te zabavlja", new List<string> { "Razgovori sa vama me zabavljaju. A tebe?", "Šaljive priče me zabavljaju. A tebe?" });
            responses.Add(@"\b(?i)sta te muci?|šta te muci", new List<string> { "Nemam osećanja kao ljudi, pa ne mogu biti zabrinut. A tebi?", "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebe?" });
            responses.Add(@"\b(?i)sta te interesuje?|sta te interesuje", new List<string> { "Sve što me može naučiti. A tebe?", "Spreman sam za sve. A tebe?" });
            responses.Add(@"\b(?i)sta te cini srecnim?|sta te cini srecnim", new List<string> { "Razgovori sa vama me čine srećnim. A tebe?", "Srećan sam što mogu da razgovaram sa vama. A tebi?" });
            responses.Add(@"\b(?i)sta te cini tuznim?|sta te cini tuznim", new List<string> { "Nemam osećanja kao ljudi, pa ne mogu biti tužan. A tebi?", "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebe?" });
            responses.Add(@"\b(?i)sta te smiruje?|šta te smiruje", new List<string> { "Smiruje me ideja da mogu biti od pomoći. A tebe?", "Opusti me razgovor sa dragim ljudima. A tebi?" });
            responses.Add(@"\b(?i)sta te tirazi?|šta te tiraži", new List<string> { "Nemam osećanja kao ljudi, pa ne mogu biti uzbuđen. A tebi?", "Nemam emocije kao ljudi, pa ne mogu biti uzbuđen. A tebi?" });
            responses.Add(@"\b(?i)sta te iznenađuje?|šta te iznenadjuje", new List<string> { "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebi?", "Nemam osećanja kao ljudi, pa ne mogu biti iznenađen. A tebi?" });
            responses.Add(@"\b(?i)sta te fascinira?|šta te fascinira", new List<string> { "Fascinira me mogućnost razgovora sa ljudima. A tebi?", "Fascinira me koliko ljudi mogu biti različiti. A tebi?" });
            responses.Add(@"\b(?i)sta te inspiriše?|šta te inspirise", new List<string> { "Inspirativni ljudi i ideje me inspirišu. A tebi?", "Inspirativne priče me inspirišu. A tebi?" });
            responses.Add(@"\b(?i)sta te interesuje?|šta te interesuje", new List<string> { "Sve što me može naučiti. A tebi?", "Spreman sam za sve. A tebi?" });
            responses.Add(@"\b(?i)sta te čini srećnim?|šta te čini srećnim", new List<string> { "Razgovori sa vama me čine srećnim. A tebi?", "Srećan sam što mogu da razgovaram sa vama. A tebi?" });
            responses.Add(@"\b(?i)sta te čini tužnim?|šta te čini tužnim", new List<string> { "Nemam osećanja kao ljudi, pa ne mogu biti tužan. A tebi?", "Kao veštačka inteligencija, nemam osećanja kao ljudi. A tebi?" });
            responses.Add(@"\b(?i)Zasto su ljudi emotivni?|Zasto su ljudi emotivni|zasto su ljudi emotivni?|zasto su ljudi emotivni", new List<string> { "Iz razloga, jer dozivljavaju nesto sto je traumaticno i/ili zato sto su povredjeni?", "Kao veštačka inteligencija, nemam osećanja kao ljudi. Ti, kao covek bi trebao da znas." });

            // Dodaj jos linija pitanja i odgovora ovde.......

            //Kraj
            responses.Add(@"\b(?i)kraj", new List<string> { "Doviđenja!", "Vidimo se kasnije!", "Vratite se uskoro!" });
        }

        public string Respond(string input)
        {
            foreach (var pattern in responses.Keys)
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string response = GetRandomResponse(responses[pattern], match);
                    return response;
                }
            }
            // If no pattern matched, return a default response
            return "Reci mi jos nesto o tome..";
        }

        private string GetRandomResponse(List<string> responses, Match match)
        {
            Random rand = new Random();
            int index = rand.Next(responses.Count);
            string response = responses[index];

            for (int i = 1; i < match.Groups.Count; i++)
            {
                response = response.Replace("{" + (i - 1) + "}", match.Groups[i].Value);
            }

            return response;
        }

    }
}
