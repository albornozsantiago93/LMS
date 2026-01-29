using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain
{
    public class SystemUser : BaseUserEntity
    {
        public int PlatformRoleId { get; set; }
        [InverseProperty("SystemUser")]
        public virtual List<SystemUserPlatformPermision> Permissions { get; set; }

    }
}
