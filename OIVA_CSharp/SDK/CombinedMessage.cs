using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIVA_CSharp.SDK
{
    /// <summary>
    /// 类_合并消息
    /// </summary>
    public class CombinedMessage
    {
        private  OIVADll Api;
        private JArray json = new JArray();
        public CombinedMessage(OIVADll api)
        {
            Api = api;
        }
        /// <summary>
        /// 置消息ID
        /// </summary>
        /// <param name="id">消息ID</param>
        public CombinedMessage AddForwardMsgId(string id)
        {
            json.Add(JToken.Parse(Api.SendForwardMsgId(id)));
            return this;
        }
        /// <summary>
        /// 置自定义消息_一般
        /// </summary>
        /// <param name="name">发送者显示名字</param>
        /// <param name="uin">发送者QQ号</param>
        /// <param name="type">消息类型</param>
        /// <param name="text">消息内容/表情ID</param>
        /// <returns></returns>
        public CombinedMessage AddCustomForwardMsg(string name, string uin, string type, string text)
        {
            json.Add(JToken.Parse(Api.SendForwardMsgGen(name, uin, type, text)));
            return this;
        }
        /// <summary>
        /// 置自定义消息_简单
        /// </summary>
        /// <param name="name">发送者显示名字</param>
        /// <param name="uin">发送者QQ号</param>
        /// <param name="content">消息内容</param>
        public CombinedMessage AddCustomForwardMsgSim(string name, string uin, string content)
        {
            json.Add(JToken.Parse(Api.SendForwardMsgSim(name, uin, content)));
            return this;
        }
        /// <summary>
        /// 发送自定义消息_复杂
        /// </summary>
        /// <param name="name">发送者显示名字</param>
        /// <param name="uin">发送者QQ号</param>
        /// <param name="content">消息内容</param>
        /// <param name="seq">具体消息</param>
        /// <param name="time">发送时间戳</param>
        public CombinedMessage AddCustomForwardMsgCom(string name, string uin, string content, string seq, string time)
        {
            json.Add(JToken.Parse(Api.SendForwardMsgCom(name, uin, content, seq, time)));
            return this;
        }
        /// <summary>
        /// 取合并消息
        /// </summary>
        /// <returns>JSON文本</returns>
        public string GetCombinedMessage()
        {
            return ToString();
        }
        public override string ToString()
        {
            return json.ToString(Newtonsoft.Json.Formatting.None);
        }
    }
}
