﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace UniinfoAsp.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class UnipEntities : DbContext
{
    public UnipEntities()
        : base("name=UnipEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Chamado> Chamadoes { get; set; }

    public virtual DbSet<chamadoAtendimento> chamadoAtendimentoes { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<Loginn> Loginns { get; set; }

    public virtual DbSet<nivelAcesso> nivelAcessoes { get; set; }

    public virtual DbSet<Problema> Problemas { get; set; }

    public virtual DbSet<Con_ChamadoAtendimento> Con_ChamadoAtendimento { get; set; }

    public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

    public virtual DbSet<Con_Chamado> Con_Chamado { get; set; }

    public virtual DbSet<vFuncionario> vFuncionarios { get; set; }

}

}
