using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            DB db = new DB(@"", "", "", "");
            db.connect();

            db.close();


        catch (SqlEception ex)
            {
                console.WriteLine("pudimos conectarnos");
            }
        }
    }
        
}
