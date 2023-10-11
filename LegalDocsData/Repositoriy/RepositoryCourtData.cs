using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LegalDocsData.Context;
using LegalDocsData.Models;
using Microsoft.IdentityModel.Tokens;

namespace LegalDocsData.Repositoriy
{
    internal class RepositoryCourtData : IRepositoriy<CourtData>
    {
        // создать контейнер, поле
        private List<CourtData> courtDatas;

        private ApplicationDBContext _db;


        public RepositoryCourtData(ApplicationDBContext db)
        {
            courtDatas = db.CourtDatas.ToList();
            _db = db;

        }

        public void Add(CourtData item)
        {
            courtDatas.Add(item);
        }

        public void Delete(int Id)
        {
            CourtData? item = courtDatas.Find(a => a.Id == Id);
            if (item != null)
            {
                courtDatas.Remove(item);
            }
        }

        public IEnumerable<CourtData> GetAll()
        {
            return courtDatas;
        }

        public CourtData? GetId(int id)
        {
            CourtData? item = courtDatas.Find(a => a.Id == id);
            if (item != null)
            {
                return item;
            }
            return null;
        }

        public IEnumerable<CourtData>? GetName(string name)
        {
            var items = courtDatas.FindAll(a => a.court_name == name);
            if (items != null)
            {
                return items;
            }
            return null;
        }

        public int Save()
        {
            return _db.SaveChanges();
        }

        public void Update(CourtData item)
        {
            CourtData itemUpdate = courtDatas.FirstOrDefault(item);
            itemUpdate = item;
        }
    }
}
