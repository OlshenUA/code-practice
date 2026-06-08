public class Solution 
{
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src) 
    {
        int[] distances = new int[n];
        Array.Fill(distances, int.MaxValue);
        distances[src] = 0;

        var adjList = new List<(int neighbor, int weight)>[n];
        for (int i = 0; i < n; i++)
        {
            adjList[i] = new List<(int, int)>();
        }

        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            adjList[u].Add((v, w));
        }

        var heap = new PriorityQueue<int, int>();
        heap.Enqueue(src, 0);

        while (heap.Count > 0)
        {
            heap.TryDequeue(out int current, out int currentDistance);

            if (currentDistance > distances[current])
                continue;

            foreach (var (neighbor, weight) in adjList[current])
            {
                int newDistance = currentDistance + weight;

                if (newDistance < distances[neighbor])
                {
                    distances[neighbor] = newDistance;
                    heap.Enqueue(neighbor, newDistance);
                }
            }
        }

        var result = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            result[i] = distances[i] == int.MaxValue
                ? -1
                : distances[i];
        }

        return result;
    }
}
