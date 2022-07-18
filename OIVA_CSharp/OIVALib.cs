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
#if DEBUG
        /// <summary>
        /// 输出调试信息
        /// 仅DEBUG编译可用
        /// 插件信息输出请使用Api.AddLog函数
        /// </summary>
        /// <param name="text"></param>
        /// <param name="args"></param>
        public void OutputDebugText(string text, string funcname, params object[] args)
        {
            if (funcname == "AddLog") return;//避免死循环（堆栈溢出）
            AddLog(OIVAConst.Log_Debug, Main.AppId, string.Format(text, funcname, args));
        }
#endif
    }
}
