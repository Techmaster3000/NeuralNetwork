using System;

namespace NeuralNetwork { 
public class Image
{
    public int[,] ImgArray { get; set; }
    public char Label { get; set; }
    public Image(int[,] Array, char label)
    {
        ImgArray = Array;
        Label = label;
    }

    public override string ToString()
    {
        string output = ImgArray[0,0]  + " " + ImgArray[0, 1] + " " + ImgArray[0, 2] + "\n" +
                        ImgArray[1, 0] + " " + ImgArray[1, 1] + " " + ImgArray[1, 2] + "\n" +
                        ImgArray[2, 0] + " " + ImgArray[2, 1] + " " + ImgArray[2, 2] + "\n";
        return output;
    }
}
public class ImageSet
    {
        public static readonly int[,] imgH =
        {
         {1,0,1},
         {1,1,1},
         {1,0,1}
        };
        public readonly Image imageH = new Image(imgH, 'H');

        public static readonly int[,] imgO =
        {
         {1,1,1},
         {1,0,1},
         {1,1,1}
        };
        public readonly Image imageO = new Image(imgO, 'O');

        public static readonly int[,] imgT =
        {
         {1,1,1},
         {0,1,0},
         {0,1,0}
        };
        public static readonly int[,] imgU =
        {
         {1,0,1},
         {1,0,1},
         {1,1,1}
        };
        public readonly Image imageU = new Image(imgU, 'U');

        public static readonly int[,] imgD =
        {
         {1,1,0},
         {1,0,1},
         {1,1,0}
        };
        public readonly Image imageD = new Image(imgD, 'D');

        public static readonly int[,] imgC =
        {
         {1,1,1},
         {1,0,0},
         {1,1,1}
        };
        public readonly Image imageC = new Image(imgC, 'C');


        public static readonly int[,] imgX =
        {
         {1,0,1},
         {0,1,0},
         {1,0,1}
        };
        public readonly Image imageX = new Image(imgX, 'X');

        public static readonly int[,] imgY =
        {
         {1,0,1},
         {0,1,0},
         {0,1,0}
        };
        public readonly Image imageY = new Image(imgY, 'Y');

        public static readonly int[,] imgDot =
        {
         {0,0,0},
         {0,1,0},
         {0,0,0}
        };
        public readonly Image imageDot = new Image(imgDot, '.');

        public static readonly int[,] imgBkslsh =
        {
         {1,0,0},
         {0,1,0},
         {0,0,1}
        };
        public readonly Image imageBkslsh = new Image(imgBkslsh, '\\');

        public static readonly int[,] imgFwdslsh =
        {
         {0,0,1},
         {0,1,0},
         {1,0,0}
        };
        public readonly Image imageFwdslsh = new Image(imgFwdslsh, '/');

        public static readonly int[,] imgArrowLft =
        {
         {0,1,0},
         {1,0,0},
         {0,1,0}
        };
        public readonly Image imageArrowLft = new Image(imgArrowLft, '<');

        public static readonly int[,] imgArrowRgt =
        {
         {0,1,0},
         {0,0,1},
         {0,1,0}
        };
        public readonly Image imageArrowRgt = new Image(imgArrowRgt, '>');

        public static readonly int[,] imgArrowUp =
        {
         {0,1,0},
         {1,0,1},
         {0,0,0}
        };
        public readonly Image imageArrowUp = new Image(imgArrowUp, '^');

        public static readonly int[,] imgArrowDwn =
        {
         {0,0,0},
         {1,0,1},
         {0,1,0}
        };
        public readonly Image imageArrowDwn = new Image(imgArrowDwn, 'v');

        public static readonly int[,] imgArrowSqrOpen =
        {
         {1,1,0},
         {1,0,0},
         {1,1,0}
        };
        public readonly Image imageArrowSqrOpen = new Image(imgArrowSqrOpen, '[');

        public static readonly int[,] imgArrowSqrClose =
        {
         {0,1,1},
         {0,0,1},
         {0,1,1}
        };
        public readonly Image imageArrowSqrClose = new Image(imgArrowSqrClose, ']');

        public static readonly int[,] imgUnderscore =
        {
         {0,0,0},
         {0,0,0},
         {1,1,1}
        };
        public readonly Image imageUnderscore = new Image(imgUnderscore, '_');

        public static readonly int[,] imgPlus =
        {
         {0,1,0},
         {1,1,1},
         {0,1,0}
        };
        public readonly Image imagePlus = new Image(imgPlus, '+');

        public static readonly int[,] imgDash =
        {
         {0,0,0},
         {1,1,1},
         {0,0,0}
        };
        public readonly Image imageDash = new Image(imgDash, '-');

        public static readonly int[,] imgEqual =
        {
         {1,1,1},
         {0,0,0},
         {1,1,1}
        };
        public readonly Image imageEqual = new Image(imgEqual, '=');

        public static readonly int[,] imgL =
        {
         {1,0,0},
         {1,0,0},
         {1,1,1}
        };
        public readonly Image imageL = new Image(imgL, 'L');

        public static readonly int[,] imgColon =
        {
         {0,1,0},
         {0,0,0},
         {0,1,0}
        };
        public readonly Image imageColon = new Image(imgColon, ':');

        public static readonly int[,] imgI =
        {
         {0,1,0},
         {0,1,0},
         {0,1,0}
        };
        public readonly Image imageI = new Image(imgI, 'I');

        public static readonly int[,] imgK =
        {
         {1,0,1},
         {1,1,0},
         {1,0,1}
        };
        public readonly Image imageK = new Image(imgK, 'K');

        public static readonly int[,] imgV =
        {
         {1,0,1},
         {1,0,1},
         {0,1,0}
        };
        public readonly Image imageV = new Image(imgV, 'V');

        public static readonly int[,] img1 =
        {
         {1,1,0},
         {0,1,0},
         {1,1,1}
        };
        public readonly Image image1 = new Image(img1, '1');
    }
    public class imageNetwork {

        private int inputSize;
        private int hiddenSize;
        private int outputSize = 1;
        private double learningRate;

        private double[,] weightsInputHidden;
        private double[,] weightsOutputHidden;
        private Random rand = new Random();

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        private double SigmoidDerivative(double x) => x * (1 - x);

        public void Train()
	    {

	    }
	    public void Predict()
	    {
	    }

	    public static void Main(string[] args)
	    {
		    ImageSet images = new ImageSet();
		    var x = images.imageO;
		    Console.WriteLine("Image network initialized.");
		    Console.WriteLine(x);

	    }
    }
}
