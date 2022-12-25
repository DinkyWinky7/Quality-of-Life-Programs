using System;

public class Program{
    public static void Main(string[] args){
        long height, width; // height + width of entire sprite
        long block = 16; // # of pixels per square (block * block);
        long emptyBlock = 16; // all tilesets have 1 empty block (top-left)
        long finalResolutionModifier = 4; // multiplier at the end (16 * 4 = 64)
        
        // gets the number of blocks
        Console.WriteLine("How many blocks are there?");
        int numBlocks = Convert.ToInt32(Console.ReadLine());
        
        height = block;
        width = block * numBlocks + emptyBlock;
        
        long finalResolutionH = height * finalResolutionModifier;
        long finalResolutionW = width * finalResolutionModifier;
        
        string frw = Convert.ToString(finalResolutionW);
        string frh = Convert.ToString(finalResolutionH);
        
        string finalResolution = $"w: {frw} h: {frh}";
        
        Console.WriteLine($"You have {numBlocks} blocks.\nThe sprite resolution should be w: {width} and h: {height}.\n The final resolution will be {finalResolution}.");
    }
}
