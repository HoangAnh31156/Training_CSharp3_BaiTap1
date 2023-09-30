using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCSharp3_BaiTap1;
using TrainingCSharp3_BaiTap1.Models.Context;
using TrainingCSharp3_BaiTap1.Models.DomainClass;

namespace TrainingCSharp3_BaiTap1.Controllers.Repositories
{
    internal class XeMayRepository
    {
        DBContext _Db;
        public XeMayRepository()
        {
            _Db = new DBContext();
        }
        public List<XeMay> GetXeMays(string? input)
        {
            if (input == null)
                return _Db.XeMays.ToList();
            //return _Db.XeMays.Where(x=>x.Ten.Trim().ToLower().Contains(input.ToLower())).ToList();
            var xQuery = from xm in _Db.XeMays
                         where xm.Ten.Trim().ToLower().Contains(input.ToLower())
                         select xm;
            return xQuery.ToList();
        }
        public List<LoaiXm> GetLoaiXms()
        {
            return _Db.LoaiXms.ToList();    
        }
        public bool AddXeMay(XeMay xeMay)
        {
            if (xeMay == null)
                return false;
            xeMay.Id = Guid.NewGuid();
            _Db.XeMays.Add(xeMay);
            _Db.SaveChanges();
            return true;
        }
        public bool DeleteXeMay(Guid? id)
        {
            var result = _Db.XeMays.FirstOrDefault(x => x.Id == id);
            if (result == null)
                return false;
            _Db.Remove(result);
            _Db.SaveChanges();
            return true;
        }
    }
}
