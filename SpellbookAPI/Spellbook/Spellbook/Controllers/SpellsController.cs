﻿using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Spellbook.Models;
using Spellbook.Services;

namespace Spellbook.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class SpellsController : ApiController
    {
        private readonly SpellbookService _service = new SpellbookService();

        public IHttpActionResult Get(int id)
        {
            return Ok(_service.GetSpellBy(id));
        }

        public IHttpActionResult Get([FromUri] SpellQuery query)
        {
            try
            {
                query.isNull();
                if (!query.isValid())
                    return BadRequest("Query is not valid. :(");
                return Ok(_service.GetSpellBy(query));
            }
            catch (Exception EX_NAME)
            {
                Console.WriteLine(EX_NAME);
                throw;
            }
        }
    }
}
