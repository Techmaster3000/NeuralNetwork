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
        public static readonly int[,] imgA1 = { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden imageA1 = new ImageHidden(imgA1, 'A');
        public static readonly int[,] imgA2 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageA2 = new ImageHidden(imgA2, 'A');
        public static readonly int[,] imgA3 = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageA3 = new ImageHidden(imgA3, 'A');
        public static readonly int[,] imgA4 = { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly ImageHidden imageA4 = new ImageHidden(imgA4, 'A');
        public static readonly int[,] imgA5 = { { 1, 0, 0 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly ImageHidden imageA5 = new ImageHidden(imgA5, 'A');
        public static readonly int[,] imgA6 = { { 0, 1, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageA6 = new ImageHidden(imgA6, 'A');
        public static readonly int[,] imgA7 = { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } }; public readonly ImageHidden imageA7 = new ImageHidden(imgA7, 'A');
        public static readonly int[,] imgA8 = { { 0, 1, 0 }, { 0, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageA8 = new ImageHidden(imgA8, 'A'); // Rotatie
        public static readonly int[,] imgA9 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageA9 = new ImageHidden(imgA9, 'A'); // Verschuiving
        public static readonly int[,] imgA10 = { { 0, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageA10 = new ImageHidden(imgA10, 'A'); // Ruis

        // Letter B variaties
        public static readonly int[,] imgB1 = { { 1, 1, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly ImageHidden imageB1 = new ImageHidden(imgB1, 'B');
        public static readonly int[,] imgB2 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageB2 = new ImageHidden(imgB2, 'B');
        public static readonly int[,] imgB3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden imageB3 = new ImageHidden(imgB3, 'B');
        public static readonly int[,] imgB4 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageB4 = new ImageHidden(imgB4, 'B');
        public static readonly int[,] imgB5 = { { 1, 0, 1 }, { 1, 1, 0 }, { 1, 0, 1 } }; public readonly ImageHidden imageB5 = new ImageHidden(imgB5, 'B');
        public static readonly int[,] imgB6 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageB6 = new ImageHidden(imgB6, 'B');
        public static readonly int[,] imgB7 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly ImageHidden imageB7 = new ImageHidden(imgB7, 'B');
        public static readonly int[,] imgB8 = { { 0, 1, 1 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageB8 = new ImageHidden(imgB8, 'B'); // Rotatie
        public static readonly int[,] imgB9 = { { 0, 0, 1 }, { 1, 1, 1 }, { 0, 0, 1 } }; public readonly ImageHidden imageB9 = new ImageHidden(imgB9, 'B'); // Verschuiving
        public static readonly int[,] imgB10 = { { 1, 1, 0 }, { 1, 1, 0 }, { 1, 0, 1 } }; public readonly ImageHidden imageB10 = new ImageHidden(imgB10, 'B'); // Ruis

        // Letter C variaties
        public static readonly int[,] imgC1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly ImageHidden imageC1 = new ImageHidden(imgC1, 'C');
        public static readonly int[,] imgC2 = { { 0, 1, 1 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly ImageHidden imageC2 = new ImageHidden(imgC2, 'C');
        public static readonly int[,] imgC3 = { { 1, 1, 0 }, { 1, 0, 0 }, { 0, 1, 1 } }; public readonly ImageHidden imageC3 = new ImageHidden(imgC3, 'C');
        public static readonly int[,] imgC4 = { { 1, 0, 1 }, { 1, 0, 0 }, { 1, 0, 1 } }; public readonly ImageHidden imageC4 = new ImageHidden(imgC4, 'C');
        public static readonly int[,] imgC5 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden imageC5 = new ImageHidden(imgC5, 'C');
        public static readonly int[,] imgC6 = { { 0, 1, 1 }, { 0, 0, 1 }, { 0, 1, 1 } }; public readonly ImageHidden imageC6 = new ImageHidden(imgC6, 'C');
        public static readonly int[,] imgC7 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly ImageHidden imageC7 = new ImageHidden(imgC7, 'C');
        public static readonly int[,] imgC8 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 0 } }; public readonly ImageHidden imageC8 = new ImageHidden(imgC8, 'C'); // Rotatie
        public static readonly int[,] imgC9 = { { 0, 1, 1 }, { 0, 0, 0 }, { 0, 1, 1 } }; public readonly ImageHidden imageC9 = new ImageHidden(imgC9, 'C'); // Verschuiving
        public static readonly int[,] imgC10 = { { 1, 1, 0 }, { 1, 0, 0 }, { 0, 1, 0 } }; public readonly ImageHidden imageC10 = new ImageHidden(imgC10, 'C'); // Ruis

        // Letter D variaties
        public static readonly int[,] imgD1 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageD1 = new ImageHidden(imgD1, 'D');
        public static readonly int[,] imgD2 = { { 1, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageD2 = new ImageHidden(imgD2, 'D');
        public static readonly int[,] imgD3 = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageD3 = new ImageHidden(imgD3, 'D');
        public static readonly int[,] imgD4 = { { 1, 1, 0 }, { 0, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageD4 = new ImageHidden(imgD4, 'D');
        public static readonly int[,] imgD5 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly ImageHidden imageD5 = new ImageHidden(imgD5, 'D');
        public static readonly int[,] imgD6 = { { 1, 0, 0 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden imageD6 = new ImageHidden(imgD6, 'D');
        public static readonly int[,] imgD7 = { { 1, 1, 0 }, { 0, 0, 1 }, { 0, 1, 1 } }; public readonly ImageHidden imageD7 = new ImageHidden(imgD7, 'D');
        public static readonly int[,] imgD8 = { { 1, 1, 0 }, { 1, 0, 1 }, { 0, 1, 1 } }; public readonly ImageHidden imageD8 = new ImageHidden(imgD8, 'D'); // Rotatie
        public static readonly int[,] imgD9 = { { 0, 0, 1 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden imageD9 = new ImageHidden(imgD9, 'D'); // Verschuiving
        public static readonly int[,] imgD10 = { { 1, 1, 0 }, { 0, 0, 1 }, { 1, 0, 1 } }; public readonly ImageHidden imageD10 = new ImageHidden(imgD10, 'D'); // Ruis

        // Cijfer 1 variaties
        public static readonly int[,] img1_1 = { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly ImageHidden image1_1 = new ImageHidden(img1_1, '1');
        public static readonly int[,] img1_2 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly ImageHidden image1_2 = new ImageHidden(img1_2, '1');
        public static readonly int[,] img1_3 = { { 0, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly ImageHidden image1_3 = new ImageHidden(img1_3, '1');
        public static readonly int[,] img1_4 = { { 0, 1, 0 }, { 1, 1, 0 }, { 0, 1, 0 } }; public readonly ImageHidden image1_4 = new ImageHidden(img1_4, '1');
        public static readonly int[,] img1_5 = { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 1, 0 } }; public readonly ImageHidden image1_5 = new ImageHidden(img1_5, '1');
        public static readonly int[,] img1_6 = { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } }; public readonly ImageHidden image1_6 = new ImageHidden(img1_6, '1');
        public static readonly int[,] img1_7 = { { 0, 0, 1 }, { 0, 0, 1 }, { 0, 0, 1 } }; public readonly ImageHidden image1_7 = new ImageHidden(img1_7, '1');
        public static readonly int[,] img1_8 = { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 0, 1 } }; public readonly ImageHidden image1_8 = new ImageHidden(img1_8, '1'); // Rotatie
        public static readonly int[,] img1_9 = { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } }; public readonly ImageHidden image1_9 = new ImageHidden(img1_9, '1'); // Verschuiving
        public static readonly int[,] img1_10 = { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image1_10 = new ImageHidden(img1_10, '1'); // Ruis

        // Cijfer 2 variaties
        public static readonly int[,] img2_1 = { { 1, 1, 0 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly ImageHidden image2_1 = new ImageHidden(img2_1, '2');
        public static readonly int[,] img2_2 = { { 1, 0, 1 }, { 1, 1, 0 }, { 0, 1, 1 } }; public readonly ImageHidden image2_2 = new ImageHidden(img2_2, '2');
        public static readonly int[,] img2_3 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden image2_3 = new ImageHidden(img2_3, '2');
        public static readonly int[,] img2_4 = { { 0, 1, 1 }, { 0, 1, 0 }, { 1, 1, 1 } }; public readonly ImageHidden image2_4 = new ImageHidden(img2_4, '2');
        public static readonly int[,] img2_5 = { { 1, 1, 0 }, { 1, 0, 1 }, { 1, 1, 0 } }; public readonly ImageHidden image2_5 = new ImageHidden(img2_5, '2');
        public static readonly int[,] img2_6 = { { 1, 0, 0 }, { 1, 1, 0 }, { 0, 1, 1 } }; public readonly ImageHidden image2_6 = new ImageHidden(img2_6, '2');
        public static readonly int[,] img2_7 = { { 0, 1, 1 }, { 0, 1, 1 }, { 1, 1, 1 } }; public readonly ImageHidden image2_7 = new ImageHidden(img2_7, '2');
        public static readonly int[,] img2_8 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } }; public readonly ImageHidden image2_8 = new ImageHidden(img2_8, '2'); // Rotatie
        public static readonly int[,] img2_9 = { { 0, 1, 1 }, { 0, 0, 1 }, { 0, 0, 0 } }; public readonly ImageHidden image2_9 = new ImageHidden(img2_9, '2'); // Verschuiving
        public static readonly int[,] img2_10 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image2_10 = new ImageHidden(img2_10, '2'); // Ruis

        // Cijfer 3 variaties
        public static readonly int[,] img3_1 = { { 1, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image3_1 = new ImageHidden(img3_1, '3');
        public static readonly int[,] img3_2 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 0, 1 } }; public readonly ImageHidden image3_2 = new ImageHidden(img3_2, '3');
        public static readonly int[,] img3_3 = { { 1, 1, 1 }, { 0, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden image3_3 = new ImageHidden(img3_3, '3');
        public static readonly int[,] img3_4 = { { 0, 1, 1 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image3_4 = new ImageHidden(img3_4, '3');
        public static readonly int[,] img3_5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image3_5 = new ImageHidden(img3_5, '3');
        public static readonly int[,] img3_6 = { { 1, 0, 1 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image3_6 = new ImageHidden(img3_6, '3');
        public static readonly int[,] img3_7 = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 1, 1 } }; public readonly ImageHidden image3_7 = new ImageHidden(img3_7, '3');
        public static readonly int[,] img3_8 = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } }; public readonly ImageHidden image3_8 = new ImageHidden(img3_8, '3'); // Rotatie
        public static readonly int[,] img3_9 = { { 0, 0, 1 }, { 0, 1, 0 }, { 0, 0, 1 } }; public readonly ImageHidden image3_9 = new ImageHidden(img3_9, '3'); // Verschuiving
        public static readonly int[,] img3_10 = { { 1, 0, 0 }, { 0, 1, 0 }, { 1, 1, 0 } }; public readonly ImageHidden image3_10 = new ImageHidden(img3_10, '3'); // Ruis

        //Letter E
        public static readonly int[,] imgE1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 1, 1 } }; public readonly ImageHidden imageE1 = new ImageHidden(imgE1, 'E');
        public static readonly int[,] imgE2 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageE2 = new ImageHidden(imgE2, 'E');
        public static readonly int[,] imgE3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } }; public readonly ImageHidden imageE3 = new ImageHidden(imgE3, 'E');
        public static readonly int[,] imgE4 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly ImageHidden imageE4 = new ImageHidden(imgE4, 'E');
        public static readonly int[,] imgE5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 1, 0 } }; public readonly ImageHidden imageE5 = new ImageHidden(imgE5, 'E'); // Nieuw
        public static readonly int[,] imgE6 = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageE6 = new ImageHidden(imgE6, 'E'); // Nieuw

        //Letter F
        public static readonly int[,] imgF1 = { { 1, 1, 1 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageF1 = new ImageHidden(imgF1, 'F');
        public static readonly int[,] imgF2 = { { 1, 0, 0 }, { 1, 1, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageF2 = new ImageHidden(imgF2, 'F');
        public static readonly int[,] imgF3 = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 0 } }; public readonly ImageHidden imageF3 = new ImageHidden(imgF3, 'F');
        public static readonly int[,] imgF4 = { { 1, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } }; public readonly ImageHidden imageF4 = new ImageHidden(imgF4, 'F');
        public static readonly int[,] imgF5 = { { 1, 1, 0 }, { 1, 0, 0 }, { 1, 0, 0 } }; public readonly ImageHidden imageF5 = new ImageHidden(imgF5, 'F'); // Nieuw
        public static readonly int[,] imgF6 = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 0, 1 } }; public readonly ImageHidden imageF6 = new ImageHidden(imgF6, 'F'); // Nieuw
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
            ImageSetHidden images = new ImageSetHidden();
            imageNetworkHidden net = new imageNetworkHidden(inputSize: 9, hiddenSize: 8, outputSize: 7, learningRate: 0.1);

            // Training
            ImageHidden[] trainingData = {
                images.imageA1, images.imageA2, images.imageA3, images.imageA4, images.imageA5,
                images.imageB1, images.imageB2, images.imageB3, images.imageB4, images.imageB5,
                images.imageC1, images.imageC2, images.imageC3, images.imageC4, images.imageC5,
                images.imageD1, images.imageD2, images.imageD3, images.imageD4, images.imageD5,
                images.image1_1, images.image1_2, images.image1_3, images.image1_4, images.image1_5,
                images.image2_1, images.image2_2, images.image2_3, images.image2_4, images.image2_5,
                images.image3_1, images.image3_2, images.image3_3, images.image3_4, images.image3_5
            };
            ImageHidden[] testData = {
                images.imageA1, images.imageB1, images.imageC1, images.imageD1,
                images.image1_1, images.image2_1, images.image3_1,
                images.imageE1, images.imageE2, images.imageF1, images.imageF2 // Test met E en F
            };

            for (int epoch = 0; epoch < 20000; epoch++)
            {
                foreach (var img in trainingData)
                {
                    double[] input = imageNetworkHidden.Flatten(img.ImgArray);
                    int targetIndex = Array.IndexOf(imageNetworkHidden.charArray, img.Label);
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
                double[] input = imageNetworkHidden.Flatten(img.ImgArray);
                int prediction = net.Predict(input);
                char predictedChar;
                if (prediction < imageNetworkHidden.indexToChar.Count)
                    predictedChar = imageNetworkHidden.indexToChar[prediction];
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
