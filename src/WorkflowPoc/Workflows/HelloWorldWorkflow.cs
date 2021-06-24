using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using WorkflowCore.Interface;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace WorkflowPoc.Workflows
{
    public class HelloWorldWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder<object> builder)
        {
            builder
                .StartWith<HelloWorld>()
                .Then<GoodbyeWorld>();
        }

        public string Id => "HelloWorld";

        public int Version => 1;

    }

    public class HelloWorld : StepBody
    {
        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Hello world");
            return ExecutionResult.Next();
        }
    }

    public class GoodbyeWorld : StepBody
    {

        private ILogger _logger;

        public GoodbyeWorld(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<GoodbyeWorld>();
        }

        public override ExecutionResult Run(IStepExecutionContext context)
        {
            Console.WriteLine("Goodbye world");
            _logger.LogInformation("Hi there!");
            return ExecutionResult.Next();
        }
    }
}
