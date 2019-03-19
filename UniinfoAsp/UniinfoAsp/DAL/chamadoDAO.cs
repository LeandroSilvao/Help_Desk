using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniinfoAsp.Models;

namespace UniinfoAsp.DAL
{
    public class chamadoDAO
    {

        UnipEntities db = new UnipEntities();

        public List<Con_Chamado> Consultar()
        {
            var novo = db.Con_Chamado.ToList();
            return novo;
        }

        public List<vFuncionario> ConsultarFunc()
        {
            var novo = db.vFuncionarios.ToList();
            return novo;
        }

        public void EncerrarChamado(int id)
        {
            var chamadoAtendimento = db.chamadoAtendimentoes.Find(id);
            chamadoAtendimento.Chamado.statusAtendimento = "Encerrado";
            db.Entry(chamadoAtendimento).Property(ca => ca.dataAtendimento).CurrentValue = DateTime.Now;
            db.Entry(chamadoAtendimento.Chamado).Property(c => c.statusAtendimento).IsModified = true;
            db.SaveChanges();
        }

        public void PosicionarChamado(int id)
        {
            var chamado = db.Chamadoes.Find(id);
            chamado.statusAtendimento = "Em andamento";
            db.Chamadoes.Attach(chamado);
            db.Entry(chamado).Property(c => c.statusAtendimento).IsModified = true;
            db.SaveChanges();

            chamadoAtendimento ca = new chamadoAtendimento();
            ca.idChamado = chamado.idChamado;
            ca.idFuncionario = chamado.Funcionario.idFuncionario;
            db.chamadoAtendimentoes.Add(ca);
            db.SaveChanges();
        }


        public string verificaLogin(string loginwpf, string senhawpf)
        {
            Loginn log = new Loginn();
            log.login = loginwpf;
            log.senha = senhawpf;

            var result = db.Loginns.Where(l => l.login == log.login && l.senha == log.senha).ToList();
            if (result.Count() > 0)
            {
                if (result[0].idNivelAcesso == 1)
                {
                    return "true";
                }
                return "false";
            }
            return "false";
        }
    }
}