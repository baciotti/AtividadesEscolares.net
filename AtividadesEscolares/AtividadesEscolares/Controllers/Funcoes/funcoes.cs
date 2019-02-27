using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;

using System.Net;

using System.Web.Mvc;
using AtividadesEscolares.Models;
using System.Data.Entity.Core.Objects;


namespace AtividadesEscolares.Controllers.Funcoes
{
	public class funcoes //: Controller
	{
        
        public static String TotalVencidas()
        {
        TarefaDBContext db = new TarefaDBContext();
        DateTime hoje = DateTime.Now.Date;
            
            //return View(db.Tarefas.SqlQuery(vQuery).ToList());
            
            return db.Tarefas.Where(a => EntityFunctions.TruncateTime(a.data) < hoje).Count().ToString();
        }


    }
}