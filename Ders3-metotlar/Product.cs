using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3_metotlar
{
    class Product // Bir veri ürün olabilmesi için bulundurması gereken özellikler.
    {
        public int Id { get; set; } // (property) prop+tab+tab  = özellik.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

        // ebcapsulation = kapsülleme yani parca parça olacak şeyibelli kalıp ile kullanıyorsun. 

    }
}
