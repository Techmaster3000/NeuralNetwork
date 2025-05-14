using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetwork
{
    public class Image
    {
        public int[,] ImgArray { get; set; }
        public char Label { get; set; }
        public Image(int[,] array, char label)
        {
            ImgArray = array;
            Label = label;
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
    public class ImageSet
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
    public class imageNetwork
    {
        private int inputSize;
        private int hiddenSize1;
        private int hiddenSize2;
        private int outputSize;
        private double learningRate;

        private double[,] weightsInputHidden1;
        private double[,] weightsHidden1Hidden2;
        private double[,] weightsOutputHidden2;
        private Random rand = new Random();

        private static char[] charArray = { 'A', 'B', 'C', 'D', '1', '2', '3', 'E', 'F' }; // Added E and F
        private static Dictionary<int, char> indexToChar = new Dictionary<int, char> {
            {0, 'A'}, {1, 'B'}, {2, 'C'}, {3, 'D'}, {4, '1'}, {5, '2'}, {6, '3'}, {7, 'E'}, {8, 'F'} // Added E and F
        };

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        private double SigmoidDerivative(double x) => x * (1 - x);

        public imageNetwork(int inputSize = 9, int hiddenSize1 = 10, int hiddenSize2 = 5, int outputSize = 9, double learningRate = 0.01) // Adjusted outputSize
        {
            this.inputSize = inputSize;
            this.hiddenSize1 = hiddenSize1;
            this.hiddenSize2 = hiddenSize2;
            this.outputSize = outputSize;
            this.learningRate = learningRate;

            weightsInputHidden1 = new double[inputSize, hiddenSize1];
            weightsHidden1Hidden2 = new double[hiddenSize1, hiddenSize2];
            weightsOutputHidden2 = new double[hiddenSize2, outputSize];

            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize1; j++)
                    weightsInputHidden1[i, j] = rand.NextDouble() * 2 - 1;

            for (int i = 0; i < hiddenSize1; i++)
                for (int j = 0; j < hiddenSize2; j++)
                    weightsHidden1Hidden2[i, j] = rand.NextDouble() * 2 - 1;

            for (int i = 0; i < hiddenSize2; i++)
                for (int j = 0; j < outputSize; j++)
                    weightsOutputHidden2[i, j] = rand.NextDouble() * 2 - 1;
        }
        public static double[] Flatten(int[,] array)
        {
            double[] flat = new double[array.GetLength(0) * array.GetLength(1)];
            int index = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++){
                    flat[index++] = array[i, j];
                }
            }
            return flat;
        }

        public void Train(double[] input, int targetIndex)
        {
            // Forward pass
            double[] hidden1 = new double[hiddenSize1];
            for (int j = 0; j < hiddenSize1; j++)
                for (int i = 0; i < inputSize; i++)
                    hidden1[j] += input[i] * weightsInputHidden1[i, j];
            for (int j = 0; j < hiddenSize1; j++)
                hidden1[j] = Sigmoid(hidden1[j]);

            double[] hidden2 = new double[hiddenSize2];
            for (int k = 0; k < hiddenSize2; k++)
                for (int j = 0; j < hiddenSize1; j++)
                    hidden2[k] += hidden1[j] * weightsHidden1Hidden2[j, k];
            for (int k = 0; k < hiddenSize2; k++)
                hidden2[k] = Sigmoid(hidden2[k]);

            double[] output = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                for (int j = 0; j < hiddenSize2; j++)
                    output[k] += hidden2[j] * weightsOutputHidden2[j, k];
            for (int k = 0; k < outputSize; k++)
                output[k] = Sigmoid(output[k]);

            // Output error
            double[] target = new double[outputSize];
            target[targetIndex] = 1;
            double[] outputErrors = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                outputErrors[k] = (target[k] - output[k]) * SigmoidDerivative(output[k]);

            // Backprop to hidden layer 2
            double[] hidden2Errors = new double[hiddenSize2];
            for (int j = 0; j < hiddenSize2; j++)
                for (int k = 0; k < outputSize; k++)
                    hidden2Errors[j] += outputErrors[k] * weightsOutputHidden2[j, k];

            // Backprop to hidden layer 1
            double[] hidden1Errors = new double[hiddenSize1];
            for (int j = 0; j < hiddenSize1; j++)
                for (int k = 0; k < hiddenSize2; k++)
                    hidden1Errors[j] += hidden2Errors[k] * weightsHidden1Hidden2[j, k];

            // Update weights output->hidden2
            for (int j = 0; j < hiddenSize2; j++)
                for (int k = 0; k < outputSize; k++)
                    weightsOutputHidden2[j, k] += learningRate * outputErrors[k] * hidden2[j];

            // Update weights hidden2->hidden1
            for (int i = 0; i < hiddenSize1; i++)
                for (int j = 0; j < hiddenSize2; j++)
                    weightsHidden1Hidden2[i, j] += learningRate * hidden2Errors[j] * SigmoidDerivative(hidden2[j]) * hidden1[i];

            // Update weights input->hidden1
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize1; j++)
                    weightsInputHidden1[i, j] += learningRate * hidden1Errors[j] * SigmoidDerivative(hidden1[j]) * input[i];
        }
        public int Predict(double[] input)
        {
            double[] hidden1 = new double[hiddenSize1];
            for (int j = 0; j < hiddenSize1; j++)
                for (int i = 0; i < inputSize; i++)
                    hidden1[j] += input[i] * weightsInputHidden1[i, j];
            for (int j = 0; j < hiddenSize1; j++)
                hidden1[j] = Sigmoid(hidden1[j]);

            double[] hidden2 = new double[hiddenSize2];
            for (int k = 0; k < hiddenSize2; k++)
                for (int j = 0; j < hiddenSize1; j++)
                    hidden2[k] += hidden1[j] * weightsHidden1Hidden2[j, k];
            for (int k = 0; k < hiddenSize2; k++)
                hidden2[k] = Sigmoid(hidden2[k]);

            double[] output = new double[outputSize];
            for (int k = 0; k < outputSize; k++)
                for (int j = 0; j < hiddenSize2; j++)
                    output[k] += hidden2[j] * weightsOutputHidden2[j, k];
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
            imageNetwork net = new imageNetwork(inputSize: 9, hiddenSize1: 12, hiddenSize2: 6, outputSize: 9, learningRate: 0.1); // Adjusted outputSize to 9

            // Training
            Image[] trainingData = {
                images.imageA1, images.imageA2, images.imageA3, images.imageA4, images.imageA5,
                images.imageB1, images.imageB2, images.imageB3, images.imageB4, images.imageB5,
                images.imageC1, images.imageC2, images.imageC3, images.imageC4, images.imageC5,
                images.imageD1, images.imageD2, images.imageD3, images.imageD4, images.imageD5,
                images.image1_1, images.image1_2, images.image1_3, images.image1_4, images.image1_5,
                images.image2_1, images.image2_2, images.image2_3, images.image2_4, images.image2_5,
                images.image3_1, images.image3_2, images.image3_3, images.image3_4, images.image3_5,
                images.imageE1, images.imageE2, images.imageE3, images.imageE4, images.imageE5, // Added E
                images.imageF1, images.imageF2, images.imageF3, images.imageF4, images.imageF5  // Added F
            };
            Image[] testData = {
                images.imageA1, images.imageB1, images.imageC1, images.imageD1,
                images.image1_1, images.image2_1, images.image3_1,
                images.imageE1, images.imageE2, images.imageF1, images.imageF2
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

            // Test with noisy data
            Console.WriteLine("\n=== TESTING WITH NOISY DATA ===");
            int noisyCorrectPredictions = 0;
            foreach (var img in testData)
            {
                double[] noisyInput = AddNoise(imageNetwork.Flatten(img.ImgArray), 0.2); // 20% noise
                int prediction = net.Predict(noisyInput);
                char predictedChar;
                 if (prediction < imageNetwork.indexToChar.Count)
                    predictedChar = imageNetwork.indexToChar[prediction];
                else
                    predictedChar = '?';
                Console.WriteLine("Original Image:\n" + img);
                Console.WriteLine("Noisy Image:\n" + NoisyArrayToString(noisyInput)); //Custom Noisy print
                Console.WriteLine($"Verwacht: {img.Label}, Voorspeld: {predictedChar}");
                if (predictedChar == img.Label)
                {
                    Console.WriteLine("✅ Correct");
                    noisyCorrectPredictions++;
                }
                else
                {
                    Console.WriteLine("❌ Fout");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Correcte voorspellingen (noisy data): {noisyCorrectPredictions} van de {testData.Length}");
            Console.WriteLine($"Noisy Accuracy: {(double)noisyCorrectPredictions / testData.Length * 100:F2}%");
        }

        // Function to add noise to input data
        static double[] AddNoise(double[] input, double noiseLevel)
        {
            double[] noisyInput = new double[input.Length];
            Random rand = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                if (rand.NextDouble() < noiseLevel)
                {
                    // Flip the pixel value
                    noisyInput[i] = 1 - input[i];
                }
                else
                {
                    noisyInput[i] = input[i];
                }
            }
            return noisyInput;
        }

        // Function to convert noisy input to string
        static string NoisyArrayToString(double[] array)
        {
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    output += (int)array[i * 3 + j] + " ";
                }
                output += "\n";
            }
            return output;
        }
    }
}
