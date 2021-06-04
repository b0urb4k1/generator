using System;
using Microsoft.Build.Framework;

namespace build.tasks
{
    public class SimpleTask : ITask
    {
        //When implementing the ITask interface, it is necessary to
        //implement a BuildEngine property of type
        //Microsoft.Build.Framework.IBuildEngine. This is done for
        //you if you derive from the Task class.
        public SimpleTask() {}

        public IBuildEngine BuildEngine { get; set; }

        // When implementing the ITask interface, it is necessary to
        // implement a HostObject property of type object.
        // This is done for you if you derive from the Task class.
        ITaskHost ITask.HostObject { get; set; }

        public string Parameter { get; set; }

        public bool Execute()
        {
            Console.WriteLine($"Hello from Task {Parameter}.");

            return true;
        }
    }
}
