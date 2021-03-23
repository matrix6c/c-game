using System;

namespace assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!!!, please enter your name: ") ;
            string userIdentity = Console.ReadLine() ;


            start:
            Console.WriteLine("{0} You can begin the game now. Please guess a number ", userIdentity) ;
            int guess;


            Random rnd = new Random() ;
            int random = rnd.Next(0, 2) ;
            

            do
            {
                int []answer = new int[10] ;
                for(guess = 0; guess < answer.Length; guess++)
                {
                    answer[guess] = int.Parse(Console.ReadLine() ) ;


                    if(guess == random)
                    {
                        Console.WriteLine("If you would like to continue please press 1 and otherwise to leave the game:") ;
                        int condition = int.Parse(Console.ReadLine() ) ;

                        switch(condition)
                        {
                            case 1:
                                goto start ;
                            default:
                                goto Res;
                        }
                    }
                    else if(guess != random)
                    {
                        Console.WriteLine("If you would like to continue please press 1 and otherwise to leave the game:") ;
                        int condition = int.Parse(Console.ReadLine() ) ;

                        switch(condition)
                        {
                            case 1:
                                goto start ;
                            default:
                                goto Res;
                        }
                    }

                    Res:
                    Console.WriteLine("you played a total of {0}", answer.Length  ) ;

                }
            }while(guess <= 6) ;
        }
    }
}
