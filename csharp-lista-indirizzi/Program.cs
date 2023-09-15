namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader fileListAddress = File.OpenText("C:\\Users\\alien\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

                int LineNumber = 0; //cONTATORE PER INIZIALIZZARE LA VARIABILE

                while (!fileListAddress.EndOfStream)
                {
                    string line = fileListAddress.ReadLine();

                    LineNumber++;
                    if (LineNumber > 1)
                    {
                        string[] arrayDivider = line.Split(",");
                        if (arrayDivider.Length > 6 )
                        {
                            Console.WriteLine("Errore alcuni campi dati sono errati  ");

                        } else
                        {
                            string name = arrayDivider[0];
                            string surname = arrayDivider[1];
                            string street = arrayDivider[2];
                            string city = arrayDivider[3];
                            string province = arrayDivider[4];
                            int zip = int.Parse(arrayDivider[5]);

                            Console.WriteLine($"This is your address {name} , {surname} , {street} , {city} , {province} , {zip} ");

                            Address newAddress = new Address (name , surname , street, city, province, zip);
                            Address.Add(newAddress);
                        }

                    }
                   
                }
                fileListAddress.Close();
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            //SOVRASCRIVERE IL FILE
        }
    }
}