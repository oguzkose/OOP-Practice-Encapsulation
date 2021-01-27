using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Encapsulation
{
    public class Ayakkabi
    {

        public string marka;
        public string renk;
        /// <summary>
        /// Encapsulation (Kapsülleme) Class'a ait bir property'nin getter ve setter metotlarına 
        /// müdahale ederek , kullanıcının verileri ne kadar görüntüleyebileceğini ve değişiklik yapabileceğini sınırlandırma işlemidir.
        /// </summary>
        private int _numara;
        public int numara 
        {
            get 
            { 
                return _numara;
            }
            set
            {
                if (value>=35 && value <=45)
                {
                    _numara = value;
                }
                else
                {
                    MessageBox.Show("35 ile 45 arasında bir numara giriniz!");
                }
            } 
        }
        public decimal fiyat;
        public decimal KDVdahil //read-only property
        {
            get
            {
               return fiyat + (fiyat* 0.18m);
            } 
        }

    }
}
