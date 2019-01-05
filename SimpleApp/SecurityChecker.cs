using Core.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class SecurityChecker : ISecurityChecker
    {
        public bool AmIAllowed<T>() where T : IBaseViewModel
        {
            //string fullname = typeof(T).FullName;
            //ISession ret = Bootstrapper.Resolve<ISession>();
            //if (ret == null) throw new UserException("Oturum açılırken bir hata oluştu.");
            //return ret.AmIAllowed(fullname);

            return true;
        }

        public bool DoIHaveRole(string role)
        {
            //ISession ret = Bootstrapper.Resolve<ISession>();
            //if (ret == null) throw new UserException("Oturum açılırken bir hata oluştu.");
            //return ret.DoIHaveRole(role);

            return true;
        }

        public string GetCurrentFullNameOfUser()
        {
            //ISession ret = Bootstrapper.ResolveSession();
            //return ret.CurrentUser.Consumer.Description;

            return "";
        }
    }
}
