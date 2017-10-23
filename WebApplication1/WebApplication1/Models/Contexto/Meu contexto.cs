using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Contexto
{
    public class Meu_contexto : DbContext
    {
        public Meu_contexto() : base("strConn")
        {

        }
    }
}