using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16
{
    internal class FecharTodososforms
    {
        internal static void Fecharformularios()

        {
            foreach (Form formaberto in Application.OpenForms)


            {
                formaberto.Close();
            }
        }

    }
}
