﻿namespace crossql.tests.Helpers.CustomTypes
{
    public class LatLong
    {
        public decimal Value { get; set; }

        public new string ToString()
        {
            return Value.ToString();
        }
    }
}