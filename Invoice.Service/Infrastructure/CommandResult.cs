﻿namespace Invoice.Service.Infrastructure
{
    public class CommandResult
    {
        protected CommandResult() { }


        protected CommandResult(string failureReason) => FailureReason = failureReason;


        public string FailureReason { get; }
        public bool IsSuccess => string.IsNullOrEmpty(FailureReason);


        public static CommandResult Success { get; } = new CommandResult();

        public static CommandResult Fail(string reason)
            => new(reason);


        public static implicit operator bool(CommandResult result)
            => result.IsSuccess;
    }

    public class CommandResult<T> : CommandResult
    {
        private CommandResult(string reason) : base(reason)
        { }

        private CommandResult(T payload)
            => Payload = payload;

        public T Payload { get; }

        public new static CommandResult<T> Fail(string reason)
            => new(reason);

        public new static CommandResult<T> Success(T payload)
            => new(payload);

        public static implicit operator bool(CommandResult<T> result)
            => result.IsSuccess;
    }
}