using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleBooking.Domain.Dtos;
using SimpleBooking.Domain.Models;
using System.Threading.Tasks;
using Property = SimpleBooking.Domain.Models.Property;

namespace SimpleBooking.Services
{
	public interface IPropertyService
	{
		Task<Property> GetProperty(int id);

	}
}
