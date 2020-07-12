using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calendar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace calendar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarController : ControllerBase
    {
        private readonly ILogger<CalendarController> _logger;
		private readonly ICalendarService _calendarService;

		public CalendarController(ILogger<CalendarController> logger, ICalendarService calendarService)
        {
            _logger = logger;
            _calendarService = calendarService;
        }

        [HttpGet]
        public IEnumerable<CalendarItem> GetAllItems()
        {
            return _calendarService.GetAllItems();
        }

        [HttpGet]
        public CalendarItem GetItem(string id)
        {
            return _calendarService.GetItem(id);
        }

        // [HttpPut]
        // public CalendarItem CreateItem(CalendarItem item)
        // {
            
        // }
    }
}
