using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaFinanceiro.Infra.Entities;
using SistemaFuncionario.Infra.Repository;
using SistemaFuncionario.Presentation.Models;
using System.Diagnostics;
using System.Linq;

namespace SistemaFuncionario.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper? _mapper;

        public HomeController(IMapper? mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Cadastrar(FuncionarioViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var funcionarioRepository = new FuncionarioRepository();

                    if (funcionarioRepository.Obter(f => f.Cpf.Equals(model.Cpf)) != null)
                        ModelState.AddModelError("Cpf", "O cpf informado já consta no sistema.");

                    else
                    {
                        var funcionario = _mapper.Map<Funcionario>(model);
                        funcionarioRepository.Adicionar(funcionario);

                        ModelState.Clear();
                        TempData["MensagemSucesso"] = $"Parabéns funcionário(a) {funcionario.Nome}, foi criado(a) com sucesso!";

                    }
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = $"Falha ao cadastrar funcionário(a): {e.Message}";

                }

            }
            return View();
        }
        public IActionResult Edicao(Guid id)
        {
            var model = new FuncionarioEdicaoViewModel();
            try
            {
                var fucionarioRepository = new FuncionarioRepository();
                var funcionario = fucionarioRepository.ObterPorId(id);  
                if(funcionario != null)
                {
                    model.Nome = funcionario.Nome;
                    model.Cpf = funcionario.Cpf;
                    model.Matricula = funcionario.Matricula;
                    model.Salario = funcionario.Salario;
                    model.DataCadastro = funcionario.DataCadastro;
                    model.Id = funcionario.Id;
                }
                else
                {
                    return RedirectToAction("Consultar");
                }
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Falha ao editar funcionário: {e.Message}";
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Edicao(FuncionarioEdicaoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var funcionario = new Funcionario
                    {
                        Id = model.Id,
                        Nome = model.Nome,
                        Salario = model.Salario,
                        Matricula = model.Matricula,
                        Cpf = model.Cpf,
                        DataCadastro = model.DataCadastro,
                    };

                    var funcionarioRepository = new FuncionarioRepository();
                    funcionarioRepository.Atualizar(funcionario);

                    TempData["MensagemSucesso"] = $"Funcionário atualizado com sucesso. {model.Nome}";
                }
                catch (Exception e)
                {
                    TempData["MensagemErro"] = $"Falha ao atualizar Funcionário: {e.Message}";
                }
            }

            return View(model);
        }
        public IActionResult Exclusao(Guid id)
        {
            try
            {
                var funcionarioRepository = new FuncionarioRepository();
                var funcionario = funcionarioRepository.Obter(c => c.Id == id);
                if(funcionario != null)
                {
                    funcionarioRepository.Excluir(funcionario);
                    TempData["MesagemSucesso"] = $"Conta '{funcionario.Nome}' excluída com sucesso.";
                }

            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = $"Falha ao excluir conta: {e.Message}";
            }
            return RedirectToAction("Consultar");
        }
        public IActionResult Consultar(FuncionarioViewModel model, FuncionarioRepository funcionarioRepository)
        {
            try
            {
                var lista = funcionarioRepository.GetAll().ToList();
                ViewBag.Funcionarios = lista;
            }
            catch (Exception e)
            {
                TempData["MensagemErro"] = "Ocorreu um erro: " + e.Message;
            }

            return View(model);
        }
    }
}