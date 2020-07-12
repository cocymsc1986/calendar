using System.Collections.Generic;

namespace calendar.Repository
{
	public interface ICalendarRepository {
		IEnumerable<CalendarItem> GetAllItems();
		CalendarItem GetItem(string id);
	}
}