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
    class RiwayatPemesananController
    {

        private RiwayatPemesananRepository _repository;
        public List<RiwayatPemesanan> ReadAll()
        {
            List<RiwayatPemesanan> list = new List<RiwayatPemesanan>();
            using (DbContext context = new DbContext())
            {
                _repository = new RiwayatPemesananRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<RiwayatPemesanan> ReadByField(string value, string field)
        {
            List<RiwayatPemesanan> list = new List<RiwayatPemesanan>();
            using (DbContext context = new DbContext())
            {
                _repository = new RiwayatPemesananRepository(context);
                list = _repository.ReadByField(value, field);
            }
            return list;
        }
    }
}
