using System;

namespace MalawiElectoralCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================================MALAWI ELECTORAL COMMISSION================================\n");
            
            // Get total number of published centers
            const int percent = 100;
            Console.Write("Enter Total published centers: ");
            int totalPublishedCenters = int.Parse(Console.ReadLine());

            // Get the total number of registered votes
            Console.Write("Enter Total Registered Voters/Turnout: ");
            int totalRegisteredVotes = int.Parse(Console.ReadLine());
            Console.Write("Enter Total Votes Cast/Total Votes: ");
            int totalVotesCast = int.Parse(Console.ReadLine());

            // Get total number of Null & Void votes
            Console.Write("Enter Total Null & Void Votes/Invalid Votes: ");
            int nullAndVoid = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Valid Votes: ");
            int totalValidVotes = int.Parse(Console.ReadLine());

            // Get total valid votes for each candidate
            Console.Write("Enter Total Valid Votes for Dr Lazarus Chakwera: ");
            int totalValidVotesForLazarusChakwera = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Valid Votes for Peter Driver Sinos Kuwani: ");
            int totalValidVotesForPeterKuwani = int.Parse(Console.ReadLine());

            Console.Write("Enter Total Valid Votes for Professor Arthur Peter Mutharika: ");
            int totalValidVotesForArthurMutharika = int.Parse(Console.ReadLine());

            // Determine the winner
            if (totalValidVotesForLazarusChakwera > totalValidVotes / 2 + 1)
            {
                Console.WriteLine("Congratulations Dr Lazarus Maccathy Chakwera, you're a winner of the 2020 election\n\n");
            }
            else if (totalValidVotesForPeterKuwani > totalValidVotes / 2 + 1)
            {
                Console.WriteLine("Congratulations Peter Kuwani, you're a winner of the 2020 election\n\n");
            }
            else if (totalValidVotesForArthurMutharika > totalValidVotes / 2 + 1)
            {
                Console.WriteLine("Congratulations Professor Arthur Peter Mutharika, you're a winner of the 2020 election\n\n");
            }
            else
            {
                Console.WriteLine("No majority winner was found. RUNOFF may be required\n");
            }

            Console.WriteLine("____________________________________ELECTION STATISTICS___________________________________\n");

            // Calculating percentage

            // Calculating percentage for total votes cast
            double percentage = Math.Round((double)totalValidVotes * percent / totalValidVotes, 2);
            Console.WriteLine($"Total Votes Cast in percentage = {percentage}");

            // Calculating percentage for total valid votes for all candidates
            percentage = Math.Round((double)totalValidVotes * percent / totalVotesCast, 2);
            Console.WriteLine($"Total Valid Votes for all candidates in percentage = {percentage}");

            // Calculating percentage for null & void votes
            percentage = Math.Round((double)nullAndVoid * percent / totalValidVotes, 2);
            Console.WriteLine($"Total Null & Void votes in percentage = {percentage}");

            // Calculating percentage for Total Registered voters/turnout
            percentage = Math.Round((double)totalVotesCast * percent / totalRegisteredVotes, 2);
            Console.WriteLine($"Total Registered voters/turnout in percentage = {percentage}");

            // Calculating percentage for Dr Lazarus Chakwera
            percentage = Math.Round((double)totalValidVotesForLazarusChakwera * percent / totalValidVotes, 2);
            Console.WriteLine($"Total Valid Votes for Dr Lazarus Chakwera in percentage = {percentage}");

            // Calculating percentage for Peter Kuwani
            percentage = Math.Round((double)totalValidVotesForPeterKuwani * percent / totalValidVotes, 2);
            Console.WriteLine($"Total Valid Votes for Peter Kuwani in percentage = {percentage}");

            // Calculating percentage for Professor Mutharika
            percentage = Math.Round((double)totalValidVotesForArthurMutharika * percent / totalValidVotes, 2);
            Console.WriteLine($"Total Valid Votes for Professor Mutharika in percentage = {percentage}");
        }
    }
}
