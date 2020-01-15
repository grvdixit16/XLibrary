using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using XLibrary.Models.DbModels;

namespace XLibrary.Controllers
{
    public class ModulesController : ApiController
    {
        private XDbContext db = new XDbContext();

        // GET: api/Modules
        public IQueryable<Modules> GetModuless()
        {
            return db.Moduless;
        }

        // PUT: api/Modules/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModules(int id, Modules modules)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modules.Id)
            {
                return BadRequest();
            }

            db.Entry(modules).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModulesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Modules
        [ResponseType(typeof(Modules))]
        public IHttpActionResult PostModules(Modules modules)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Moduless.Add(modules);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = modules.Id }, modules);
        }

        // DELETE: api/Modules/5
        [ResponseType(typeof(Modules))]
        public IHttpActionResult DeleteModules(int id)
        {
            Modules modules = db.Moduless.Find(id);
            if (modules == null)
            {
                return NotFound();
            }

            db.Moduless.Remove(modules);
            db.SaveChanges();

            return Ok(modules);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModulesExists(int id)
        {
            return db.Moduless.Count(e => e.Id == id) > 0;
        }
    }
}