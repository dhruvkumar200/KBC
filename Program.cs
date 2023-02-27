public class Program
{
    public static void Main()
    {
        QuestionsData Ques = new QuestionsData();
        var Question = (from Q in Ques.GetQuestion()
                        select Q);

        Console.WriteLine("Hi Welcome to KBC");
        
            int Count = 0;
             var Question_count=(from num in Question select num).Count();
                int No_of_Question=Question_count;
            foreach (QuestionsModel Q in Question)
            {
                Console.WriteLine(Q.QuestionText + "\n" + Q.OptionA + "\n" + Q.OptionB + "\n" + Q.OptionC + "\n" + Q.OptionD);

                string ans = Console.ReadLine();
                
             



                if (Q.CorrectAnswer == ans)
                {   No_of_Question--;
                    Console.WriteLine("Correct Answer");
                    
                }
                else
                {
                    Console.WriteLine("InCorrect Answer");
                    Count ++;
                }

                if(Count==2)
                {
                    Console.WriteLine("You loose the game");
                    break;
                }
                
               
                

                if(No_of_Question==0)
                {
                    Console.WriteLine("Congratulations you have won the game");
                }
                

            }
            
                  
                
        
        
    }

    
}