using System;

namespace hw_1._03p3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true){
                System.Console.WriteLine("Enter the name of country");
                CoronavirusIn someCountry = new CoronavirusIn();
                someCountry.country = Console.ReadLine();
                System.Console.WriteLine("Enter number of population: ");
                someCountry.population = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter number of cases: ");
                someCountry.numberOfCases = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter number of death: ");
                someCountry.numberOfDeath = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter number of recoverded people: ");
                someCountry.numberOfRecovered = int.Parse(Console.ReadLine());
                System.Console.WriteLine("As I understand...");
                someCountry.Show();
                System.Console.WriteLine("I can say you that...");
                someCountry.Position();
            }
        }
        class CoronavirusIn{
            public string country {get; set;}
            public int numberOfCases {get; set;}
            public int numberOfRecovered {get; set;}
            public int numberOfDeath {get; set;}
            public int population {get; set;}
            public CoronavirusIn(int population, int numberOfCases,int numberOfDeath, int numberOfRecovered){
                this.numberOfCases = numberOfCases;
                this.numberOfRecovered = numberOfRecovered;
                this.numberOfDeath = numberOfDeath;
                this.population = population;
            }
            public CoronavirusIn(){

            }
            public void Show(){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"Number of cases in {country}: {numberOfCases}");
                Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine($"Number of cases in {country}: {numberOfDeath}");
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"Number of cases in {country}: {numberOfRecovered}");
            }
            public void Position(){
                if ((numberOfCases + numberOfDeath) > 0.7*population){
                    if (numberOfRecovered > 0.5*numberOfCases)
                    System.Console.WriteLine($"Position of {country} is not so bad");
                    else System.Console.WriteLine($"Position of {country} is very bad");
                }
                else if ((numberOfCases + numberOfDeath) > 0.3*population)
                System.Console.WriteLine($"Position of {country} for now is fixable");
                else System.Console.WriteLine($"Position of {country} is very good");
                if (numberOfCases < numberOfRecovered)
                System.Console.WriteLine("Population is recovering!!!");
            }
        }
    }
}
