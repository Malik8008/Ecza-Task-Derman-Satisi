using System;

namespace Eczaci_Praktika_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Drug drug = new Drug();
            drug.Name = "Malik";
            drug.Count = 10;
            drug.Price = 12.5;
            

            Drug drug2 = new Drug();
            drug2.Name = "Kazim";
            drug2.Count = 12;
            drug2.Price = 13;


            Pharmacy pharmacy = new Pharmacy();

            pharmacy.AddDrug(drug);
            pharmacy.AddDrug(drug2);
            pharmacy.DrugList(drug);
            pharmacy.DrugList(drug2);


            //Console.WriteLine(pharmacy.SaleDrug(drug));


        }
    }
}
