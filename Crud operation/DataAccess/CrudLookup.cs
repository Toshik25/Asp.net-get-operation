using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Crud_operation.Contexts.Crud;
using Crud_operation.Models;

namespace Crud_operation.DataAccess
{
    public class CrudLookup
    {
        public List<CrudModel> GetCrud()
        {
            try
            {
                using (var db = new CrudContext())
                {

                    var CrudList = (from sl in db.simpleCruds
                                    select new CrudModel
                                       {
                                           Name = sl.Name,
                                           Email = sl.Email,
                                           
                                       }).ToList();

                    return (CrudList);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}