using System;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class LocalBusiness
    {
        public LocalModel GetLocalById(String _idLocal){
            var _local = new LocalServices().GetLocalById(_idLocal);

            return _local;
        }
    }
}
