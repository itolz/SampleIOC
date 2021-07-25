using SampleIOC.Domain.Entities;
using SampleIOC.Domain.Entities.DTOs;

namespace SampleIOC.Domain.Interfaces
{
    public interface IServiceClub
    {
        Club CalculatePercentage(ClubDTO dto);
    }
}