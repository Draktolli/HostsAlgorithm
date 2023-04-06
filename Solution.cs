using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostsAlgorithm
{
	public static class Solution
	{
		public static int[] solution(string[] A, string[] B)
		{
			List<string> forbidenHosts = new(B);
			List<int> result = new();

			for (int i = 0; i < A.Length; i++)
			{
				bool passed = true;
				string[] subDomains = A[i].Split('.');
				string currentHost = "";
				for (int j = subDomains.Length - 1; j > -1; j--)
				{
					currentHost = subDomains[j] + "." + currentHost;
					if (forbidenHosts.Contains(currentHost.TrimEnd('.')))
					{
						passed = false;
						break;
					}
				}
				if (passed)
				{
					result.Add(i);
				}
			}

			return result.ToArray();
		}
	}
}
