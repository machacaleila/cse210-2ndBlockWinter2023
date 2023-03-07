namespace RadomSentence
{
public class PromptGenerator {
  
  public static string[] questions = {"Write the best memory today:", "Who was the most interesting person I interacted with today?",
      "If I had one thing I could do over today, what would it be?", "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?", "Describe how you felt in a song", "Are you happy? why?",
      "Have you breath deeply today? how it felt?", "Write a funny moment:", "What have you eaten?"
       };
       public static string WholeSentence()
        {
         var randomQ = new Random();
         string random = questions[randomQ.Next(questions.Length)];
    //Console.WriteLine(randomQ(questions));
          return $"{random}";
        }

}
}