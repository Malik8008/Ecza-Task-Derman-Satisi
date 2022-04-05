using System;
using System.Collections.Generic;
using System.Text;

namespace Eczaci_Praktika_Class
{
    internal class Pharmacy
    {
        public string Name { get; set; }
        public int ID { get; set; }

        Drug[] drug = new Drug[0];

        public override string ToString()
        {
            return $"ID:{ID}  ||  Name:{Name}";
        }

        public Drug[] AddDrug(Drug drugs)
        {
            Array.Resize(ref drug, drug.Length + 1);
            drug[drug.Length - 1] = drugs;
            return drug;
        }

        public  void DrugList(Drug drugs)
        {
            foreach (var item in drug)
            {
                Console.WriteLine($"Name:{item.Name}  ||Count:{item.Count}  ||Price:{item.Price}  ||ID:{item.ID}  ||Type:{item.Type}");
            }
        }

        public void SaleDrug(string Name,int Count,double Money)
        {
            foreach (var item in drug)
            {
                if (item.Name==Name && item.Count==Count && item.Count>0 && item.Price==Money)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.WriteLine("Pulun yoxdu Vizqirt");
                }
            }
        }
    }
}
