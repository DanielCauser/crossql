﻿namespace crossql.Constraints
{
    public class OnUpdateNoActionConstraint : IConstraint
    {
        private static IDialect _dialect;

        public OnUpdateNoActionConstraint(IDialect dialect)
        {
            _dialect = dialect;
        }

        public override string ToString() => _dialect.OnUpdateNoActionConstraint;
    }
}