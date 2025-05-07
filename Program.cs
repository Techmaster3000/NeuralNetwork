using System;

namespace SimpleNeuralNetwork
{
    class NeuralNetwork
    {
        private int inputSize;
        private int hiddenSize;
        private int outputSize = 1;

        private double[,] weightsInputHidden;
        private double[] hiddenBiases;
        private double[] hiddenOutputs;

        private double[] weightsHiddenOutput;
        private double outputBias;

        private double learningRate;

        public NeuralNetwork(int inputSize, int hiddenSize, double learningRate = 0.1)
        {
            this.inputSize = inputSize;
            this.hiddenSize = hiddenSize;
            this.learningRate = learningRate;

            weightsInputHidden = new double[inputSize, hiddenSize];
            hiddenBiases = new double[hiddenSize];
            hiddenOutputs = new double[hiddenSize];

            weightsHiddenOutput = new double[hiddenSize];

            Random rand = new Random();
            for (int i = 0; i < inputSize; i++)
                for (int j = 0; j < hiddenSize; j++)
                    weightsInputHidden[i, j] = rand.NextDouble() * 2 - 1;

            for (int j = 0; j < hiddenSize; j++)
            {
                hiddenBiases[j] = rand.NextDouble() * 2 - 1;
                weightsHiddenOutput[j] = rand.NextDouble() * 2 - 1;
            }

            outputBias = rand.NextDouble() * 2 - 1;
        }

        private double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
        private double SigmoidDerivative(double x) => x * (1 - x);

        public double Predict(double[] inputs)
        {
            // Feedforward
            for (int j = 0; j < hiddenSize; j++)
            {
                double sum = 0;
                for (int i = 0; i < inputSize; i++)
                    sum += inputs[i] * weightsInputHidden[i, j];
                sum += hiddenBiases[j];
                hiddenOutputs[j] = Sigmoid(sum);
            }

            double outputSum = 0;
            for (int j = 0; j < hiddenSize; j++)
                outputSum += hiddenOutputs[j] * weightsHiddenOutput[j];
            outputSum += outputBias;

            return Sigmoid(outputSum);
        }

        public void Train(double[] inputs, double target)
        {
            double prediction = Predict(inputs);
            double outputError = target - prediction;
            double outputGradient = SigmoidDerivative(prediction) * outputError;

            // Update weights from hidden to output
            for (int j = 0; j < hiddenSize; j++)
            {
                weightsHiddenOutput[j] += learningRate * outputGradient * hiddenOutputs[j];
            }
            outputBias += learningRate * outputGradient;

            // Backpropagation: hidden layer
            for (int j = 0; j < hiddenSize; j++)
            {
                double hiddenError = outputGradient * weightsHiddenOutput[j];
                double hiddenGradient = SigmoidDerivative(hiddenOutputs[j]) * hiddenError;

                for (int i = 0; i < inputSize; i++)
                {
                    weightsInputHidden[i, j] += learningRate * hiddenGradient * inputs[i];
                }
                hiddenBiases[j] += learningRate * hiddenGradient;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NeuralNetwork nn = new NeuralNetwork(4, 3); // 4 inputs, 3 hidden nodes

            // Voorbeelddata: XOR-achtig patroon (alleen voor demonstratie)
            double[][] inputs = {
                new double[] { 0, 0, 0, 0 },
                new double[] { 0, 1, 0, 1 },
                new double[] { 1, 0, 1, 0 },
                new double[] { 1, 1, 0, 0 },
                new double[] { 1, 1, 1, 1 },
                new double[] { 0, 0, 1, 1 },
                new double[] { 1, 0, 0, 1 },
                new double[] { 0, 1, 1, 0 },
            };

            double[] labels = { 0, 0, 1, 1, 1, 0, 1, 0 };

            // Train het netwerk
            for (int epoch = 0; epoch < 50000; epoch++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    nn.Train(inputs[i], labels[i]);
                }
            }

            // Testen
            Console.WriteLine("Testresultaten:");
            foreach (var input in inputs)
            {
                double output = nn.Predict(input);
                Console.WriteLine($"Input: {string.Join(", ", input)} => Output: {output:F2}");
            }
        }
    }
}
