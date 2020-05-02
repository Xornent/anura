using Anura.JavaScript.Runtime;
using System.Threading;

namespace Anura.JavaScript.Constraints
{
    public sealed class CancellationConstraint : IConstraint
    {
        private CancellationToken _cancellationToken;

        public CancellationConstraint(CancellationToken cancellationToken)
        {
            _cancellationToken = cancellationToken;
        }

        public void Check()
        {
            if (_cancellationToken.IsCancellationRequested)
            {
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowStatementsCountOverflowException();
            }
        }

        public void Reset(CancellationToken cancellationToken)
        {
            _cancellationToken = cancellationToken;
        }

        public void Reset()
        {
        }
    }
}
