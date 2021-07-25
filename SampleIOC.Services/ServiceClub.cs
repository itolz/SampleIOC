using System;
using SampleIOC.Domain.Entities;
using SampleIOC.Domain.Entities.DTOs;
using SampleIOC.Domain.Interfaces;

namespace SampleIOC.Services
{
    public class ServiceClub : IServiceClub
    {
        public Club CalculatePercentage(ClubDTO dto)
        {
            var percentage = (Convert.ToDouble(dto.PointsEarned) / Convert.ToDouble(dto.GamesPlayed * 3)) * 100;

            return new Club
            {
                Name = dto.name,
                Percentage = percentage
            };
        }
    }
}