using StartToReadyLandingPage.Models;
using System.Collections.Generic;
using System.Linq;

namespace StartToReadyLandingPage.Repositories {
    public class LeadRepository : IDataAccess<Lead, string> {
        private readonly ApplicationContext _context;

        public LeadRepository(ApplicationContext context) {
            _context = context;
        }

        public int Add(Lead lead) {
            var resultado = 0;
            if (!VerifiqueSeExiste(lead.Email)) {
                _context.Leads.Add(lead);
                resultado = _context.SaveChanges();                ;
            }
            return resultado;
        }

        public int Delete(string id) {
            var resultado = 0;
            var lead = _context.Leads.FirstOrDefault(l => l.Email == id);
            if (lead != null) {
                _context.Leads.Remove(lead);
                resultado = _context.SaveChanges();
            }
            return resultado;
        }

        public Lead GetItem(string id) {
            var lead = _context.Leads.FirstOrDefault(l => l.Email == id);
            return lead;
        }

        public IEnumerable<Lead> GetItens() {
            var books = _context.Leads.ToList();
            return books;
        }

        public int Update(string id, Lead newLead) {
            var resultado = 0;
            var lead = _context.Leads.Find(id);
            if (lead != null) {
                lead.Nome = newLead.Nome;
                lead.Profissao = newLead.Profissao;
                lead.Cidade = newLead.Cidade;
                lead.Estado = newLead.Estado;
                lead.Empresa = newLead.Empresa;
                lead.EhAluno = newLead.EhAluno;
                resultado = _context.SaveChanges();
            }
            return resultado;
        }

        private bool VerifiqueSeExiste(string id) {
            var lead = GetItem(id);
            return lead != null;
        }
    }
}