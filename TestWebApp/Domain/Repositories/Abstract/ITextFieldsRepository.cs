using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebApp.Domain.Entitties;

namespace TestWebApp.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<ServiceItem> GetTextFields();
        ServiceItem GetTextFieldById(Guid id);
        ServiceItem GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(ServiceItem entity);
        void DeletTextField(Guid id);
    }
}
