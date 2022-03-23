class program
{
    static void Main(string[] args)
    {
        int minimumRandomNumber = 1;
        int maximumRandomNumber = 28;
        int maximumMultipleNumber = 1000;
        int minimumMultipleNumber = 100;
        int qantityMultipleNumbers = 0;
        Random random = new Random();
        int randomNumber = random.Next(minimumRandomNumber, maximumRandomNumber);

        for (int i = randomNumber; i < maximumMultipleNumber; i += randomNumber)
        {
            if (i > minimumMultipleNumber)
            {
                qantityMultipleNumbers++;
            }
        }
        
        Console.WriteLine(qantityMultipleNumbers);
    }
}