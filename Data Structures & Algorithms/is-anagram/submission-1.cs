public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length) return false;

        var freq = new Dictionary<char, int>();

        foreach (char c in s)
            freq[c] = freq.GetValueOrDefault(c, 0) + 1;

        foreach (char c in t)
        {
            if (!freq.ContainsKey(c)) return false;
            freq[c]--;
            if (freq[c] < 0) return false;
        }

        return true;
    }
}
