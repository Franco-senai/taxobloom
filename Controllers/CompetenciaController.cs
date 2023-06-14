using Microsoft.AspNetCore.Mvc;
using WebAppbloom.Models;
using WebAppbloom.Controllers;
using WebAppbloom.ViewModels;
using WebAppbloom.Contexts;

namespace WebAppbloom.Controllers;


public class CompetenciaController:Controller{


private readonly AppDbContext _context;

   public CompetenciaController(AppDbContext context){
        _context = context;
   } 
   public IActionResult Index(){
        Competencia competencia = new Competencia();
        competencia.ColunaBloom = "Memorizar";
        competencia.LinhBloom = "Listar";
        ViewData["titulo"] = "Compreender o funcionamento do Razor";
        ViewData["tablebloom"] = competencia;
        return View();
   }

   public IActionResult RelatorioComp(){

      var competencias = _context.Competencias.ToList();
      return View();

    } 
    public IActionResult Listar(){

        var ListaCompe = _context.Competencias.ToList();

        //Entra o objeto listaCompe (dados do banco)
        // para a viewModel (<IConllection>)
        
        var listaViewModel = new ListaCompetenciaViewModels{
            
            Competencias = ListaCompe

        };
        return View(listaViewModel);




    }
}
