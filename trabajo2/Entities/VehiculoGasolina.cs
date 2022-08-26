using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo2.Entities
{
    internal class VehiculoGasolina : Entity
    {
        public VehiculoGasolina(string id, string placa):base(id, placa){}

        public void ImprimirValores()
        {
            if(string.IsNullOrEmpty(placa))
                throw new Exception("")
            else
            Console.WriteLine($"{this.Id} {this.placa}");
        }
    }
}
