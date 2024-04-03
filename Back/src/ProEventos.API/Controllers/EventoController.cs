using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
            Eventoid = 1,
            Tema = "angular e Novidades",
            Local = "bh",
            Lote = "1º lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto.png"
            },
              new Evento() {
            Eventoid = 2,
            Tema = "angular e .Net6",
            Local = "SP",
            Lote = "2º lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.png"
            }
            };
            
    
        public EventoController()
        {
          
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
        return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
        return _evento.Where(evento => evento.Eventoid == id);
        }
        
        

        [HttpPost]
         public string Post()
         {
         return "Exemplo de Post";
         }
         }
}
