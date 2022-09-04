// leetcode: https://leetcode.com/problems/permutation-in-string/submissions/

// 22/09/04 -> 40 minutes

public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // fill a hash table with the chars and counts of them
        var charsToCheckHashTable = new Dictionary<char, int>();
        for(int i = 0; i < s1.Length; i++)
           charsToCheckHashTable[s1[i]] = charsToCheckHashTable.ContainsKey(s1[i]) ? charsToCheckHashTable[s1[i]] + 1 : 1;
        
        // iterate in the s2 and identify the permutations
        int permutationCounter = 0, lastStart = -1;
        var foundCharsHashTable = new Dictionary<char, int>();
        for(int i = 0; i < s2.Length; i++)
        {
            if(charsToCheckHashTable.ContainsKey(s2[i]))
            {
                if(permutationCounter == 0) lastStart = i;
                    
                foundCharsHashTable[s2[i]] = foundCharsHashTable.ContainsKey(s2[i]) ? foundCharsHashTable[s2[i]] + 1 : 1;
                if(foundCharsHashTable[s2[i]] > charsToCheckHashTable[s2[i]])
                {
                    i = lastStart;
                    permutationCounter = 0;
                    foundCharsHashTable = new();
                    continue;
                }
                ++permutationCounter;
                if(permutationCounter == s1.Length)
                    return true;
            }
            else if(permutationCounter > 0) 
            {
                permutationCounter = 0;
                foundCharsHashTable = new();
            }
        }
        
        return false;
    }
}