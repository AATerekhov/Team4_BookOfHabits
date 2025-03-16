﻿namespace BookOfHabits.Responses.Card
{
    public class TemplateValuesResponse
    {
        public Guid Id { get; init; }
        public required string TitleStatus { get; init; }
        public required string TitleValue { get; init; }
        public required string TitleCheck { get; init; }
        public required string TitleReportField { get; init; }
        public required string TitleTags { get; init; }
        public required string TitlePositive { get; init; }
        public required string TitleNegative { get; init; }
        public required string TitleFileReceiver { get; init; }
    }
}
