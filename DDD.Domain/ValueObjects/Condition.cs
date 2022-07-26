using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.ValueObjects
{
    public sealed class Condition : ValueObject<Condition>
    {
        public static readonly Condition Nome = new Condition(0);
        public static readonly Condition Sunny = new Condition(1);
        public static readonly Condition Cloudy = new Condition(2);
        public static readonly Condition Rain = new Condition(3);
        public Condition(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public string DisplayValue
        {
            get
            {
                if (this == Sunny) return "晴れ";
                if (this == Cloudy) return "曇り";
                if (this == Rain) return "雨";
                return "不明";
            }
        }
        protected override bool EqualsCore(Condition other)
        {
            return this.Value == other.Value;
        }

        public static IList<Condition> ToList()
        {
            return new List<Condition>
            {
                Nome,
                Sunny,
                Cloudy,
                Rain,
            };
        }
    }
}
