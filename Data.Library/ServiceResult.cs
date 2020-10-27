using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Library
{
    public class ServiceResult
    {
        public bool Succeeded { get; private set; }
        public int Id { get; }
        public IEnumerable<string> Errors = new List<string>();

        public ServiceResult Set(IEnumerable<string> errors)
        {
            Errors = errors;
            return this;
        }

        public ServiceResult(bool succeeded)
        {
            Succeeded = succeeded;
        }

        public ServiceResult(int id, bool succeeded)
        {
            Id = id;
            Succeeded = succeeded;
        }
    }
}
