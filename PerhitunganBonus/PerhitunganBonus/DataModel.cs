using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PerhitunganBonus
{
    public class DataModel :BaseNotify
    {

        private double pty;

        public double PTY
        {
            get { return pty; }
            set { SetProperty(ref pty , value);
                if(value>0)
                   PTYResult = CalculateHelper.CalcularePTY(value);
            }
        }


        private double ptyResult;

        public double PTYResult
        {
            get { return ptyResult; }
            set { SetProperty(ref ptyResult , value);
                if (value > 0)
                    CalculateTotal(); }
        }

      
        private double pa;

        public double PA
        {
            get { return pa; }
            set { SetProperty(ref pa , value);
                if (value > 0)
                    PAResult = CalculateHelper.CalculatePA(value);
            }
        }



        private double paResult;

        public double PAResult
        {
            get { return paResult; }
            set { SetProperty(ref paResult , value);
                if (value > 0)
                    CalculateTotal();
            }
        }

        private double ap;

        public double AP
        {
            get { return ap; }
            set { SetProperty(ref ap , value);
                if (value > 0)
                    APResult = CalculateHelper.CalculateAP(value);
            }
        }


        private double apResult;

        public double APResult
        {
            get { return apResult; }
            set { SetProperty(ref apResult , value);
                if (value > 0) 
                    CalculateTotal();
            }

        }


        private FIType fitype;

        public FIType FIType
        {
            get { return fitype; }
            set { SetProperty(ref fitype , value);
                if (value > 0) 
                    FIResult = CalculateHelper.CalculateFI(value);
            
            }
        }


        private double fiResult;

        public double FIResult
        {
            get { return fiResult; }
            set { SetProperty(ref fiResult , value);
                if (value > 0) 
                    CalculateTotal();
            }
        }



        private int kehadiran;

        public int Kehadiran
        {
            get { return kehadiran; }
            set { SetProperty(ref kehadiran , value);
                if (value > 0) 
                    CalculateTotal();
            }
        }

        private double nilaiKehadiran = 10000;

        public double NilaiKehadiran
        {
            get { return nilaiKehadiran; }
            set { SetProperty(ref nilaiKehadiran , value); }
        }


        private double total;

        public double Total
        {
            get { return total; }
            set { SetProperty(ref total , value); }
        }


        private Task CalculateTotal()
        {
            var tkehadiran = NilaiKehadiran * Kehadiran;
            double total=0;
            if(PTYResult>0)
                total = PTYResult;

            if (PAResult > 0)
               total= total* PAResult;

            if (APResult > 0)
                total = total * APResult;

            if (FIResult> 0)
                total = total * FIResult;

            var total1 = (25000*Kehadiran*total);

            Total = total1 + tkehadiran;

            return Task.CompletedTask;
        }
    }




    public enum FIType
    {
        LTI, TIFRMoreThen2 , TIFRLestThen2,  NoISIDENT
    }
}
