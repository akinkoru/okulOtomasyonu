using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.ORM
{
    public interface IORM<T>
    {
        DataTable Listele();
        bool Ekle(T entity);
        bool Sil(int id);
        bool Guncelle(T entity);

    }
}
