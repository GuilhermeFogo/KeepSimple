using Guilherme.Modal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Guilherme.Repository.interfaces
{
    public interface IRepositoryVoo
    {
        void Salvar(Voo voo);
        void Deletar(Voo voo);

        Voo ListarUmVoo(int voo);
        bool existID(int id);
        void EditarVoo(Voo voo);
        DataTable ListarTudo();
    }
}
