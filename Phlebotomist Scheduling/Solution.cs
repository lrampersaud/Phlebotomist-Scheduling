using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phlebotomist_Scheduling
{
    public class Solution
    {
        public List<List<Patient>> PhlebotomistsList { get; set; }
        public double Cost { get; set; }
        public Solution()
        {
            this.PhlebotomistsList = new List<List<Patient>>();
            this.Cost = 0f;
        }
        public Solution(List<List<Patient>> pElement)
        {
            this.PhlebotomistsList = pElement;
            this.Cost = 0f;
        }
        public Solution Clone()
        {
            Solution sol = new Solution();
            for (int i = 0; i < this.PhlebotomistsList.Count; i++)
            {
                sol.PhlebotomistsList.Add(new List<Patient>());
                foreach (var item in this.PhlebotomistsList[i])
                {
                    sol.PhlebotomistsList[i].Add(item);
                }
            }
            sol.Cost = this.Cost;
            return sol;
        }
        public override String ToString()
        {
            String sb = "";
            for (int i = 0; i < this.PhlebotomistsList.Count; i++)
            {
                sb += this.PhlebotomistsList[i].ToString() + "|";
            }
            return sb;
        }
    }
}
