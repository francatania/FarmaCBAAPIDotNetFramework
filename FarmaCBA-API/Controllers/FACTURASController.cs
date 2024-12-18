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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class FACTURASController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/FACTURAS
        public IHttpActionResult GetFACTURAS()
        {
            var facturas = db.FACTURAS
                .Select(x => new FacturaDTO
                {
                    ID_FACTURA = x.ID_FACTURA,
                    FECHA = x.FECHA,
                    CLIENTE = x.CLIENTES.APELLIDO + ", " + x.CLIENTES.NOMBRE,
                    TOTAL = x.DISPENSACIONES.Sum(d => d.PRECIO_UNITARIO * d.CANTIDAD)
                })
                .ToList();

            return Ok(facturas);
        }

        // GET: api/FACTURAS/5
        [ResponseType(typeof(FACTURAS))]
        public IHttpActionResult GetFACTURAS(int id)
        {
            FACTURAS fACTURAS = db.FACTURAS.Find(id);
            if (fACTURAS == null)
            {
                return NotFound();
            }

            return Ok(fACTURAS);
        }

        // PUT: api/FACTURAS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutFACTURAS(int id, FACTURAS fACTURAS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != fACTURAS.ID_FACTURA)
            {
                return BadRequest();
            }

            db.Entry(fACTURAS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FACTURASExists(id))
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

        // POST: api/FACTURAS
        [ResponseType(typeof(FACTURAS))]
        public IHttpActionResult PostFACTURAS(FACTURAS fACTURAS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.FACTURAS.Add(fACTURAS);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (FACTURASExists(fACTURAS.ID_FACTURA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = fACTURAS.ID_FACTURA }, fACTURAS);
        }

        // DELETE: api/FACTURAS/5
        [ResponseType(typeof(FACTURAS))]
        public IHttpActionResult DeleteFACTURAS(int id)
        {
            FACTURAS fACTURAS = db.FACTURAS.Find(id);
            if (fACTURAS == null)
            {
                return NotFound();
            }

            db.FACTURAS.Remove(fACTURAS);
            db.SaveChanges();

            return Ok(fACTURAS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool FACTURASExists(int id)
        {
            return db.FACTURAS.Count(e => e.ID_FACTURA == id) > 0;
        }
    }
}