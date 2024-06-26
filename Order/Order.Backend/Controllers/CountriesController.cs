﻿using Microsoft.AspNetCore.Mvc;
using Order.Backend.UnitsOfWork.Interfaces;
using Order.Shared.Entities;

namespace Order.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : GenericController<Country>
    {
        public CountriesController(IGenericUnitOfWork<Country> unit) : base(unit)
        {
        }
    }
}