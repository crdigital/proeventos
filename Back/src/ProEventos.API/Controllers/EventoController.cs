using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        // public IEnumerable<Evento> _evento = new Evento[] 
        // {
        //     new Evento(){
        //         EventoId = 1,
        //         Tema = "Angular 11 e .net 5.",
        //         Local = "Barra do Garças MT",
        //         Lote = "1º Lote",
        //         QuantidadePessoas = 250,
        //         DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
        //         ImagemURL = "foto.png"
        //     },
        //     new Evento(){
        //         EventoId = 2,
        //         Tema = "Angular 12 e .net 6.",
        //         Local = "Barra do Garças MT",
        //         Lote = "2º Lote",
        //         QuantidadePessoas = 550,
        //         DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
        //         ImagemURL = "foto.png"
        //     }
        // };
        private readonly DataContext _context;
        
       public EventoController(DataContext context)
       {
            _context = context;
        
       }            
        
        [HttpGet]
         public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
            // return _evento;
        }  

        [HttpGet("{id}")]
         public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string delete(int id)
        {
            return $"Exemplo de delete com id = {id}";
        }
    }
}
