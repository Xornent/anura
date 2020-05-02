using Anura.JavaScript.Runtime;

namespace Anura.JavaScript.Constraints
{
    internal sealed class MaxStatements : IConstraint
    {
        private readonly int _maxStatements;
        private int _statementsCount;

        public MaxStatements(int maxStatements)
        {
            _maxStatements = maxStatements;
        }

        public void Check()
        {
            if (_maxStatements > 0 && _statementsCount++ > _maxStatements)
            { 
                Anura.JavaScript.Runtime.ExceptionHelper.ThrowStatementsCountOverflowException();
            }
        }

        public void Reset()
        {
            _statementsCount = 0;
        }
    }
}
