using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngineExercise
{
    /* This Program is meant to implement a WorflowEngine
     * That is, an engine that accepts a Workflow Object 
     * and performs each activity in the Workflow Object.
     * To Summarize, a Workflow Object is capable of holding
     * many activities. The WorkflowEngine has the functionality
     * to sequentially execute these activities. 
     * Although the activities are just Console Logs, it expresses
     * that, if needed, this program may sequentially execute a 
     * number of activities.
     * */
    public class Program
    {
        static void Main(string[] args)
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();
            Workflow workflow = new Workflow();

            //to Start, add two activities
            workflow.AddActivity(new UploadVideo());
            workflow.AddActivity(new SendEmail());

            //Run the workflowengine to output the first two activities that were added
            workflowEngine.Run(workflow);

            System.Console.WriteLine();

            //Add the remaining activities
            workflow.AddActivity(new CallWebService());
            workflow.AddActivity(new ChangeVideoStatus());

            //The work engine should re-run the first two activites as well as the activities that were added
            workflowEngine.Run(workflow);

        }
    }
}
