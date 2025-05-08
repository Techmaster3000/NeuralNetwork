using System;

public class Images
{
    public int[,] imageH =
        {
         {1,0,1},
         {1,1,1},
         {1,0,1}
       };
    public int[,] imageO =
    {
         {1,1,1},
         {1,0,1},
         {1,1,1}
   };
    public int[,] imageT =
    {
         {1,1,1},
         {0,1,0},
         {0,1,0}
   };
    public int[,] imageU =
    {
         {1,0,1},
         {1,0,1},
         {1,1,1}
   };
    public int[,] imageD =
    {
         {1,1,0},
         {1,0,1},
         {1,1,0}
   };
    public int[,] imageC =
    {
         {1,1,1},
         {1,0,0},
         {1,1,1}
   };
    public int[,] imageX =
    {
         {1,0,1},
         {0,1,0},
         {1,0,1}
   };
    public int[,] imageY =
    {
         {1,0,1},
         {0,1,0},
         {0,1,0}
   };
    public int[,] imageDot =
    {
         {0,0,0},
         {0,1,0},
         {0,0,0}
   };
    public int[,] imageBkslsh =
    {
         {1,0,0},
         {0,1,0},
         {0,0,1}
   };
    public int[,] imageFwdslsh =
    {
         {0,0,1},
         {0,1,0},
         {1,0,0}
   };
    public int[,] imageArrowLft =
    {
         {0,1,0},
         {1,0,0},
         {0,1,0}
   };
    public int[,] imageArrowRgt =
    {
         {0,1,0},
         {0,0,1},
         {0,1,0}
   };
    public int[,] imageArrowUp =
    {
         {0,1,0},
         {1,0,1},
         {0,0,0}
   };
    public int[,] imageArrowDwn =
    {
         {0,0,0},
         {1,0,1},
         {0,1,0}
   };
    public int[,] imageArrowSqrOpen =
    {
         {1,1,0},
         {1,0,0},
         {1,1,0}
   };
    public int[,] imageArrowSqrClose =
    {
         {0,1,1},
         {0,0,1},
         {0,1,1}
   };
    public int[,] imageUnderscore =
    {
         {0,0,0},
         {0,0,0},
         {1,1,1}
   };
    public int[,] imagePlus =
    {
         {0,1,0},
         {1,1,1},
         {0,1,0}
   };
    public int[,] imageDash =
    {
         {0,0,0},
         {1,1,1},
         {0,0,0}
   };
    public int[,] imageEqual =
    {
         {1,1,1},
         {0,0,0},
         {1,1,1}
   };
    public int[,] imageL =
    {
         {1,0,0},
         {1,0,0},
         {1,1,1}
   };
    public int[,] imageColon =
    {
         {0,1,0},
         {0,0,0},
         {0,1,0}
   };
    public int[,] imageI =
    {
         {0,1,0},
         {0,1,0},
         {0,1,0}
   };
    public int[,] imageK =
    {
         {1,0,1},
         {1,1,0},
         {1,0,1}
   };
    public int[,] imageV =
    {
         {1,0,1},
         {1,0,1},
         {0,1,0}
   };
    public int[,] image1 =
    {
         {1,1,0},
         {0,1,0},
         {1,1,1}
   };

}
public class imageNetwork
{
    public 

    public static void Main(string[] args)
    {
        Images images = new Images();
        var x = images.imageO;
        Console.WriteLine("Image network initialized.");
        
    }
}
