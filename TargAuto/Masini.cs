using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargAuto
{
    class Masini
    {
        public string marca;
        public string model;
        public int an;
        public string motor;
        public string tractiune;
        public string pret;

        public Masini()
        {
            marca = model = motor = tractiune = pret = string.Empty;
        }
        public static int NextID { get; set; } = 0;
        public int Cod { get; set; }
        public Masini(string marca, string model, int an, string motor, string tractiune,string pret)
        {
            Cod = ++NextID;
            this.marca = marca;
            this.model = model;
            this.an = an;
            this.motor = motor;
            this.tractiune = tractiune;
            this.pret = pret;

        }
        public string GetMarca()
        {
             return marca;      
        }
        public void SetMarca()
        {
            this.marca = marca;
        }
        public string GetModel()
        {
            return model;           
        }
        public void SetModel()
        {
            this.model = model;
        }
        public int GetAn()
        {
            return an;            
        }
        public void SetAn()
        {
            this.an = an;
        }
        public string GetMotor()
        {
             return motor;         
        }
        public void SetMotor()
        {
            this.motor = motor;
        }
        public string GetTractiune()
        {
             return tractiune;
        }
        public void SetTractiune()
        {
            this.tractiune = tractiune;
        }
        public string GetPret()
        {
            return pret;
        }
        public void SetPret()
        {
            this.pret = pret;
        }
    }


}
