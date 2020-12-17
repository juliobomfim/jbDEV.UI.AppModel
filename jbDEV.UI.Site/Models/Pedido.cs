using System;

namespace jbDEV.UI.Site.Models
{
    public class Pedido
    {
        public Pedido()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
