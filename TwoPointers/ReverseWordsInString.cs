// https://leetcode.com/problems/reverse-words-in-a-string-iii/submissions/

// 22/08/09 -> 30 min -> time O(n) / space O(n)

public class Solution {
    public string ReverseWords(string s) {
        if(s.Length <= 1) 
            return s;
        
        var arr = s.ToCharArray();
        int startWordIdx = 0, finishWordIdx = 0;
        while(startWordIdx < s.Length - 1)
        {
            if(finishWordIdx+1 == s.Length || arr[finishWordIdx+1] == ' ')
            {
                int initialIdx = startWordIdx, finalIdx = finishWordIdx;
                while(initialIdx < finalIdx)
                {
                    var temp = s[initialIdx];
                    arr[initialIdx] = arr[finalIdx];
                    arr[finalIdx] = temp;
                    initialIdx++;
                    finalIdx--;
                }
                
                finishWordIdx += 2;
                startWordIdx = finishWordIdx;
            }
            else finishWordIdx++;
        }
        
        return new string(arr);
    }
}
