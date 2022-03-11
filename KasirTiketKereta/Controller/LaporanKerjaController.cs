using KasirTiketKereta.Model.Context;
using KasirTiketKereta.Model.Entity;
using KasirTiketKereta.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirTiketKereta.Controller
{
    class LaporanKerjaController
    {
        private LaporanKerjaRepository _repository;
        public List<LaporanKerja> ReadAll()
        {
            List<LaporanKerja> list = new List<LaporanKerja>();
            using (DbContext context = new DbContext())
            {
                _repository = new LaporanKerjaRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<LaporanKerja> ReadByField(string value, string field)
        {
            List<LaporanKerja> list = new List<LaporanKerja>();
            using (DbContext context = new DbContext())
            {
                _repository = new LaporanKerjaRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
    }
}
