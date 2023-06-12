using Microsoft.AspNetCore.Mvc;
using WebAppnbloom.Models;
using WebAppnbloom.Controllers;
using WebAppnbloom.ViewModels;

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

public IActionResult RelatorioComp(){

    var Competencia = new Competencia(){
    ColunaBloom = "Pagina Teste",
    LinhBloom = "pagina Teste"

    };

    var viewModel = new DetalhesCompViewModel(){

        Competencia = Competencia,
        TituloPagina = "Pagina de Teste"


    };

    return View(viewModel);



}
}