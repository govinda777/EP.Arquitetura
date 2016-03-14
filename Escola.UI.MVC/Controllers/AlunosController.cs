using System.Web.Mvc;
using Aluno.Application;
using Aluno.Application.Interfaces;
using Aluno.Application.ViewModels;

namespace Escola.UI.MVC.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoAppService _alunoAppService;

        public AlunosController(IAlunoAppService alunoAppService)
        {
            _alunoAppService = alunoAppService;
        }

        // GET: Alunos
        public ActionResult Index()
        {
            return View(_alunoAppService.ObterTodos());
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        public ActionResult Create(AlunoViewModel alunoViewModel)
        {
            if (ModelState.IsValid)
            {
                alunoViewModel = _alunoAppService.Adicionar(alunoViewModel);

                if (!alunoViewModel.ValidationResult.IsValid)
                {
                    foreach (var error in alunoViewModel.ValidationResult.Erros)
                    {
                        ModelState.AddModelError(string.Empty, error.Message);
                    }

                    return View(alunoViewModel);
                }

                return RedirectToAction("Index");
            }

            return View(alunoViewModel);
        }
    }
}
