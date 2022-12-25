using System;

public class Program{
    public static void Main(){
        Console.WriteLine("How big is the room?");
        long room = Convert.ToInt64(Console.ReadLine());
        int sqr = 32;
        long leftover = room % sqr;
        long addto = leftover;
        
        long leftover2 = leftover;
        
        while (leftover2 != 0){
            if (((addto + room) % sqr) > 0){
                addto++;
            }
            
            else if (((addto + room) % sqr) == 0){
                leftover2 = 0;
            }
        }
        
        long newRoom = room + addto;
        
        Console.WriteLine($"The leftover room is {leftover}.\nAdd {addto} to the size. It should be {newRoom}.");
    }
}
