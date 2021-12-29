using Sipsis.DAl.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sipsis.BLL.Repository.Base
{
    //Tüm tablolarda kullanılabilecek yapıyı tutacak
    public class BaseRepository<T> where T : class  //BaseRepositroy çalışırken içine aldığı T tipi mutlaka class mı? kontrolü
    {

        private SiparisDBEntities db; //İsmini db olarak kısalttı
        protected DbSet<T> table; //Buraya gelen hangi tipte tablo olursa ismi Table olacak

        public BaseRepository() // İlk çalıştığı anda ne işlem yapması gerektiği
        {
            db = new SiparisDBEntities();
            table = db.Set<T>(); //Database'den gelen tabloyu ayarlar
        }
    
     public int Save()
        {
            return db.SaveChanges();
        }

    public virtual void Insert(T entity) //Insert işleminde içeriye parametre gönderilmesi gerekir
                                         //Dışarıdan BaseRepository' e gelen veri tipi,tablo tipi neyse onu al ve adını belirlenen ad yap
        {
            table.Add(entity);
            Save();
        }
    
     public List<T> GetAll()
        {
            return table.ToList();
        }

        public T Find(long ID)
        {
            return table.Find(ID);
        }
    
    }
}
