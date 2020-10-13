using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Questions
{
    class Program
    {
        static void Main(string[] args)
        {

            int j, i;
            j = i = 0;
            String category;
            ActualQuestions tree = new ActualQuestions();
            ActualQuestions treeI = new ActualQuestions();
            String stoAnswer;

            do
            {

                Console.WriteLine("Pick a category: Animals or Instruments");
                category = Console.ReadLine();

                if (category.Equals("animals", StringComparison.OrdinalIgnoreCase))
                {
                    tree.fill();
                    Console.WriteLine("Possible animals: Tiger, Rabbit, Monkey, Giraffe, Eagle, Dragon, Pterodactyl, "
                            + "Hummingbird\n");


                    Console.WriteLine("Answer the questions with either 'yes' or 'no'.\n");

                    for (int k = 0; k < 3; k++)
                    {

                        Console.WriteLine(tree.getQuestion(i, j));
                        stoAnswer = Console.ReadLine().ToLower();
                        tree.setAnswer(i, j, stoAnswer);

                        if (tree.getAnswer(i, j).Equals("yes"))
                        {
                            j++;
                        }
                        else if (i == 0 && j == 0 && tree.getAnswer(i, j).Equals("no"))
                        {
                            i = i + 2;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    category = "";

                }
                else if (category.Equals("instruments", StringComparison.OrdinalIgnoreCase))
                {
                    treeI.fillI();

                    Console.WriteLine("Possible instruments: Guitar, Violin, Harp, Cello, Piano, Banjo, Musical Bow, "
                            + "Bass Guitar, Drums, Xylophone, Trumpet, Trombone\n");

                    Console.WriteLine("Answer the questions with either 'yes' or 'no'.\n");

                    for (int k = 0; k < 4; k++)
                    {

                        Console.WriteLine(treeI.getQuestionI(i, j));
                        stoAnswer = Console.ReadLine().ToLower();
                        treeI.setAnswerI(i, j, stoAnswer);

                        if (treeI.getAnswerI(i, j).Equals("yes"))
                        {
                            j++;
                        }
                        else if (i == 0 && j == 0 && treeI.getAnswerI(i, j).Equals("no"))
                        {
                            i = i + 4;
                        }
                        else if (i == 0 && j == 2 && treeI.getAnswerI(i, j).Equals("no"))
                        {
                            i = i + 3;
                            j = 0;
                        }
                        else
                        {
                            i++;
                            j = 0;
                        }
                    }
                    category = "";

                }
                else Console.WriteLine("Enter Animals or Instruments");

                //ANIMAL GUESSES

                if (i == 0 && j == 3)
                {
                    if (tree.getAnswer(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of an eagle."); //0,3
                    }
                }
                else if (i == 1 && j == 2)
                {
                    if (tree.getAnswer(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a hummingbird."); //1,2
                    }
                    else if (tree.getAnswer(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a dragon."); //1,2
                    }
                }
                else if (i == 2 && j == 1)
                {
                    if (tree.getAnswer(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a pterodactyl."); //2,1
                    }
                }
                else if (i == 2 && j == 2)
                {
                    if (tree.getAnswer(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a tiger."); //2,2
                    }
                }
                else if (i == 3 && j == 1)
                {
                    if (tree.getAnswer(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a giraffe."); //3,1
                    }
                    else if (tree.getAnswer(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a rabbit.");
                    }
                }
                else if (i == 4 && j == 0)
                {
                    if (tree.getAnswer(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a monkey.");
                    }
                }


                //INSTRUMENT GUESSES

                if (i == 0 && j == 4)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a guitar."); //0,4
                    }
                }
                else if (i == 1 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j + 3).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a cello."); //1,3
                    }
                }
                else if (i == 3 && j == 1)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a violin."); //3,1
                    }
                }
                else if (i == 4 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a banjo."); //4,0
                    }
                }
                else if (i == 1 && j == 2)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a bass guitar."); //1,2
                    }
                }
                else if (i == 2 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j + 1).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a musical bow."); //2,1
                    }
                }
                else if (i == 2 && j == 1)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a piano."); //2,1
                    }
                }
                else if (i == 3 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a harp."); //3,0
                    }
                }
                else if (i == 4 && j == 3)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a trombone."); //4,3
                    }
                }
                else if (i == 5 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of a trumpet."); //5,0
                    }
                }
                else if (i == 5 && j == 1)
                {
                    if (treeI.getAnswerI(i, j - 1).Equals("yes"))
                    {
                        Console.WriteLine("You're thinking of drums."); //5,1
                    }
                }
                else if (i == 6 && j == 0)
                {
                    if (treeI.getAnswerI(i - 1, j).Equals("no"))
                    {
                        Console.WriteLine("You're thinking of a xylophone."); //6,0
                    }
                }


            } while (category.Equals("animals", StringComparison.OrdinalIgnoreCase) || category.Equals("instruments", 
            StringComparison.OrdinalIgnoreCase));

            Console.ReadLine();
        }
    }
}
