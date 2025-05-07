using System;

namespace NeuralNetworkExample
{
    class NeuralNetwork
    {
        private double[] weights;
        private double learningRate;

        public NeuralNetwork(int inputSize, double learningRate = 0.01)
        {
            this.learningRate = learningRate;
            weights = new double[inputSize];
            Random rand = new Random();

            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = rand.NextDouble() * 2 - 1; // Initialize weights randomly between -1 and 1
            }
        }

        public double Activate(double input)
        {
            // Sigmoid activation function
            return 1.0 / (1.0 + Math.Exp(-input));
        }

        public double Predict(double[] inputs)
        {
            double sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i];
            }
            return Activate(sum);
        }

        public void Train(double[] inputs, double target)
        {
            double prediction = Predict(inputs);
            double error = target - prediction;

            // Update weights using gradient descent
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] += learningRate * error * inputs[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NeuralNetwork nn = new NeuralNetwork(2);

            // Training data for an AND gate
            double[][] inputs = {
                new double[] { 0, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 1 }
            };

            double[] targets = { 0, 0, 0, 1 };

            // Train the neural network
            for (int epoch = 0; epoch < 10000; epoch++)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    nn.Train(inputs[i], targets[i]);
                }
            }

            // Test the neural network
            Console.WriteLine("Testing Neural Network:");
            foreach (var input in inputs)
            {
                Console.WriteLine($"Input: {input[0]}, {input[1]} => Output: {nn.Predict(input):F2}");
            }
        }
    }
}