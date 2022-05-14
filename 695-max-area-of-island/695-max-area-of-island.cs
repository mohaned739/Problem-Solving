public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
                    int max = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j]==1)
                    {
                        max = Math.Max(max, DFS(grid, i, j));
                    }
                }
            }
            return max;
        
    }
    int DFS(int[][]grid,int r,int c)
        {
            if (r<0||r>=grid.Length||c<0||c>=grid[r].Length||grid[r][c]==0)
            {
                return 0;
            }
            int count = 1;
            grid[r][c] = 0;
            count += DFS(grid, r+1, c);
            count += DFS(grid, r - 1, c);
            count += DFS(grid, r, c+1);
            count += DFS(grid, r, c - 1);



            return count;
        }
}