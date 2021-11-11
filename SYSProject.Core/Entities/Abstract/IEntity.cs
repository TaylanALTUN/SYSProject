using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSProject.Entities.Abstract
{
    public interface IEntity
    {
        public long Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
