using System;

namespace exercice
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static double Payement(Employe personne, string TypeWOrkerPromotion,int percentage)
        {
            if (personne.Types == "TimeAndHalf")
            {
                double money;

                if (personne.Hours > 40)
                {
                    money = (personne.Salary + ((personne.Hours - 40) * 20));
                }
                else money = personne.Salary;
                if (TypeWOrkerPromotion == "TimeAndHalf")
                {
                    return money * percentage;
                }
                else return money;
            }
            else if (personne.Types == "Persentage")
            {
                if (TypeWOrkerPromotion == "Persentage")
                {
                    return personne.Sales* personne.Percentage*percentage;
                }
               else return personne.Sales * personne.Percentage;
            }
            else if (personne.Types == "BaseAndPercentage")
            {
                if (TypeWOrkerPromotion== "BaseAndPercentage")
                {
                    return personne.Salary + personne.Sales * personne.Percentage*percentage;
                }
                else return personne.Salary + personne.Sales * personne.Percentage;
            }
            else
            {
                if (TypeWOrkerPromotion == "Fixe")
                {
                    return personne.Salary * percentage;
                }
                else return personne.Salary;
            }           
        }
        static double Reward(double NormalPaye)
        {
            return NormalPaye * 1.1;
        }
    }
    class Employe
{
    public string FirstName;
    public string LastName;
    public string SocialNumber;
    public string Types;
    public int Sales;
    public int Hours;
    public int Salary;
    public int Percentage;

        public Employe(string FirstName, string LastName,string Type, int Sale,int Hours, int Salary,int Percentage)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Types =Type;
            this.Sales = Sale;
            this.Hours = Hours;
            this.Salary = Salary;
            this.Percentage = Percentage;
        }
      

    }

}
