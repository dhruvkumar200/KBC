public  class QuestionsData
{
    public  List<QuestionsModel>GetQuestion()
    {
        List<QuestionsModel>Ques=new List<QuestionsModel>();
        // Add your questions to this list
        Ques.Add(new QuestionsModel
        {
            QuestionId = 1,
            QuestionText = "What is the capital of France?",
            OptionA = "London",
            OptionB = "Paris",
            OptionC = "Berlin",
            OptionD = "Madrid",
            CorrectAnswer = "Paris"
        });
        Ques.Add(new QuestionsModel
        {
            QuestionId = 2,
            QuestionText ="What is the largest planet in our solar system?",
            OptionA = "Mars",
            OptionB = "Jupiter",
            OptionC = "Earth",
            OptionD = "Saturn",
            CorrectAnswer = "Jupiter"
        });
         Ques.Add(new QuestionsModel
        {
            QuestionId = 3,
            QuestionText = "What is the boiling point of water?",
            OptionA = "100 degrees Celsius",
            OptionB = "0 degrees Celsius",
            OptionC = "50 degrees Celsius",
            OptionD = "200 degrees Celsius",
            CorrectAnswer = "100"
        });

           Ques.Add(new QuestionsModel
        {
              QuestionId = 4,
            QuestionText = "What is the capital of India?",
            OptionA = "Mumbai",
            OptionB = "Kolkata",
            OptionC = "New Delhi",
            OptionD = "Chennai",
            CorrectAnswer = "New Delhi"
        });
        

        return Ques;
    }
}