﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Spellbook.DataContext;
using Spellbook.Models;

namespace Spellbook.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly spellbookDbContext _context = new spellbookDbContext();


        // GET api/values
        public IEnumerable<Spell> Get()
        {
            return _context.Spells;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
