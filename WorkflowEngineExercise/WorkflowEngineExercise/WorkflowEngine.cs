using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    //Complete OCP (Open-Close Protocol) for this base class
    //any changes to the behavior of the program does not require
    //a change to the base class
    public class WorkflowEngine
    {
        //this method ensures that each activity in the workflow will be ran
        public void Run(Workflow work)
        {
            foreach(var activity in work._activities)
            {
                activity.Execute();
            }
        }

    }
}
