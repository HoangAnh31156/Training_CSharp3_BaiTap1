using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingCSharp3_BaiTap1.Controllers.Repositories;
using TrainingCSharp3_BaiTap1.Models.DomainClass;

namespace TrainingCSharp3_BaiTap1.Controllers.Services
{
    internal class XeMayService
    {
        XeMayRepository _repos;
        public XeMayService()
        {
            _repos = new XeMayRepository();
        }
        public List<XeMay> GetXeMays(string? input)
        {
            return _repos.GetXeMays(input);
        }
        public List<LoaiXm> GetLoaiXms()
        {
            return _repos.GetLoaiXms();
        }
        public void AddXeMay(XeMay xeMay)
        {
            if (_repos.AddXeMay(xeMay))
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteXeMay(Guid? id)
        {
            if (_repos.DeleteXeMay(id))
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Success !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
