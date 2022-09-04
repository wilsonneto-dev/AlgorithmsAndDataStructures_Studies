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

// 22/09/03 (random review) -> 33 minutes -> time O(n) / space O(n)
public class Solution {
    public string ReverseWords(string s) {
        if(s.Length == 0) return s;
        string result = "";
        int wordStartIndex = 0, wordEndIndex = 0;
        while(wordEndIndex < s.Length)
        {
            if(wordEndIndex == s.Length - 1 || s[wordEndIndex + 1] == ' ')
            {
                result += ReverseStringPartial(wordStartIndex, wordEndIndex, s);
                if(wordEndIndex < s.Length - 1)
                    result += " ";
                wordStartIndex = wordEndIndex += 2;
                continue;
            }
            wordEndIndex += 1; 
        }
        return result;
    }
    
    private string ReverseStringPartial(int initialIndex, int finalIndex, string str)
    {
        char[] result = new char[finalIndex - initialIndex + 1];
        int offset = initialIndex;
        
        while(initialIndex <= finalIndex)
        {
            result[initialIndex - offset] = str[finalIndex];
            result[finalIndex - offset] = str[initialIndex];
            finalIndex--;
            initialIndex++;
        }
        
        return new string(result);
    }
}
