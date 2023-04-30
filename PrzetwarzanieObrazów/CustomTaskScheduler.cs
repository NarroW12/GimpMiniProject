namespace PrzetwarzanieObrazów
{
    public class CustomTaskScheduler : TaskScheduler
    {
        private SynchronizationContext uiContext;

        public CustomTaskScheduler(SynchronizationContext uiContext)
        {
            this.uiContext = uiContext;
        }

        protected override IEnumerable<Task>? GetScheduledTasks()
        {
            throw new NotImplementedException();
        }

        protected override void QueueTask(Task task)
        {
            throw new NotImplementedException();
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            throw new NotImplementedException();
        }
    }
}