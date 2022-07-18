using net.r_eg.Conari;
using net.r_eg.Conari.Types;
using System;
using System.Runtime.InteropServices;

namespace OIVA_CSharp
{
    public abstract class DllApi
    {
        private ConariL CL;
        public virtual T Bind<T>(string name) where T : class
        {
            return CL.bindFunc<T>(name);
        }
        public DllApi(string dll)
        {
            CL = new ConariL(dll);
        }
        ~DllApi() => CL.Dispose();
        [StructLayout(LayoutKind.Explicit)]
        public class AnsiCharPtr : IDisposable
        {
            public AnsiCharPtr(string str)
            {
                if (str is null)
                {
                    data = Marshal.StringToHGlobalAnsi("");
                }
                else
                {
                    data = Marshal.StringToHGlobalAnsi(str);
                }
            }
            [FieldOffset(0)]
            private readonly IntPtr data;
            [NativeType]
            public static implicit operator IntPtr(AnsiCharPtr v)
            {
                return v.data;
            }
            public void Dispose()
            {
                Marshal.FreeHGlobal(data);
            }
        }


    }

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
