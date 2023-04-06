// See https://aka.ms/new-console-template for more information
using HostsAlgorithm;

string[] A = new[] { "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
string[] B = new[] { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };
int[] result = Solution.solution(A, B);
foreach(int i in result)
{
	Console.WriteLine(i);
}