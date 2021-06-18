using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;

using Scriban;

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
            BuildEngine.LogMessageEvent(new BuildMessageEventArgs($"{ScribanTemplate.ToString()}", "helpkeyword", nameof(ScribanTask), MessageImportance.High));

            try
            {
                var template = Template.Parse(File.ReadAllText(ScribanTemplate.ToString()));
                var result = template.Render(new { Items = InputItems } );

                File.WriteAllText(OutputFile.ToString(), result);
            }
            catch(Exception e)
            {
                BuildEngine.LogErrorEvent(new BuildErrorEventArgs("", "", "SctribanTask.cs", 0, 0, 0, 0, e.Message, "", e.Source));

                return false;
            }

            return true;
        }
    }
}