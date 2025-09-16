using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Corp";
        job1._startYear = "2020";
        job1._endYear = "2023";
      
        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Innovate LLC";
        job2._startYear = "2023";
        job2._endYear = "Present";
  

        Resume myResume = new Resume();
        myResume._name = "John Doe";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();

    }
}