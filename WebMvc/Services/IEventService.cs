﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMvc.Models;

namespace WebMvc.Services
{
    public class IEventService
    {
        Task<Event> GetEventItemsAsync(int page, int size, int? category, int? type);
        Task<IEnumerable<SelectListItem>> GetEventCategoryAsync();
        Task<IEnumerable<SelectListItem>> GetEventTypesAsync();
    }
}
