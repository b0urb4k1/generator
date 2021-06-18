using Microsoft.Build.Framework;

namespace build.tasks
{
    public class ScribanTask2 : ITask
    {
        public IBuildEngine BuildEngine { get; set; }

        ITaskHost ITask.HostObject { get; set; }

        [Required]
        public ITaskItem[] Inputs { get; set; }

        public bool Execute()
        {
            BuildEngine.LogMessageEvent(new BuildMessageEventArgs("help", "helpkeyword", nameof(ScribanTask), MessageImportance.High));

            return true;
        }
    }
}