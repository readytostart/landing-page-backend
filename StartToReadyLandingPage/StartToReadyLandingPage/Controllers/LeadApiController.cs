using Microsoft.AspNetCore.Mvc;
using StartToReadyLandingPage.Models;
using StartToReadyLandingPage.Models.Enums;
using StartToReadyLandingPage.Repositories;
using System.Collections.Generic;

namespace StartToReadyLandingPage.Controllers {
    [Route("api/[controller]")]
    public class LeadApiController : Controller {
        private readonly IDataAccess<Lead, string> _repositorio;

        public LeadApiController(IDataAccess<Lead, string> repositorio) {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Lead> Get() {
            return _repositorio.GetItens();
        }

        [HttpGet("{email}", Name = "GetLeadApi")]
        public IActionResult Get(string email) {
            var item = _repositorio.GetItem(email);
            if (item == null) {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Post(string nome, string email, string profissao, string cidade, string estado,
            int empresa, bool ehAluno) {
            var lead = new Lead {
                Nome = nome,
                Email = email,
                Profissao = profissao,
                Cidade = cidade,
                Estado = estado,
                Empresa = (Organizations) empresa,
                EhAluno = ehAluno
            };
            var resultado = _repositorio.Add(lead);
            return RetorneResultadoDaOperacao(lead, resultado, "Não foi possível realizar o cadastro");
        }

        [HttpPut]
        public IActionResult Put(string nome, string email, string profissao, string cidade, string estado, int empresa,
            bool ehAluno) {
            var lead = new Lead {
                Nome = nome,
                Email = email,
                Profissao = profissao,
                Cidade = cidade,
                Estado = estado,
                Empresa = (Organizations) empresa,
                EhAluno = ehAluno
            };

            var resultado = _repositorio.Update(email, lead);
            return RetorneResultadoDaOperacao(lead, resultado, "Não foi possível realizar a atualização cadastro");
        }

        [HttpDelete("{email}")]
        public IActionResult Delete(string email) {
            var resultado = _repositorio.Delete(email);
            if (resultado == 1) {
                return new JsonResult(new {
                    status = true,
                    mensagem = "Registro excluido com sucesso"
                });
            }
            return new JsonResult(new {
                status = false,
                mensagem = "Não foi possível excluir o registro"
            });
        }

        private IActionResult RetorneResultadoDaOperacao(Lead lead, int resultado, string mensagem) {
            if (resultado == 1) {
                return new ObjectResult(lead);
            }
            return new JsonResult(new {
                status = false,
                mensagem = mensagem
            });
        }
    }
}