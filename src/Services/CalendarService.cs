using System.Collections.Generic;
using calendar.Repository;

namespace calendar.Services
{
	public class CalendarService : ICalendarService {
		private readonly CalendarRepository _repository;

		public CalendarService(CalendarRepository calenderRepository) {
			_repository = calenderRepository;
		}

		public IEnumerable<CalendarItem> GetAllItems()
		{
			return _repository.GetAllItems();
		}

		public CalendarItem GetItem(string id)
		{
			return _repository.GetItem(id);
		}
	}
}