using SimpleBooking.Domain.Dtos;
using System.Threading.Tasks;

namespace SimpleBooking.Services
{
	public interface IPropertyService
	{
		Task<PropertyDto> GetProperty(int id);

		Task<PropertyDto> CreateTestPropertyUsingMultipleDBs();

		Task<PropertyDto> CreateTestPropertyUsingSingleDB();
	}
}
