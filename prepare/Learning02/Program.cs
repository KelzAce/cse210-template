using System;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Chef";
        job2._company = "Sheraton";
        job2._startYear = 2002;
        job2._endYear = 2007;

        Job job3 = new Job();
        job3._jobTitle = "Doctor";
        job3._company = "City Hospital";
        job3._startYear = 2020;
        job3._endYear = 2004;

        Resume myResume = new Resume();
        Resume myResume2 = new Resume();
        Resume myResume3 = new Resume();

        myResume._name = "Brandon Smith";
        myResume2._name = "Kelly Ibadin";
        myResume3._name = "Ice Smart";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume2._jobs.Add(job1);
        myResume2._jobs.Add(job2);

        myResume3._jobs.Add(job3);

        myResume.Dispay();
        myResume2.Dispay();
        myResume3.Dispay();
    }
}