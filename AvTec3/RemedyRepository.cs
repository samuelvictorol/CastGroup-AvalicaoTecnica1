using System;

namespace AvTec3
{
    public class RemedyRepository
    {
        public int Variety { get; set; }
        List<Remedy> medicines;
        public RemedyRepository()
        {
            medicines = new List<Remedy>();
            medicines.Add(new Remedy("Neosoro", 2));
            Variety++;
            medicines.Add(new Remedy("Roacutan", 0));
            Variety++;
            medicines.Add(new Remedy("Dorflex", 4));
            Variety++;
            medicines.Add(new Remedy("Rivotril", 9));
            Variety++;
            medicines.Add(new Remedy("Dipirona", 12));
            Variety++;
            medicines.Add(new Remedy("Doril", 14));
            Variety++;
            medicines.Add(new Remedy("Isotretinoina", 11));
            Variety++;
            medicines.Add(new Remedy("Vergonha na Cara", 99));
            Variety++;
            medicines.Add(new Remedy("Omeprazol", 1));
            Variety++;
            medicines.Add(new Remedy("Vitamina C", 2));
            Variety++;
            medicines.Add(new Remedy("Neosaldina", 7));
            Variety++;
        }

        public string ShowVariety(int opt)
        {
            if(opt == 1)
            {
                foreach (Remedy re in medicines) Console.WriteLine(re.Name);
            }
            return Variety.ToString();
        }
        public void FindMedicine(string finalString)
        {
            int i = 0;
            bool found = false;
            foreach(Remedy remedy in medicines)
            {
                string amountResult = remedy.Amount == 0 ? "Sem Estoque" : remedy.Amount + "";
                if (remedy.Name.Contains(finalString))
                {
                    Console.WriteLine("-------------------------------------");
                    Console.WriteLine($"Remédio Encontrado!\n" +
                                      $"Nome..........: {remedy.Name}\n" +
                                      $"Qtd Disponivel: {amountResult}\n" +
                                      $"Posição.......: {i}");
                    Console.WriteLine("-------------------------------------");
                    found = true;
                }
                i++;
            }
            if (!found)
            {
                Console.WriteLine("Remédio Não Encontrado");
            }
        }

    }

}