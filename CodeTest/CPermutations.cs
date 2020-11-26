using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class CPermutations
    {
        public CPermutations(string[] strs)
        {
            m_Strs = strs;
            m_Results = new List<List<string>>();
        }

        public List<List<string>> CalPermutation(string[] strs)
        {
            GetPermutation(strs, 0, strs.Length-1);
            return m_Results;
        }

        void GetPermutation(string[] strs, int l, int r)
        {
            if(l == r)
            {
                List<string> tempList = new List<string>();
                foreach(string s in strs)
                {
                    tempList.Add(s);
                }
                m_Results.Add(tempList);
            }
            else
            {
                for( int i = l; i <= r; i++)
                {
                    Swap(ref strs[l], ref strs[i]); 
                    GetPermutation(strs, l + 1, r);
                    Swap(ref strs[l], ref strs[i]);
                }
            }
        }

        void Swap(ref string s1, ref string s2)
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
        }


        private string[] m_Strs;
        public List<List<string>> m_Results;
    }
}
