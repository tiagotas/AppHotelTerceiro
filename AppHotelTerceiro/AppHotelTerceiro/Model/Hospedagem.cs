using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotelTerceiro.Model
{
    public class Hospedagem
    {
        public Suite Quarto { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
    }
}
