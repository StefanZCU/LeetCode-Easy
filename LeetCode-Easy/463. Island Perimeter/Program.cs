
public class Solution
{
    public int IslandPerimeter(int[][] grid)
    {
        int parameterCount = 0;

        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    int[,] direction =
                    {
                        {i - 1, j},
                        {i + 1, j},
                        {i, j + 1},
                        {i, j - 1}
                    };

                    for (int k = 0; k < direction.GetLength(0); k++)
                    {
                        if (IndexChecker(grid, direction[k, 0], direction[k, 1]))
                        {
                            if (grid[direction[k, 0]][direction[k, 1]] == 0)
                            {
                                parameterCount++;
                            }
                        }
                        else
                        {
                            parameterCount++;
                        }

                    }
                }
            }
        }

        return parameterCount;
    }

    public bool IndexChecker(int[][] grid, int row, int col)
    {
        return row >= 0 && row < grid.GetLength(0) &&
               col >= 0 && col < grid[row].Length;
    }
}