﻿using BookOfHabitsMicroservice.Application.Models.Base;
using BookOfHabitsMicroservice.Domain.Entity.Enums;

namespace BookOfHabitsMicroservice.Application.Models.Habit
{
    public class UpdateTimeResetIntervalModel:ICreateModel
    {
        public Guid Id { get; init; }
        public ResetIntervalOptions Options { get; init; }
        public int TimeTheDay { get; init; }
        public WeekDays WeekDays { get; init; }
        public int NumberDayOfTheMonth { get; init; }
    }
}
