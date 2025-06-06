﻿using BookOfHabitsMicroservice.Domain.Entity.Enums;

namespace BookOfHabits.Requests.Card
{
    public class UpdateCardRequest : BaseCommonRequest
    {
        public Guid Id { get; init; }
        public CardOptions Options { get; init; }
        public byte[]? Image { get; init; }
        public required string[] Status { get; init; }
        public required string[] TitleCheckElements { get; init; }
        public required string[] Tags { get; init; }
    }
}
