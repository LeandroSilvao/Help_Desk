
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
    using System.Collections.Generic;
    
public partial class chamadoAtendimento
{

    public int idAtendimento { get; set; }

    public int idFuncionario { get; set; }

    public int idChamado { get; set; }

    public System.DateTime dataAtendimento { get; set; }



    public virtual Chamado Chamado { get; set; }

    public virtual Funcionario Funcionario { get; set; }

}

}
