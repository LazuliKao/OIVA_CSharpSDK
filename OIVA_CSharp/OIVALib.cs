using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIVA_CSharp
{
    internal partial class OIVADll
    {
        public int AuthCode = 0;
        public override T Bind<T>(string name)
        {
            try
            {
                return base.Bind<T>(name);
            }
            catch (Exception ex)
            {
#if DEBUG
                if (AuthCode != 0)
                {
                    AddLog(OIVAConst.Log_Warning, Main.AppId, $"Error ! Bind<T>({name}) {ex}");
                }
#endif
                return null;
            }
        }
    }
}
