using DDD.Domain.ValueObjects;
using System;

namespace DDD.Domain.Entities
{
    public sealed class WeatherEntity
    {
        public WeatherEntity(int areaId,
                             DateTime dataDate,
                             int condition,
                             float temperature)
        {
            AreaId = areaId;
            DataDate = dataDate;
            Condition = new Condition(condition);
            Temperature = new Temperature(temperature);
        }

        public int AreaId { get; }
        public DateTime DataDate { get; }
        public Condition Condition { get; }
        public Temperature Temperature { get; }

        public bool IsMousho()
        {
            if (Condition == Condition.Sunny)
            {
                if (Temperature.Value > 30)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsOK()
        {
            if (DataDate < DateTime.Now.AddMonths(-1))
            {
                if (Temperature.Value < 10)
                {
                    return false;
                }
            }
            return true;
        }
    }

    public enum Mode
    {
        Auto,
        None,
    }
}