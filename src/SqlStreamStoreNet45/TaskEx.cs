namespace SqlStreamStore
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public static class TaskEx
    {
        /// <summary>Creates a <see cref="T:System.Threading.Tasks.Task`1" /> that's completed due to cancellation with a specified cancellation token.</summary>
        /// <returns>The canceled task. </returns>
        /// <param name="cancellationToken">The cancellation token with which to complete the task. </param>
        /// <typeparam name="TResult">The type of the result returned by the task. </typeparam>
        public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken)
        {
            return (Task<TResult>)null;
        }

        /// <summary>Gets a task that has already completed successfully. </summary>
        /// <returns>The successfully completed task. </returns>
        public static Task CompletedTask
        {
            get
            {
                return (Task)null;
            }
        }
    }

    /// <summary>Specifies flags that control optional behavior for the creation and execution of tasks. </summary>
    [Flags]
    public enum TaskCreationOptionsEx
    {
        AttachedToParent = 4,
        DenyChildAttach = 8,
        HideScheduler = 16,
        LongRunning = 2,
        None = 0,
        PreferFairness = 1,
        RunContinuationsAsynchronously = 64,
    }

    public static class TaskCompletionSourceExtensions
    {
        /// <summary>Attempts to transition the underlying <see cref="T:System.Threading.Tasks.Task`1" /> into the <see cref="F:System.Threading.Tasks.TaskStatus.Canceled" /> state and enables a cancellation token to be stored in the canceled task. </summary>
        /// <returns>true if the operation is successful; otherwise, false. </returns>
        /// <param name="source">The task completion source</param>
        /// <param name="cancellationToken">A cancellation token. </param>
        public static bool TrySetCanceled<T>(this TaskCompletionSource<T> source, CancellationToken cancellationToken)
        {
            return false;
        }
    }
}
