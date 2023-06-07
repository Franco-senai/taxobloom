using Microsoft.AspNetCore.Mvc;
using WebAppnbloom.Models;
namespace WebAppnbloom.Controllers;


public class CompetenciaController:Controller{



public IActionResult Index(){

    Competencia competencia = new Competencia();
    competencia.ColunaBloom = "Memorizar";
    competencia.LinhBloom = "listar";

    ViewData["Titulo"] = "Compreender o funcionamento do Razor";
    ViewData["tablebloom"] = competencia;
    return View();

}


}