namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Emmaleigh";
            int hadDogFor = 6;
            char dogNickName = 'M';
            bool goodGirl = true;
            double ageDogYears = 46.5;
            decimal dogAge = 6.5m;

            Console.WriteLine($"My dogs name is {dogName}. I call her {dogNickName} and I have had her for {hadDogFor} years.");
            Console.WriteLine($"She is {dogAge} years old. That's {ageDogYears} in dog years.");
            Console.WriteLine($"She is {goodGirl.ToString().ToLower()})ly the best dog ever!";
        }
    }
}
