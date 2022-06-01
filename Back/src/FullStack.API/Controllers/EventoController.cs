using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStack.API.Data;
using FullStack.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStack.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class EventoController : ControllerBase
    {


        private readonly DataContext _context;
        public EventoController(DataContext context)
        {

            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }


        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id);
        }


        [HttpPost]
        public string Post()
        {
            return "Valor Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Valor Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string delete(int id)
        {
            return $"Valor Delete com id = {id}";
        }


    }
}


