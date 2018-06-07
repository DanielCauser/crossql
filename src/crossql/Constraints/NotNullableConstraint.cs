﻿namespace crossql.Constraints
{
    public class NotNullableConstraint : IConstraint
    {
        private readonly IDialect _dialect;

        public NotNullableConstraint(IDialect dialect)
        {
            _dialect = dialect;
        }

        public override string ToString() => _dialect.NotNullableConstraint;
    }
}