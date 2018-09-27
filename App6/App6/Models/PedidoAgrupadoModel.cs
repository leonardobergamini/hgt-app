using System;
using System.Collections.ObjectModel;

namespace App6.Models
{
    public class PedidoAgrupadoModel : ObservableCollection<PedidoModel>
    {
        public String LongName { get; set;}


        public PedidoAgrupadoModel()
        {
        }
    }
}
