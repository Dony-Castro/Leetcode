using System.Text.RegularExpressions;

public class Solution {
    public bool IsPalindrome(string s) {
        string cleanedString = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower().Replace(" ", string.Empty);
        int i = 0;
        int j = cleanedString.Length - 1;
        foreach(char c in cleanedString.ToLower()) {
            if (cleanedString[i] == cleanedString[j]) {
                i = i+1;
                j = j-1;
                continue;
            } else {
                return false;
            }
        }
        return true;
    }
}
