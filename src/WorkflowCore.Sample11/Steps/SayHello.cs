using System;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowCore.Sample11
{    
    public class SayHello : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Hello");
            return ExecutionResult.Next();
        }
    }
}
