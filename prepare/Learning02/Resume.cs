
public class Resume{
    public string _name;
    //create a new list class jobs
    public List<Job> _jobs = new List<Job>(); //ask the group about this.

    public void Display(){
         Console.WriteLine($"Name: {_name}");
         Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
          foreach (Job job in _jobs)
         {
            // This calls the Display method on each job
            job.Display();
         }

    }



}