using Core.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class BaseService<TEntity> where TEntity : class 
    {
        public readonly IAdminInterfaces _adminInterfaces;
        public BaseService(IAdminInterfaces adminInterfaces)
        {
                _adminInterfaces = adminInterfaces;
        }
    }
}
