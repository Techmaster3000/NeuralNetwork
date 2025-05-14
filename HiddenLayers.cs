using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    public class ImageHidden
    {
        private int[,] _imgArray; // Backing field for the property
        public int[,] ImgArray
        {
            get { return _imgArray; }
            set { _imgArray = value; }
        }
        public char Label { get; set; }
        public ImageHidden(int[,] array, char lbl)
        {
            this._imgArray = array;
            this.Label = lbl;
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < ImgArray.GetLength(0); i++)
            {
                for (int j = 0; j < ImgArray.GetLength(1); j++)
                {
                    output += ImgArray[i, j] + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
    public class ImageSetHidden
    {
        // Letter A variaties
        public static readonly int[,] imgA1 = { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly Image imageA1 = new Image(imgA1, 'A');
        public static readonly int[,] imgA2 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageA2 = new Image(imgA2, 'A');
        public static readonly int[,] imgA3 = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageA3 = new Image(imgA3, 'A');
        public static readonly int[,] imgA4 = { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly Image imageA4 = new Image(imgA4, 'A');
        public static readonly int[,] imgA5 = { { 1, 0, 0 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly Image imageA5 = new Image(imgA5, 'A');
        public static readonly int[,] imgA6 = { { 0, 1, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageA6 = new Image(imgA6, 'A');
        public static readonly int[,] imgA7 = { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } }; public readonly Image imageA7 = new Image(imgA7, 'A');
        public static readonly int[,] imgA8 = { { 0, 1, 0 }, { 0, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageA8 = new Image(imgA8, 'A'); // Rotatie
        public static readonly int[,] imgA9 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageA9 = new Image(imgA9, 'A'); // Verschuiving
        public static readonly int[,] imgA10 = { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageA10 = new Image(imgA10, 'A'); // Ruis

        // Letter B variaties
        public static readonly int[,] imgB1 = { { 1, 1, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly Image imageB1 = new Image(imgB1, 'B');
        public static readonly int[,] imgB2 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 1, 0 } }; public readonly Image imageB2 = new Image(imgB2, 'B');
        public static readonly int[,] imgB3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly Image imageB3 = new Image(imgB3, 'B');
        public static readonly int[,] imgB4 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageB4 = new Image(imgB4, 'B');
        public static readonly int[,] imgB5 = { { 1, 0, 1 }, { 1, 1, 0 }, { 1, 0, 1 } }; public readonly Image imageB5 = new Image(imgB5, 'B');
        public static readonly int[,] imgB6 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageB6 = new Image(imgB6, 'B');
        public static readonly int[,] imgB7 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly Image imageB7 = new Image(imgB7, 'B');
        public static readonly int[,] imgB8 = { { 0, 1, 1 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageB8 = new Image(imgB8, 'B'); // Rotatie
        public static readonly int[,] imgB9 = { { 0, 0, 1 }, { 1, 1, 1 }, { 0, 0, 1 } }; public readonly Image imageB9 = new Image(imgB9, 'B'); // Verschuiving
        public static readonly int[,] imgB10 = { { 1, 1, 0 }, { 1, 1, 0 }, { 1, 0, 1 } }; public readonly Image imageB10 = new Image(imgB10, 'B'); // Ruis

        // Letter C variaties
        public static readonly int[,] imgC1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly Image imageC1 = new Image(imgC1, 'C');
        public static readonly int[,] imgC2 = { { 0, 1, 1 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly Image imageC2 = new Image(imgC2, 'C');
        public static readonly int[,] imgC3 = { { 1, 1, 0 }, { 1, 0, 0 }, { 0, 1, 1 } }; public readonly Image imageC3 = new Image(imgC3, 'C');
        public static readonly int[,] imgC4 = { { 1, 0, 1 }, { 1, 0, 0 }, { 1, 0, 1 } }; public readonly Image imageC4 = new Image(imgC4, 'C');
        public static readonly int[,] imgC5 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly Image imageC5 = new Image(imgC5, 'C');
        public static readonly int[,] imgC6 = { { 0, 1, 1 }, { 0, 0, 1 }, { 0, 1, 1 } }; public readonly Image imageC6 = new Image(imgC6, 'C');
        public static readonly int[,] imgC7 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly Image imageC7 = new Image(imgC7, 'C');
        public static readonly int[,] imgC8 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 0 } }; public readonly Image imageC8 = new Image(imgC8, 'C'); // Rotatie
        public static readonly int[,] imgC9 = { { 0, 1, 1 }, { 0, 0, 0 }, { 0, 1, 1 } }; public readonly Image imageC9 = new Image(imgC9, 'C'); // Verschuiving
        public static readonly int[,] imgC10 = { { 1, 1, 0 }, { 1, 0, 0 }, { 0, 1, 0 } }; public readonly Image imageC10 = new Image(imgC10, 'C'); // Ruis

        // Letter D variaties
        public static readonly int[,] imgD1 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageD1 = new Image(imgD1, 'D');
        public static readonly int[,] imgD2 = { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageD2 = new Image(imgD2, 'D');
        public static readonly int[,] imgD3 = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageD3 = new Image(imgD3, 'D');
        public static readonly int[,] imgD4 = { { 1, 1, 0 }, { 0, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageD4 = new Image(imgD4, 'D');
        public static readonly int[,] imgD5 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly Image imageD5 = new Image(imgD5, 'D');
        public static readonly int[,] imgD6 = { { 1, 0, 0 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly Image imageD6 = new Image(imgD6, 'D');
        public static readonly int[,] imgD7 = { { 1, 1, 0 }, { 0, 0, 1 }, { 0, 1, 1 } }; public readonly Image imageD7 = new Image(imgD7, 'D');
        public static readonly int[,] imgD8 = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 1, 1 } }; public readonly Image imageD8 = new Image(imgD8, 'D'); // Rotatie
        public static readonly int[,] imgD9 = { { 0, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image imageD9 = new Image(imgD9, 'D'); // Verschuiving
        public static readonly int[,] imgD10 = { { 1, 1, 0 }, { 0, 0, 1 }, { 1, 0, 1 } }; public readonly Image imageD10 = new Image(imgD10, 'D'); // Ruis

        // Cijfer 1 variaties
        public static readonly int[,] img1_1 = { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly Image image1_1 = new Image(img1_1, '1');
        public static readonly int[,] img1_2 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly Image image1_2 = new Image(img1_2, '1');
        public static readonly int[,] img1_3 = { { 0, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly Image image1_3 = new Image(img1_3, '1');
        public static readonly int[,] img1_4 = { { 0, 1, 0 }, { 1, 1, 0 }, { 0, 1, 0 } }; public readonly Image image1_4 = new Image(img1_4, '1');
        public static readonly int[,] img1_5 = { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 1, 0 } }; public readonly Image image1_5 = new Image(img1_5, '1');
        public static readonly int[,] img1_6 = { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly Image image1_6 = new Image(img1_6, '1');
        public static readonly int[,] img1_7 = { { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 } }; public readonly Image image1_7 = new Image(img1_7, '1');
        public static readonly int[,] img1_8 = { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 0, 1 } }; public readonly Image image1_8 = new Image(img1_8, '1'); // Rotatie
        public static readonly int[,] img1_9 = { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } }; public readonly Image image1_9 = new Image(img1_9, '1'); // Verschuiving
        public static readonly int[,] img1_10 = { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly Image image1_10 = new Image(img1_10, '1'); // Ruis

        // Cijfer 2 variaties
        public static readonly int[,] img2_1 = { { 1, 1, 0 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly Image image2_1 = new Image(img2_1, '2');
        public static readonly int[,] img2_2 = { { 1, 0, 1 }, { 1, 1, 0 }, { 0, 1, 1 } }; public readonly Image image2_2 = new Image(img2_2, '2');
        public static readonly int[,] img2_3 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly Image image2_3 = new Image(img2_3, '2');
        public static readonly int[,] img2_4 = { { 0, 1, 1 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly Image image2_4 = new Image(img2_4, '2');
        public static readonly int[,] img2_5 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly Image image2_5 = new Image(img2_5, '2');
        public static readonly int[,] img2_6 = { { 1, 0, 0 }, { 1, 1, 0 }, { 0, 1, 1 } }; public readonly Image image2_6 = new Image(img2_6, '2');
        public static readonly int[,] img2_7 = { { 0, 1, 1 }, { 0, 1, 1 }, { 1, 1, 1 } }; public readonly Image image2_7 = new Image(img2_7, '2');
        public static readonly int[,] img2_8 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } }; public readonly Image image2_8 = new Image(img2_8, '2'); // Rotatie
        public static readonly int[,] img2_9 = { { 0, 1, 1 }, { 0, 0, 1 }, { 0, 0, 0 } }; public readonly Image image2_9 = new Image(img2_9, '2'); // Verschuiving
        public static readonly int[,] img2_10 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 1, 0 } }; public readonly Image image2_10 = new Image(img2_10, '2'); // Ruis

        // Cijfer 3 variaties
        public static readonly int[,] img3_1 = { { 1, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly Image image3_1 = new Image(img3_1, '3');
        public static readonly int[,] img3_2 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } }; public readonly Image image3_2 = new Image(img3_2, '3');
        public static readonly int[,] img3_3 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly Image image3_3 = new Image(img3_3, '3');
        public static readonly int[,] img3_4 = { { 0, 1, 1 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly Image image3_4 = new Image(img3_4, '3');
        public static readonly int[,] img3_5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly Image image3_5 = new Image(img3_5, '3');
        public static readonly int[,] img3_6 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly Image image3_6 = new Image(img3_6, '3');
        public static readonly int[,] img3_7 = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 1, 1 } }; public readonly Image image3_7 = new Image(img3_7, '3');
        public static readonly int[,] img3_8 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } }; public readonly Image image3_8 = new Image(img3_8, '3'); // Rotatie
        public static readonly int[,] img3_9 = { { 0, 0, 1 }, { 0, 1, 0 }, { 0, 0, 1 } }; public readonly Image image3_9 = new Image(img3_9, '3'); // Verschuiving
        public static readonly int[,] img3_10 = { { 1, 0, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly Image image3_10 = new Image(img3_10, '3'); // Ruis

        //Letter E
        public static readonly int[,] imgE1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly Image imageE1 = new Image(imgE1, 'E');
        public static readonly int[,] imgE2 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageE2 = new Image(imgE2, 'E');
        public static readonly int[,] imgE3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly Image imageE3 = new Image(imgE3, 'E');
        public static readonly int[,] imgE4 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly Image imageE4 = new Image(imgE4, 'E');
        public static readonly int[,] imgE5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly Image imageE5 = new Image(imgE5, 'E'); // Nieuw
        public static readonly int[,] imgE6 = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly Image imageE6 = new Image(imgE6, 'E'); // Nieuw

        //Letter F
        public static readonly int[,] imgF1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly Image imageF1 = new Image(imgF1, 'F');
        public static readonly int[,] imgF2 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly Image imageF2 = new Image(imgF2, 'F');
        public static readonly int[,] imgF3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 0 } }; public readonly Image imageF3 = new Image(imgF3, 'F');
        public static readonly int[,] imgF4 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly Image imageF4 = new Image(imgF4, 'F');
        public static readonly int[,] imgF5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly Image imageF5 = new Image(imgF5, 'F'); // Nieuw
        public static readonly int[,] imgF6 = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 1 } }; public readonly Image imageF6 = new Image(imgF6, 'F'); // Nieuw
    }
    public class imageNetworkHidden
    {
        private int inputSize;
        private int hiddenSize;
        private int outputSize;
        private double learningRate;

        private double[,] weightsInputHidden;
        private double[,] weightsOutputHidden;
        private Random rand = new Random();

        private static char[] charArray = { 'A', 'B', 'C', 'D', '1', '2', '3' };
        private static Dictionary<int, char> indexToChar = new Dictionary<int, char> {
            {0, 'A'}, {1, 'B'}, {2, 'C'}, {3, 'D'}, {4, '1'}, {5, '2'}, {6, '3'}
        };

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        private double SigmoidDerivative(double x) => x * (1 - x);

        public imageNetworkHidden(int inputSize = 9, int hiddenSize = 12, int outputSize = 7, double learningRate = 0.01)
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
        public static double[] Flatten(int[,] array)
        {
            double[] flat = new double[array.GetLength(0) * array.GetLength(1)];
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    flat[index++] = array[i, j];
                }
            }
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
            imageNetwork net = new imageNetwork(inputSize: 9, hiddenSize: 8, outputSize: 7, learningRate: 0.1);

            // Training
            Image[] trainingData = {
                images.imageA1, images.imageA2, images.imageA3, images.imageA4, images.imageA5,
                images.imageB1, images.imageB2, images.imageB3, images.imageB4, images.imageB5,
                images.imageC1, images.imageC2, images.imageC3, images.imageC4, images.imageC5,
                images.imageD1, images.imageD2, images.imageD3, images.imageD4, images.imageD5,
                images.image1_1, images.image1_2, images.image1_3, images.image1_4, images.image1_5,
                images.image2_1, images.image2_2, images.image2_3, images.image2_4, images.image2_5,
                images.image3_1, images.image3_2, images.image3_3, images.image3_4, images.image3_5
            };
            Image[] testData = {
                images.imageA1, images.imageB1, images.imageC1, images.imageD1,
                images.image1_1, images.image2_1, images.image3_1,
                images.imageE1, images.imageE2, images.imageF1, images.imageF2 // Test met E en F
            };

            for (int epoch = 0; epoch < 20000; epoch++)
            {
                foreach (var img in trainingData)
                {
                    double[] input = imageNetwork.Flatten(img.ImgArray);
                    int targetIndex = Array.IndexOf(imageNetwork.charArray, img.Label);
                    net.Train(input, targetIndex);
                }
                if (epoch % 1000 == 0)
                {
                    Console.WriteLine($"Epoch: {epoch}");
                }
            }

            Console.WriteLine("=== TRAINING COMPLETE ===");

            // Testing
            int correctPredictions = 0;
            foreach (var img in testData)
            {
                double[] input = imageNetwork.Flatten(img.ImgArray);
                int prediction = net.Predict(input);
                char predictedChar;
                if (prediction < imageNetwork.indexToChar.Count)
                    predictedChar = imageNetwork.indexToChar[prediction];
                else
                    predictedChar = '?'; // Voor onbekende letters
                Console.WriteLine(img);
                Console.WriteLine($"Verwacht: {img.Label}, Voorspeld: {predictedChar}");
                if (predictedChar == img.Label)
                {
                    Console.WriteLine("✅ Correct");
                    correctPredictions++;
                }
                else
                {
                    Console.WriteLine("❌ Fout");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Correcte voorspellingen: {correctPredictions} van de {testData.Length}");
            Console.WriteLine($"Accuracy: {(double)correctPredictions / testData.Length * 100:F2}%");
        }
    }
}
