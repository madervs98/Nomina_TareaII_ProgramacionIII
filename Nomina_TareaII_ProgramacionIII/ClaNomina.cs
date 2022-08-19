using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nomina_TareaII_ProgramacionIII
{
    public class ClaNomina : Form1
    {

        double excedente;
        double isr;

        protected double sueldoB
        {
            get { return sueldoB; }
            set { sueldoB = value; }
        }

        protected double afp
        {
            get { return afp; }
            set { afp = value; }
        }
        protected double ars
        {
            get { return ars; }
            set { ars = value; }
        }
        protected double irs
        {
            get { return irs; }
            set { irs = value; }
        }
        protected double TotalDescuento
        {
            get { return TotalDescuento; }
            set { TotalDescuento = value; }
        }
        protected double SueldoNeto
        {
            get { return SueldoNeto; }
            set { SueldoNeto = value; }
        }


        public double CalcularAFP(double sueldoB)
        {
            afp = (sueldoB * 2.87) / 100;
            return afp;
        }



        public double CalcularARS(double sueldoB)
        {
            ars = (sueldoB * 3.04) / 100;
            return ars;
        }

        public double CalculoISR(double sueldoB,string ISR)
        {
            if (sueldoB >= 416220)
            {
                isr = (sueldoB * 15) / 100;
                ISR = isr.ToString();

            }
            if (sueldoB >= 624329)
            {
                isr = (sueldoB * 20) / 100;
                excedente = (isr - 31216);
                return excedente;

            }
            if (sueldoB > 867123)
            {
                isr = (sueldoB * 25) / 100;
                excedente = (isr - 79776);
                return (excedente);

            }
            else
            {
                isr = 0;
                excedente = 0;
                return excedente;
            }
        }

        public double SueldoN(double sueldoB)
        {
            SueldoNeto = sueldoB - TotalDescuento;
            return SueldoNeto;
        }




    }
}
