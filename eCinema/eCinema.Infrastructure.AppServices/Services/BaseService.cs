using eCinema.Infrastructure.DataMSSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Infrastructure.AppServices.Services
{
    public class BaseService
    {
        protected UnityOfWork _uWork;
        public BaseService(eCinemaDbContext context) 
        {
            _uWork = new UnityOfWork(context);
        }
    }
}
