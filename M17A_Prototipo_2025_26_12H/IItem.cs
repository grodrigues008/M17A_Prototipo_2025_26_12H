using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M17A_Prototipo_2025_26_12H
{
    /// <summary>
    /// Interface para classes Leitor, Livro e Empréstimo
    /// </summary>

    internal interface IItem
    {
        // Adicionar
        void Adicionar(); // TODO: classe base de dados
        // Atualizar
        void Atualizar();
        // Apagar
        void Apagar();
        // Validar
        List<string> Validar();


    }
}
