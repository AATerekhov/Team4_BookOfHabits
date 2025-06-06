﻿using BookOfHabitsMicroservice.Application.Models.Base;
using BookOfHabitsMicroservice.Application.Models.Card;
using BookOfHabitsMicroservice.Application.Models.Person;
using BookOfHabitsMicroservice.Application.Models.Room;
using BookOfHabitsMicroservice.Domain.Entity.Enums;

namespace BookOfHabitsMicroservice.Application.Models.Habit
{
    public class HabitModel : IModel<Guid>
    {
        public Guid Id { get; init; }
        public required string Name { get; init; }
        public required string Description { get; init; }
        public Guid CardId { get; init; }
        public CardModel? Card { get; init; }
        public Guid OwnerId { get; init; }
        public PersonModel? Owner { get; init; }
        public Guid RoomId { get; init; }
        public RoomModel? Room { get; init; }
        public bool IsUsed { get; init; }
        public HabitOptions Options { get; init; }
        public required DelayModel Delay { get; init; }
        public required TimeResetIntervalModel TimeResetInterval { get; init; }
        public required RepetitionModel Repetition { get; init; }
    }
}
