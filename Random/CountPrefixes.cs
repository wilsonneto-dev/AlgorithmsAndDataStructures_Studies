// https://leetcode.com/problems/count-prefixes-of-a-given-string/

public class Solution {
    public int CountPrefixes(string[] words, string s) {
        int prefixesCount = 0;
        for(int i = 0; i < words.Length; i++)
        {
            if(words[i].Length > s.Length) continue;
            for(int j = 0; j < words[i].Length; j++)
                if(words[i][j] != s[j]) break;
                else if(j == words[i].Length -1) prefixesCount++;
        }
        return prefixesCount;
    }
}
