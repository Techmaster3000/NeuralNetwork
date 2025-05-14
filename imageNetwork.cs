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
    public class ImageSet {
        public static readonly int[,] imgJ =
        {
            {0,0,1},
            {0,0,1},
            {1,1,1}
        };
        public readonly Image imageJ = new Image(imgJ, 'J');

        public static readonly int[,] imgP =
        {
            {1,1,1},
            {1,1,1},
            {1,0,0}
        };
        public readonly Image imageP = new Image(imgP, 'P');

        public static readonly int[,] imgQ =
        {
            {1,1,1},
            {1,0,1},
            {1,1,0}
        };
        public readonly Image imageQ = new Image(imgQ, 'Q');
        public static readonly int[,] imgA =
            {
                {0,1,0},
                {1,0,1},
                {1,1,1}
            };
            public readonly Image imageA = new Image(imgA, 'A');

            public static readonly int[,] imgB =
            {
                {1,1,0},
                {1,1,1},
                {1,1,1}
    };
            public readonly Image imageB = new Image(imgB, 'B');

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

        private static char[] charArray = ['J', 'P', 'Q', 'A', 'B', 'H', 'O', 'U', 'D', 'C', 'X', 'Y', '.', '\\', '/', '<', '>', '^', 'v', '[', ']', '_', '+', '-', '=', 'L', ':', 'I', 'K', 'V', '1'];
        private static Dictionary<int, char> indexToChar = new Dictionary<int, char> { 
            {0, 'J'}, {1, 'P'}, {2, 'Q'}, {3, 'A'}, {4, 'B'}, {5, 'H'}, {6, 'O'}, {7, 'U'},
            {8, 'D'}, {9, 'C'}, {10, 'X'}, {11, 'Y'}, {12, '.'}, {13, '\\'}, {14, '/'},
            {15, '<'}, {16, '>'}, {17, '^'}, {18, 'v'}, {19, '['}, {20, ']'}, {21, '_'},
            {22, '+'}, {23, '-'}, {24, '='}, {25, 'L'}, {26, ':'}, {27, 'I'}, {28, 'K'},
            {29, 'V'}, {30, '1'}
        };
    //create a dictionary with an int for each char
        private bool[] boolArray = new bool[charArray.Length];

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        private double SigmoidDerivative(double x) => x * (1 - x);

        public imageNetwork(int inputSize = 9, int hiddenSize = 4, int outputSize = 26, double learningRate = 0.01)
        {
            this.inputSize = inputSize;
            this.hiddenSize = hiddenSize;
            this.outputSize = outputSize;
            this.learningRate = learningRate;

            weightsInputHidden = new double[inputSize, hiddenSize];
            weightsOutputHidden = new double[hiddenSize, outputSize];

            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize; j++)
                    weightsInputHidden[i, j] = rand.NextDouble() * 2 - 1;

            for (int i = 0; i < hiddenSize; i++)
                for (int j = 0; j < outputSize; j++)
                    weightsOutputHidden[i, j] = rand.NextDouble() * 2 - 1;
        }
        /// <summary>
        /// Convert the 2D Binary images to a 1D array of doubles.
        /// </summary>
        /// <param name="array">The 3x3 image composed of binary values</param>
        /// <returns>The inputted image as a 1D array of doubles </returns>
        public static double[] Flatten(int[,] array)
        {
            double[] flat = new double[9];
            int index = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    flat[index++] = array[i, j];
            return flat;
        }

        public void Train(double[] input, int targetIndex)
        {
            // Forward pass
            double[] hidden = new double[hiddenSize];
            for (int j = 0; j < hiddenSize; j++)
                for (int i = 0; i < inputSize; i++)
                    hidden[j] += input[i] * weightsInputHidden[i, j];
            for (int j = 0; j < hiddenSize; j++)
                hidden[j] = Sigmoid(hidden[j]);

            double[] output = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                for (int j = 0; j < hiddenSize; j++)
                    output[k] += hidden[j] * weightsOutputHidden[j, k];
            for (int k = 0; k < outputSize; k++)
                output[k] = Sigmoid(output[k]);

            // Output error
            double[] target = new double[outputSize];
            target[targetIndex] = 1;
            double[] outputErrors = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                outputErrors[k] = (target[k] - output[k]) * SigmoidDerivative(output[k]);

            // Backprop to hidden layer
            double[] hiddenErrors = new double[hiddenSize];
            for (int j = 0; j < hiddenSize; j++)
                for (int k = 0; k < outputSize; k++)
                    hiddenErrors[j] += outputErrors[k] * weightsOutputHidden[j, k];

            // Update weights output->hidden
            for (int j = 0; j < hiddenSize; j++)
                for (int k = 0; k < outputSize; k++)
                    weightsOutputHidden[j, k] += learningRate * outputErrors[k] * hidden[j];

            // Update weights input->hidden
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize; j++)
                    weightsInputHidden[i, j] += learningRate * hiddenErrors[j] * SigmoidDerivative(hidden[j]) * input[i];
        }
        public int Predict(double[] input)
	    {
            double[] hidden = new double[hiddenSize];
            for (int j = 0; j < hiddenSize; j++)
                for (int i = 0; i < inputSize; i++)
                    hidden[j] += input[i] * weightsInputHidden[i, j];
            for (int j = 0; j < hiddenSize; j++)
                hidden[j] = Sigmoid(hidden[j]);

            double[] output = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                for (int j = 0; j < hiddenSize; j++)
                    output[k] += hidden[j] * weightsOutputHidden[j, k];
            for (int k = 0; k < outputSize; k++)
                output[k] = Sigmoid(output[k]);

            int maxIndex = 0;
            for (int k = 1; k < outputSize; k++)
                if (output[k] > output[maxIndex]) maxIndex = k;

            return maxIndex;
        }

        public static void Main(string[] args)
        {
            ImageSet images = new ImageSet();
            imageNetwork net = new imageNetwork(3 * 3, hiddenSize: 4, learningRate: 0.01);

            // Training
            Image[] trainingData = {
                images.imageJ, images.imageP, images.imageQ, images.imageA, images.imageB,
        images.imageH, images.imageO, images.imageU, images.imageD, images.imageC,
        images.imageX, images.imageY, images.imageDot, images.imageBkslsh, images.imageFwdslsh,
        images.imageArrowLft, images.imageArrowRgt, images.imageArrowUp, images.imageArrowDwn,
        images.imageArrowSqrOpen, images.imageArrowSqrClose, images.imageUnderscore, images.imagePlus
    };
            Image[] testData = {
        images.imageJ, images.imageP, images.imageQ, images.imageA, images.imageB,
        images.imageH, images.imageO, images.imageU, images.imageD, images.imageC,
        images.imageX, images.imageY, images.imageDot, images.imageBkslsh, images.imageFwdslsh,
        images.imageArrowLft, images.imageArrowRgt, images.imageArrowUp, images.imageArrowDwn,
        images.imageArrowSqrOpen, images.imageArrowSqrClose, images.imageUnderscore, images.imagePlus, images.imageDash, images.imageEqual, images.imageL, images.imageColon, images.imageI,
        images.imageK, images.imageV, images.image1
    };

            for (int epoch = 0; epoch < 5000; epoch++)
            {
                foreach (var img in trainingData)
                {
                    double[] input = imageNetwork.Flatten(img.ImgArray);
                    int targetIndex = Array.IndexOf(imageNetwork.charArray, img.Label);
                    net.Train(input, targetIndex);
                }
            }

            Console.WriteLine("=== TRAINING COMPLETE ===");

            // Testing
            foreach (var img in testData)
            {
                double[] input = imageNetwork.Flatten(img.ImgArray);
                int prediction = net.Predict(input);
                char predictedChar = imageNetwork.indexToChar[prediction];

                Console.WriteLine(img);
                Console.WriteLine($"Expected: {img.Label}, Predicted: {predictedChar}");
                Console.WriteLine(predictedChar == img.Label ? "✅ Correct" : "❌ Wrong");
                Console.WriteLine();
            }
        }
    }
}
