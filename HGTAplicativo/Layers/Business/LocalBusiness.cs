using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class LocalBusiness
    {
        public LocalModel GetLocalById(String _idLocal)
        {
            var _local = new LocalServices().GetLocalById(_idLocal);

            return _local;
        }
    }
}
