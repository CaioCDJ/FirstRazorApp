using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;

public class Index : PageModel
{

  public List<Clubes> clubes { get; set; } =  new ();// inicialização anonima

  // Executado quando a pasta for renderizada
  public async Task OnGet(){
  
    // deixa o navegador em estado de loading
    await Task.Delay(5000);

    clubes.Add(new Clubes("Peixão Soccer Club", "Santos"));
    clubes.Add(new Clubes("Black Bridge", "Campinas"));
    clubes.Add(new Clubes("Fortress", "Fortaleza"));
  }
  
  // post kek
  public void OnPost(){}
  
}

public record Clubes(string nome,string cidade );
