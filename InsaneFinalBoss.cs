/* made by Mossy subscribe to my channel if you haven't already!
 * Feel free to use this code for whatever you want, I'm doing this strictly for fun and would love to see some
 * improvements made on it. discord: mossy#0639
 * rsn: iMossyS
 */

using System;
using System.Collections;
using System.Collections.Immutable;

namespace InsaneFinalIfb
{
    class InsaneFinalBoss
    {
        public struct Ifb
        {
            public bool petValue { get; set; }
            public int dropRate { get; set; }
            public int threshold { get; set; }
            public string bossPetName { get; set; }
            public string nameOfBoss { get; set; }
            public int totalThreshold { get; set; }
            public int kcPetAt;
        }
        public static Ifb CreateIfb(int dropRate, int threshold, string bossPetName, string nameOfIfb, int totalThreshold)
        {
            var Ifb = new Ifb
            {
                petValue = false,
                dropRate = dropRate,
                threshold = threshold,
                bossPetName = bossPetName,
                nameOfBoss = nameOfIfb,
                totalThreshold = totalThreshold,
                kcPetAt = 0
            };
            return Ifb;
        }
        static void Main(string[] args)
        {

            int totalKills = 0;
            int kills = 0;
            var generator = new RandomGenerator();

            Ifb barry =  CreateIfb(500, 200, "Barry", "Rax", 1);
            Ifb mallory = CreateIfb(500, 200, "Mallory", "Rax", 1);
            Ifb kree = CreateIfb(5000, 1000, "ChickArra", "Kree'Arra", 1);
            Ifb graardor = CreateIfb(5000, 1000, "CommanderMiniana", "Commander Zilyana", 1);
            Ifb kril = CreateIfb(5000, 1000, "KrilTinyroth", "Kril", 1);
            Ifb nex = CreateIfb(2000, 400, "Nexterminator", "Nex", 1);
            Ifb giantMole = CreateIfb(2500, 500, "Molly", "Giant Mole",1);
            Ifb harAken = CreateIfb(200, 40, "Shrimpy", "Har-Aken",1);
            Ifb kingBlackDragon = CreateIfb(2500, 500, "King Black Dragonling", "King Black Dragon",1);
            Ifb queenBlackDragon = CreateIfb(2500, 500, "Queen Black Dragonling", "Queen Black Dragon",1);
            Ifb kalphiteGrublet = CreateIfb(2500, 500, "Kalphite Grublet", "Kalphite Queen",1);
            Ifb kalphiteGrubling = CreateIfb(2000, 400, "Kalphite Grubbling", "Kalphite King",1);
            Ifb corporealPuppy = CreateIfb(2500, 500, "Corporeal Puppy", "Corporeal Beast",1);
            Ifb ellie = CreateIfb(2500, 500, "Ellie", "Chaos Elemental",1);
            Ifb legioPrimulus = CreateIfb(1000, 1200, "Legio Primulus", "Legio Primus",1);
            Ifb legioSecundulus = CreateIfb(1000, 1200, "Legio Secundulus", "Legio Secundus",1);
            Ifb legioTertiolus = CreateIfb(1000, 1200, "Legio Tertiolus", "Legio Tertius",1);
            Ifb legioQuartulus = CreateIfb(1000, 1200, "Legio Quartulus", "Legio Quartus",1);
            Ifb legioQuintulus = CreateIfb(1000, 1200, "Legio Quintulus", "Legio Quintus",1);
            Ifb legioSextulus = CreateIfb(1000, 1200, "Legio Sextulus", "Legio Sextus",1);
            Ifb lilTuzzy = CreateIfb(512, 999999999, "Lil Tuzzy", "Beastmaster Durzag",1);
            Ifb rexHatchling = CreateIfb(2500, 1500, "Rex Hatchling", "Dagannoth Rex",1);
            Ifb primeHatchling = CreateIfb(2500, 1500, "Prime Hatchling", "Dagannoth Prime",1);
            Ifb supremeHatchling = CreateIfb(2500, 1500, "Supreme Hatchling", "Daganoth Supreme",1);
            Ifb vitalis = CreateIfb(1000, 1000, "Vitalis", "Vorago",1);
            Ifb bombi = CreateIfb(100, 999999999, "Bombi", "Vorago",1);
            Ifb greg = CreateIfb(2000, 400, "Greg", "Gregorovic",1);
            Ifb lilwyr = CreateIfb(2000, 400, "Lilwyr", "Helwyr",1);
            Ifb ava = CreateIfb(2000, 400, "Ava", "Twin Furies",1);
            Ifb nylessa = CreateIfb(2000, 400, "Nylessa", "Twin Furies",1);
            Ifb vindiddy = CreateIfb(2000, 400, "Vindiddy", "Vindicta",1);
            Ifb rawrvek = CreateIfb(2000, 400, "Rawrvek", "Vindicta",1);
            Ifb tess = CreateIfb(1400, 300, "Tess", "Telos",1);
            Ifb reeves = CreateIfb(3000, 600, "Reeves", "Nex: AOD",1);
            Ifb diddyzag = CreateIfb(300, 60, "Diddyzag", "Beastmaster Durzag",1);
            Ifb yakaminu = CreateIfb(300, 60, "Yakaminu", "Yakamaru",1);
            Ifb theMinister = CreateIfb(1000, 200, "The Minister", "The Magister",1);
            Ifb solly = CreateIfb(1200, 240, "Solly", "Solak",1);
            Ifb kuroryu = CreateIfb(300, 60, "Kuroryu", "Seiryu",1);



            int totalTotalKills = 0;
            Ifb ifbMax = CreateIfb(0, 0, "", "", 0);
            Ifb ifbMin = CreateIfb(0, 0, "", "", 0);

            ifbMax.kcPetAt = -999;
            ifbMin.kcPetAt = 999;

            int totalMin = -99999999;
            String minBossName = "";
            int totalMax = -99999999;
            String maxBossName = "";

            Console.WriteLine("How many simulations do you want to do?");
            int simulations = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                for (int j = 0; j < simulations; j++)
                {

                    Ifb[] ifbs = {barry, mallory, kree, graardor, kril, nex, giantMole, harAken, kingBlackDragon, queenBlackDragon, kalphiteGrublet, kalphiteGrubling, corporealPuppy,
                 ellie, legioPrimulus, legioQuartulus, legioQuintulus, legioSecundulus, legioSextulus, legioTertiolus, lilTuzzy, rexHatchling, primeHatchling, supremeHatchling, vitalis,
                 bombi, greg, lilwyr, ava, nylessa, vindiddy, rawrvek, tess, reeves, diddyzag, yakaminu, theMinister, solly, kuroryu};
                    int max = 0;
                    int min = 999999999;

                    for (int i = 0; i < ifbs.Length; i++)
                    {
                        while (ifbs[i].petValue == false)
                        {
                            kills += 1;
                            totalKills += 1;
                            totalTotalKills += 1;
                            if (kills == ifbs[i].threshold)
                            {
                                ifbs[i].totalThreshold += 1;
                                kills = 0;
                            }
                            int correct = (ifbs[i].dropRate / ifbs[i].totalThreshold);
                            int drop = generator.RandomNumber(1, correct + 1);
                            if (correct == drop)
                            {
                                ifbs[i].petValue = true;
                                ifbs[i].kcPetAt = totalKills;
                                totalKills = 0;
                                if (ifbs[i].kcPetAt > max)
                                {
                                    max = ifbs[i].kcPetAt;
                                    ifbMax = ifbs[i];

                                    if (totalMax == -99999999 || ifbMax.kcPetAt > totalMax)
                                    {
                                        totalMax = ifbMax.kcPetAt;
                                        maxBossName = ifbMax.nameOfBoss;
                                    }
                                }
                                if (ifbs[i].kcPetAt < min)
                                {
                                    min = ifbs[i].kcPetAt;
                                    ifbMin = ifbs[i];
                                    if ((totalMin == -99999999 || ifbMin.kcPetAt < totalMin))
                                    {
                                        totalMin = ifbMin.kcPetAt;
                                        minBossName = ifbMin.nameOfBoss;
                                    }
                                }
                            }
                        }
                        Console.WriteLine($"You received the {ifbs[i].nameOfBoss} pet {ifbs[i].bossPetName} at {ifbs[i].kcPetAt} kills!");
                        ifbs[i].kcPetAt = 0;
                        ifbs[i].totalThreshold = 1;
                    }
                    totalTotalKills += 3800;
                }
                int averageKcPerPet = (totalTotalKills / (simulations * 39));
                int averagePerIFBComplete = (totalTotalKills / simulations);
                Console.WriteLine("-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Your minimum KC for a boss was {ifbMin.bossPetName} from {ifbMin.nameOfBoss} at {ifbMin.kcPetAt} kills!");
                Console.WriteLine($"Your maximum KC for a boss was {ifbMax.bossPetName} from {ifbMax.nameOfBoss} at {ifbMax.kcPetAt} kills!");
                Console.WriteLine("-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($"Your average amount of kills per pet was {averageKcPerPet}!");
                Console.WriteLine($"It took you a total of {totalTotalKills} kills to complete Insane Final Boss {simulations} times!");
                Console.WriteLine($"Over the course of {simulations} simulations, you averaged a total of {averagePerIFBComplete} kills to complete Insane Final Boss!");
                Console.WriteLine($"Over the course of {simulations} simulations, your minimum KC for a boss was {totalMin} from {minBossName}!");
                Console.WriteLine($"Over the course of {simulations} simulations, your maximum KC for a boss was {totalMax} from {maxBossName}!");
                Console.WriteLine("-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("Would you like to simulate again? (Y/N)");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("y") || answer.ToLower().Equals("yes"))
                {
                    totalTotalKills = 0;
                    ifbMax.kcPetAt = -999;
                    ifbMin.kcPetAt = -999;
                    continue;
                }
                else
                    break;
            }



        }
    }
    public class RandomGenerator
    { 
        private readonly Random _random = new Random();     
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }

}
