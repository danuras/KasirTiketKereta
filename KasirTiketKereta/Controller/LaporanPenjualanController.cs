using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using KasirTiketKereta.Model.Repository;
using System.Collections.Generic;

namespace KasirTiketKereta.Controller
{
    class LaporanPenjualanController
    {

        private LaporanPenjualanRepository _repository;
        public List<LaporanPenjualan> ReadAll()
        {
            List<LaporanPenjualan> list = new List<LaporanPenjualan>();
            using (DbContext context = new DbContext())
            {
                _repository = new LaporanPenjualanRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<LaporanPenjualan> ReadByFieldRP(string value, string field)
        {
            List<LaporanPenjualan> list = new List<LaporanPenjualan>();
            using (DbContext context = new DbContext())
            {
                _repository = new LaporanPenjualanRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
    }
}
