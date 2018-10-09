using System;
using System.Collections.ObjectModel;

namespace HGTAplicativo.Models
{
    public class PedidoAgrupadoModel : ObservableCollection<PedidoModel>
    {
        public String LongName { get; set; }
    }
}
