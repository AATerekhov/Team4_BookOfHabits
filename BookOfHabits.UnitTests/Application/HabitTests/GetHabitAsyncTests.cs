﻿using AutoFixture.Xunit2;
using BookOfHabits.UnitTests.Hepls;
using BookOfHabitsMicroservice.Application.Models.Habit;
using BookOfHabitsMicroservice.Application.Services.Abstractions.Exceptions;
using BookOfHabitsMicroservice.Application.Services.Implementations;
using BookOfHabitsMicroservice.Application.Services.Implementations.FactoryMethodDomain;
using BookOfHabitsMicroservice.Domain.Entity;
using BookOfHabitsMicroservice.Domain.Repository.Abstractions;
using BookOfHabitsMicroservice.Domain.ValueObjects;
using FluentAssertions;
using Moq;
using Xunit;

namespace BookOfHabits.UnitTests.Application.HabitTests
{

    public class GetHabitAsyncTests
    {
        [Theory, AutoMoqDataHabit]
        public async Task GetHabit_GettingHabit_NotBeNull(
            Habit entity,
            [Frozen] Mock<IRepository<Habit, Guid>> habitRepositoryMock,
            HabitsApplicationService habitsApplicationService,
            CancellationToken token) 
        {
            //Arrange
            var entityId = entity.Id;            
            habitRepositoryMock.Setup(repo => repo.GetByIdAsync(x => x.Id.Equals(entityId),
                $"{nameof(Habit.Card)},{nameof(Habit.Owner)},{nameof(Habit.Delay)},{nameof(Habit.Repetition)},{nameof(Habit.TimeResetInterval)}", 
                true,
                token)).ReturnsAsync(entity);
            //Act
            var result = await habitsApplicationService.GetHabitByIdAsync(entityId, token);
            //Assert
            result.Should().NotBeNull();
            result?.Id.Should().Be(entity.Id);
        }

        [Theory, AutoMoqDataHabit]
        public async Task GetHabit_GettingHabit_NotFound(
            Guid id,
            [Frozen] Mock<IRepository<Habit, Guid>> habitRepositoryMock,
            HabitsApplicationService habitsApplicationService,
            CancellationToken token) 
        {
            //Arrenge
            Habit? entity = null;
            habitRepositoryMock.Setup(repo => repo.GetByIdAsync(x => x.Id.Equals(id),
               $"{nameof(Habit.Card)},{nameof(Habit.Owner)},{nameof(Habit.Delay)},{nameof(Habit.Repetition)},{nameof(Habit.TimeResetInterval)}",
            true,
               token)).ReturnsAsync(entity);
            //Act

            //Assert
            await Assert.ThrowsAsync<NotFoundException>(async () => await habitsApplicationService.GetHabitByIdAsync(id, token));
        }

        [Theory, AutoMoqDataHabit]
        public async Task GetHabit_AddingHabit_ResultIsNotNull(
           CreateHabitModel habitModel,
           Habit entity,
           [Frozen] Mock<IRepository<Habit, Guid>> habitRepositoryMock,
           [Frozen] Mock<IFactory<Habit>> factoryMock,
           HabitsApplicationService habitsApplicationService,
           CancellationToken token)
        {
            //Arrenge
            string[] args = [habitModel.Name, habitModel.Description];
            factoryMock.Setup(f => f.FactoryMethod(args)).Returns(entity);
            habitRepositoryMock.Setup(repo => repo.AddAsync(entity, token)).ReturnsAsync(entity); ;
            //Act
            var result = await habitsApplicationService.AddHabitAsync(habitModel, token);

            //Assert
            result.Should().NotBeNull();
        }
    }
}