using Anura.JavaScript.Runtime;
using System;

namespace Anura.JavaScript.Constraints
{
    internal sealed class TimeConstraint : IConstraint
    {
        private readonly long _maxTicks;
        private long _timeoutTicks;

        public TimeConstraint(TimeSpan timeout)
        {
            _maxTicks = timeout.Ticks;
        }

        public void Check()
        {
            if (_timeoutTicks > 0 && _timeoutTicks < DateTime.UtcNow.Ticks)
            {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowTimeoutException();
            }
        }

        public void Reset()
        {
            var timeoutIntervalTicks = _maxTicks;

            _timeoutTicks = timeoutIntervalTicks > 0 ? DateTime.UtcNow.Ticks + timeoutIntervalTicks : 0;
        }
    }
}
