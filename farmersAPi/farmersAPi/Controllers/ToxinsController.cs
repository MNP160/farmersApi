﻿using farmersAPi.DTOs;
using farmersAPi.Models;
using farmersAPi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace farmersAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ToxinsController :BasicController<Toxins, ToxinsRepository, ToxinsDto>
    {
        public ToxinsController(ToxinsRepository repository): base(repository)
        {

        }

    }
}
