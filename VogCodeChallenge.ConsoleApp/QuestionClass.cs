using System;
using System.Collections.Generic;

namespace VogCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {
        public static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static T TestModule<T>(T input)
        {
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.Int32
                    when Convert.ToInt32(input) > 0 && Convert.ToInt32(input) < 5:
                    return (T)(object)(Convert.ToInt32(input) * 2);
                case TypeCode.Int32
                    when Convert.ToInt32(input) > 4:
                    return (T)(object)(Convert.ToInt32(input) * 3);
                case TypeCode.Int32
                    when Convert.ToInt32(input) < 0:
                    throw new ArgumentException("Value less then zero");
                case TypeCode.Single
                    when Convert.ToDouble(input) == 1.0f || Convert.ToDouble(input) == 2.0f:
                    return (T)(object)3.0f;
                case TypeCode.String:
                    return (T)(object)Convert.ToString(input)?.ToUpperInvariant();
                default:
                    return input;
            }
        }
    }
}
