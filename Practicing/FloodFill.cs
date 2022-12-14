// 22.09.05 => round 1 -> iterative way -> O(n) / O(n)

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        // check the new color
        if(color == image[sr][sc])
            return image;
        int originalColor = image[sr][sc];

        // copy the image to a new image
        int[][] newImage = CopyImage(image);
        
        // change the current color and check for the next ones
        var queue = new Queue<(int, int)>();
        queue.Enqueue((sr, sc));
        while(queue.Count > 0)
        {
            var (i, j) = queue.Dequeue();
            newImage[i][j] = color;
            if(i > 0 && newImage[i-1][j] == originalColor) 
                queue.Enqueue((i - 1, j));
            if(i < (image.Length - 1) && newImage[i+1][j] == originalColor) 
                queue.Enqueue((i + 1, j));
            if(j < (newImage[i].Length - 1) && newImage[i][j+1] == originalColor) 
                queue.Enqueue((i, j + 1));
            if(j > 0 && newImage[i][j-1] == originalColor) 
                queue.Enqueue((i, j - 1));            
        }
        
        return newImage;
    }
    
    private int[][] CopyImage(int[][] image)
    {
        int[][] copy = new int[image.Length][];
        for(int i = 0; i < image.Length; i++)
        {
            copy[i] = new int[image[i].Length];
            for(int j = 0; j < image[i].Length; j++)
                copy[i][j] = image[i][j];
        }
        return copy;
    }
}

// eecursively way / DFS -> 22.09.6 - O(n) / O(n)

public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] == color)
            return image;
        
        var originalColor = image[sr][sc];
        image[sr][sc] = color;
        
        if(sr > 0 && image[sr-1][sc] == originalColor) FloodFill(image, sr-1, sc, color);
        if(sr < (image.Length - 1) && image[sr+1][sc] == originalColor) FloodFill(image, sr+1, sc, color);
        if(sc > 0 && image[sr][sc-1] == originalColor) FloodFill(image, sr, sc-1, color);
        if(sc < (image[0].Length - 1) && image[sr][sc+1] == originalColor) FloodFill(image, sr, sc+1, color);
        
        return image;
    }
}
