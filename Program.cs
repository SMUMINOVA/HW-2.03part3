using System;

namespace hw_1._03p3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
