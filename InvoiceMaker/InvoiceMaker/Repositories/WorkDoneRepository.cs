﻿using InvoiceMaker.Data;
using InvoiceMaker.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace InvoiceMaker.Repositories
{
    public class WorkDoneRepository : BaseRepository
    {
        public WorkDoneRepository(Context context) : base(context) { }

        // Grammar is important.
        public List<WorkDone> GetWorksDone()
        {
            var worksDone = _context.WorksDone
                .Include(wd => wd.Client)
                .Include(wd => wd.WorkType)
                .ToList();

            return worksDone;
        }

        public WorkDone GetById(int id)
        {
            var workDone = _context.WorksDone
                .Include(wd => wd.Client)
                .Include(wd => wd.WorkType)
                .SingleOrDefault(wd => wd.Id == id);

            return workDone;
        }

        public void Insert(WorkDone workDone)
        {
            _context.WorksDone.Add(workDone);
            _context.SaveChanges();
        }

        public void Update(WorkDone workDone)
        {
            // SaveChanges is called by the extension method
            _context.UpdateEntity(workDone);
        }
    }
}