public class DeepImageNetwork
{
    int inputSize, hidden1Size, hidden2Size, outputSize;
    double learningRate;
    double[,] wInputHidden1, wHidden1Hidden2, wHidden2Output;
    Random rand = new Random();

    public DeepImageNetwork(int inputSize, int hidden1Size, int hidden2Size, int outputSize, double learningRate)
    {
        this.inputSize = inputSize;
        this.hidden1Size = hidden1Size;
        this.hidden2Size = hidden2Size;
        this.outputSize = outputSize;
        this.learningRate = learningRate;

        wInputHidden1 = InitWeights(inputSize, hidden1Size);
        wHidden1Hidden2 = InitWeights(hidden1Size, hidden2Size);
        wHidden2Output = InitWeights(hidden2Size, outputSize);
    }

    double[,] InitWeights(int rows, int cols)
    {
        double[,] weights = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                weights[i, j] = rand.NextDouble() - 0.5;
        return weights;
    }

    double Sigmoid(double x) => 1.0 / (1.0 + Math.Exp(-x));
    double SigmoidDerivative(double x) => x * (1 - x);

    public void Train(double[] input, int targetIndex)
    {
        // Forward pass
        double[] hidden1 = new double[hidden1Size];
        for (int j = 0; j < hidden1Size; j++)
            for (int i = 0; i < inputSize; i++)
                hidden1[j] += input[i] * wInputHidden1[i, j];
        for (int j = 0; j < hidden1Size; j++)
            hidden1[j] = Sigmoid(hidden1[j]);

        double[] hidden2 = new double[hidden2Size];
        for (int k = 0; k < hidden2Size; k++)
            for (int j = 0; j < hidden1Size; j++)
                hidden2[k] += hidden1[j] * wHidden1Hidden2[j, k];
        for (int k = 0; k < hidden2Size; k++)
            hidden2[k] = Sigmoid(hidden2[k]);

        double[] output = new double[outputSize];
        for (int l = 0; l < outputSize; l++)
            for (int k = 0; k < hidden2Size; k++)
                output[l] += hidden2[k] * wHidden2Output[k, l];
        for (int l = 0; l < outputSize; l++)
            output[l] = Sigmoid(output[l]);

        // Backpropagation
        double[] target = new double[outputSize];
        target[targetIndex] = 1;

        double[] outputErrors = new double[outputSize];
        for (int l = 0; l < outputSize; l++)
            outputErrors[l] = (target[l] - output[l]) * SigmoidDerivative(output[l]);

        double[] hidden2Errors = new double[hidden2Size];
        for (int k = 0; k < hidden2Size; k++)
        {
            for (int l = 0; l < outputSize; l++)
                hidden2Errors[k] += outputErrors[l] * wHidden2Output[k, l];
            hidden2Errors[k] *= SigmoidDerivative(hidden2[k]);
        }

        double[] hidden1Errors = new double[hidden1Size];
        for (int j = 0; j < hidden1Size; j++)
        {
            for (int k = 0; k < hidden2Size; k++)
                hidden1Errors[j] += hidden2Errors[k] * wHidden1Hidden2[j, k];
            hidden1Errors[j] *= SigmoidDerivative(hidden1[j]);
        }

        // Update weights
        for (int k = 0; k < hidden2Size; k++)
            for (int l = 0; l < outputSize; l++)
                wHidden2Output[k, l] += learningRate * outputErrors[l] * hidden2[k];

        for (int j = 0; j < hidden1Size; j++)
            for (int k = 0; k < hidden2Size; k++)
                wHidden1Hidden2[j, k] += learningRate * hidden2Errors[k] * hidden1[j];

        for (int i = 0; i < inputSize; i++)
            for (int j = 0; j < hidden1Size; j++)
                wInputHidden1[i, j] += learningRate * hidden1Errors[j] * input[i];
    }

    public int Predict(double[] input)
    {
        double[] hidden1 = new double[hidden1Size];
        for (int j = 0; j < hidden1Size; j++)
            for (int i = 0; i < inputSize; i++)
                hidden1[j] += input[i] * wInputHidden1[i, j];
        for (int j = 0; j < hidden1Size; j++)
            hidden1[j] = Sigmoid(hidden1[j]);

        double[] hidden2 = new double[hidden2Size];
        for (int k = 0; k < hidden2Size; k++)
            for (int j = 0; j < hidden1Size; j++)
                hidden2[k] += hidden1[j] * wHidden1Hidden2[j, k];
        for (int k = 0; k < hidden2Size; k++)
            hidden2[k] = Sigmoid(hidden2[k]);

        double[] output = new double[outputSize];
        for (int l = 0; l < outputSize; l++)
            for (int k = 0; k < hidden2Size; k++)
                output[l] += hidden2[k] * wHidden2Output[k, l];
        for (int l = 0; l < outputSize; l++)
            output[l] = Sigmoid(output[l]);

        int predictedIndex = 0;
        double maxOutput = output[0];
        for (int i = 1; i < outputSize; i++)
            if (output[i] > maxOutput)
            {
                maxOutput = output[i];
                predictedIndex = i;
            }

        return predictedIndex;
    }
}
