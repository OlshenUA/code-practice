// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }

public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) 
    {
        List<List<Pair>> states = new List<List<Pair>>();

        for (int i = 0; i < pairs.Count; i++)
        {
            int j = i - 1;
            Pair current = pairs[i];

            while (j >= 0 && pairs[j].Key > current.Key)
            {
                pairs[j + 1] = pairs[j];
                j--;
            }
            pairs[j + 1] = current;
            states.Add(new List<Pair>(pairs));
        }
        return states;
    }
}
