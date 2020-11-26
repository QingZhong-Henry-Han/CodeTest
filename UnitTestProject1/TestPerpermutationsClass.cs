using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTest;

namespace UnitTestCodeTest
{
    public class TestPerpermutationsClass
    {
        public TestPerpermutationsClass()
        {
        }

        public bool TestStrPermutationCase1()
        {
            bool bResult = true;
            string[] strs = { "A1" };
            CPermutations permObj = new CPermutations(strs);
            List<List<string>> results = permObj.CalPermutation(strs);
            if(results[0].Count != 1)
            {
                bResult = false;
            }
            if(results[0][0] != "A1")
            {
                bResult = false;
            }

            return bResult;
        }

        public bool TestStrPermutationCase2()
        {
            bool bResult = true;
            string[] strs = { "A1", "A2" };
            CPermutations permObj = new CPermutations(strs);
            List<List<string>> results = permObj.CalPermutation(strs);
 
            if (results.Count != 2)
            {
                bResult = false;
            }
            if ( (results[0][0] != "A1" && results[0][1] != "A2") && (results[1][0] != "A2" && results[1][1] != "A1"))
            {
                bResult = false;
            }

            return bResult;
        }

        public bool TestStrPermutationCase3()
        {
            bool bResult = true;
            string[] strs = { "A1", "A2", "A3" };
            CPermutations permutationObj = new CPermutations(strs);
            List<List<string>> results = permutationObj.CalPermutation(strs);
 
            if (results.Count != 6)
            {
                bResult = false;
            }

            if ((results[0][0] != "A1" && results[0][1] != "A2" && results[0][2] != "A3") &&
                (results[1][0] != "A1" && results[1][1] != "A3" && results[1][2] != "A2") &&
                (results[2][0] != "A2" && results[2][1] != "A1" && results[2][2] != "A3") &&
                (results[3][0] != "A2" && results[3][1] != "A3" && results[3][2] != "A1") &&
                (results[4][0] != "A3" && results[4][1] != "A1" && results[4][2] != "A2") &&
                (results[5][0] != "A3" && results[5][1] != "A2" && results[5][2] != "A1")    )
            {
                bResult = false;
            }

            return bResult;
        }
     }
}
