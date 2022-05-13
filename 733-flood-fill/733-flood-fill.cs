public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        if(image[sr][sc]==newColor){
            return image;
        }
         List<List<int>> nodes = new List<List<int>>();
            int color = image[sr][sc];
            int rows = image.Length;
            int columns = image[0].Length;
            image[sr][sc] = newColor;
            do
            {
                if (nodes.Count>0)
                {
                    sr = nodes[0][0];
                    sc = nodes[0][1];

                    nodes.RemoveAt(0);
                }

                if (sc-1 >=0 && image[sr][sc-1]==color)
                {
                    image[sr][sc - 1] = newColor;
                    List<int> node = new List<int>();
                    node.Add(sr);
                    node.Add(sc-1);

                    nodes.Add(node);
                }
                if (sr - 1 >= 0 && image[sr-1][sc] == color)
                {
                    image[sr-1][sc] = newColor;
                    List<int> node = new List<int>();
                    node.Add(sr-1);
                    node.Add(sc);

                    nodes.Add(node);
                }
                if (sr + 1 < rows && image[sr+1][sc] == color)
                {
                    image[sr+1][sc] = newColor;
                    List<int> node = new List<int>();
                    node.Add(sr+1);
                    node.Add(sc);

                    nodes.Add(node);
                }
                if (sc + 1 < columns && image[sr][sc + 1] == color)
                {
                    image[sr][sc + 1] = newColor;
                    List<int> node = new List<int>();
                    node.Add(sr);
                    node.Add(sc + 1);

                    nodes.Add(node);
                }
            } while (nodes.Count != 0); ;
            return image;
    }
}