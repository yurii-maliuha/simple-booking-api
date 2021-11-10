using Microsoft.EntityFrameworkCore;
using SimpleBooking.Domain.Dtos;
using SimpleBooking.Domain.Models;
using SimpleBooking.Persistent;
using SimpleBooking.PersistentLogs;
using System;
using System.Threading.Tasks;
using System.Transactions;

namespace SimpleBooking.Services
{
	public class PropertyService : IPropertyService
	{
		private readonly BookingContext _context;
		private readonly LogsContext _logsContext;
		public PropertyService(
			BookingContext context,
			LogsContext logsContext)
		{
			_context = context;
			_logsContext = logsContext;
		}

		public Task<PropertyDto> CreateTestPropertyUsingSingleDB()
		{
			using (var transaction = new CommittableTransaction(
				new TransactionOptions { IsolationLevel = IsolationLevel.Serializable }))
			//using (var transaction = _context.Database.BeginTransaction())
			{
				var location = new Location()
				{
					Name = "Test Location"
				};

				var property = new Property()
				{
					Description = "Test desc",
					Name = "Test name",
					FeedbackId = null,
					Location = location
				};

				_context.Database.OpenConnection();
				_context.Database.EnlistTransaction(transaction);

				_context.Properties.Add(property);
				_context.SaveChanges();

				var propertyLog = new Domain.Models.Log()
				{
					Description = $"{nameof(Property)} was created with id {property.Id} and location id {location.Id}",
					Created = DateTime.Now
				};

				throw new ArgumentException();

				_context.Logs.Add(propertyLog);
				_context.SaveChanges();

				transaction.Commit();
			}

			return Task.FromResult(new PropertyDto());
		}

		public Task<PropertyDto> CreateTestPropertyUsingMultipleDBs()
		{
			using (var transaction = new CommittableTransaction(
				new TransactionOptions { IsolationLevel = IsolationLevel.ReadCommitted }))
			{
				var location = new Location()
				{
					Name = "Test Location"
				};

				var property = new Property()
				{
					Description = "Test desc",
					Name = "Test name",
					FeedbackId = null,
					Location = location
				};

				_context.Database.OpenConnection();
				_context.Database.EnlistTransaction(transaction);

				_context.Properties.Add(property);
				_context.SaveChanges();

				var propertyLog = new PersistentLogs.Log()
				{
					Description = $"{nameof(Property)} was created with id {property.Id} and location id {location.Id}",
					Created = DateTime.Now
				};

				//throw new ArgumentException();

				_logsContext.Database.OpenConnection();
				_logsContext.Database.EnlistTransaction(transaction);

				_logsContext.Logs.Add(propertyLog);
				_logsContext.SaveChanges();

				transaction.Commit();
				
			}

			return Task.FromResult(new PropertyDto());
		}



		public Task<PropertyDto> GetProperty(int id)
		{
			var property1 = _context.Properties.Find(id);
			var property2 = _context.Properties.Find(id);

			return Task.FromResult(new PropertyDto());
		}
	}
}
