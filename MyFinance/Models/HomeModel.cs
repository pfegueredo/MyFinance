using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using MyFinance.Util;


namespace MyFinance.Models
{
    public class HomeModel
    {
        public string LerNomesUsuario()
        {
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable("select * from usuario");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows.Count > 0)
                    {
                        return dt.Rows[0]["Nome"].ToString();
                    }
                }
            }
            return "Nenhum usuário encontrado";
        }
    }
}
