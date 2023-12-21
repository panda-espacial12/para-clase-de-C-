using System;
namespace sobre_escritura_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale = new Sale(10);
            sale.Add(2);
            sale.Add(3);
            Console.WriteLine(sale.GetTotal());

            Saleswithtax saleswithtax = new Saleswithtax(10, 1.16m);
            saleswithtax.Add(2);
            saleswithtax.Add(3);
            Console.WriteLine(saleswithtax.GetTotal());
        }

        public class Sale
        {
            private decimal[] _amounts;
            private int _n;
            private int _end;

            public Sale(int n)
            {
                _amounts = new decimal[n];
                _n = n;
                _end = 0;
            }

            public void Add(decimal amount)
            {
                if (_end < _n)
                {
                    _amounts[_end] = amount;
                    _end++;
                }
            }
            public virtual decimal GetTotal()
            {
                decimal result = 0;
                int i = 0;
                while (i < _amounts.Length)
                {
                    result += _amounts[i];
                    i++;
                }

                return result;
            }

        }


        public class Saleswithtax : Sale
        {

            private decimal _tax;
            public Saleswithtax(int n, decimal tax) : base(n)
            {
                _tax = tax;
            }


            public override decimal GetTotal()
            {
                return base.GetTotal() * _tax;
            }
        }
    }
}
