using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    //This class is used to hold the activites
    //although it is not the base class, it still implement OCP (Open-Close Protocol)
    //because no change to this class is required to change the behavior of the program
    //only an extension of this class such as removing activities or switching the 
    //sequence that the activities are performed
    public class Workflow
    {
            //define a list of Interfaces
            public readonly IList<IActivity> _activities;

            public Workflow()
            {
                //initialize the list
                _activities = new List<IActivity>();
            }

            public void AddActivity(IActivity activity)
            {
                //define method to add to the list
                _activities.Add(activity);
            }
    }
}
