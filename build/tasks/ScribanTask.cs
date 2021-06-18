using System;
using System.IO;
using Microsoft.Build.Framework;

// using Scriban;

namespace build.tasks
{
    public class ScribanTask : ITask
    {
        public IBuildEngine BuildEngine { get; set; }

        ITaskHost ITask.HostObject { get; set; }

        [Required]
        public ITaskItem[] InputItems { get; set; }

        [Required]
        public ITaskItem ScribanTemplate { get; set; }

        [Required]
        public ITaskItem OutputFile { get; set; }

        public bool Execute()
        {
            BuildEngine.LogMessageEvent(new BuildMessageEventArgs("help", "helpkeyword", nameof(ScribanTask), MessageImportance.High));

            // try
            // {
            //     var template = Template.Parse(File.ReadAllText(ScribanTemplate.ToString()));
            //     var result = template.Render(InputItems);

            //     File.WriteAllText(OutputFile.ToString(), result);
            // }
            // catch(Exception e)
            // {
            //     BuildEngine.LogErrorEvent(new BuildErrorEventArgs("", "", "", 0, 0, 0, 0, e.Message, "", ""));

            //     return false;
            // }

            return true;
        }
    }
}