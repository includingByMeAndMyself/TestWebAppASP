using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApp.Domain.Entitties;
using TestWebApp.Domain.Repositories.Abstract;

namespace TestWebApp.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDbContext context;

        public EFTextFieldsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ServiceItem> GetTextFields()
        {
            return context.TextFields;
        }

        public ServiceItem GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.ID == id);
        }
        public ServiceItem GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }
        public void SaveTextField(ServiceItem entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;

            context.SaveChanges();
        }
        public void DeletTextField(Guid id)
        {
            context.TextFields.Remove(new ServiceItem() { ID = id });
            context.SaveChanges();
        }       
    }
}
