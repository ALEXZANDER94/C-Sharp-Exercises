namespace WorkflowEngineExercise
{
    //define an interface that only has the execute method
    //this interface is the contract that binds each activity
    //each activity MUST implement the Execute() method
    public interface IActivity
    {
        void Execute();
    }
}
