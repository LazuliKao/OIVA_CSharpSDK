
using System.Runtime.InteropServices;
//[assembly: ComVisible(true)]

namespace OIVA_CSharp
{
    public static class Main
    {
        // [请填写] 应用ID
        public const string AppId = "com.example.demo";


















        //然后往下滚xD:



















        internal static OIVADll Api;
        /// <summary>
        /// 应用的ApiVer、Appid //请勿修改本子程序
        /// </summary>
        /// <returns><see cref="string"/></returns>
        [DllExport("AppInfo")]
        [return: MarshalAs(UnmanagedType.AnsiBStr)]
        public static string AppInfo() {
            return "4,"+AppId;
        }
        // + AppId;
        /// <summary>
        /// 应用AuthCode接收 //请勿修改本子程序
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("Initialize")]
        public static int Initialize(int AuthCode)
        {
            Api = new OIVADll(AuthCode);//初始化API
            Api.AddLog(OIVAConst.Log_Info, AppId, "初始化成功");//记录日志
            return 0;
        }
        /// <summary>
        /// Type=1004 应用将被停用
        /// </summary>
        /// <returns><see cref = "int" /></ returns >
        [DllExport("_eventDisable")]
        public static int EventDisable()
        {
            return 0;
        }
        /// <summary>
        /// Type=1003 应用已被启用
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventEnable")]
        public static int EventEnable()
        {
            return 0;
        }
        /// <summary>
        /// Type=1002 OIVA退出
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventExit")]
        public static int EventExit()
        {
            return 0;
        }
        /// <summary>
        /// Type=201 好友事件-好友已添加
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromAccount">来源帐号</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventFriend_Add")]
        public static int EventFriend_Add(int subType, long sendTime, long fromAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=401 好友事件-收到离线文件
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="file">接收文件信息</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventFriend_File")]
        public static int EventFriend_File(int subType, long sendTime, long fromAccount, string file)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=2 群消息
        /// </summary>
        /// <param name="subType">子类型，1/来自群 2/来自群匿名</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="fromAnonymous">来源匿名者;非匿名消息时为空</param>,
        /// <param name="msg">消息内容</param>,
        /// <param name="font">字体</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGroupMsg")]
        public static int EventGroupMsg(int subType, long sendTime, int msgId, long fromGroup, long fromAccount, string fromAnonymous, string msg, int font)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=11 群事件-群文件上传
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="file">上传文件信息</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGroupUpload")]
        public static int EventGroupUpload(int subType, long sendTime, long fromGroup, long fromAccount, string file)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=604 频道事件-子频道创建
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号</param>,
        /// <param name="channel_info">频道信息 之后用API来解决</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGuild_ChannelCreate")]
        public static int EventGuild_ChannelCreate(int subType, long sendTime, string guildId, string channelId, long fromAccount, string beingOperateAccount, string channel_info)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=605 频道事件-子频道删除
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号</param>,
        /// <param name="channel_info">频道信息 之后用API来解决</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGuild_ChannelDel")]
        public static int EventGuild_ChannelDel(int subType, long sendTime, string guildId, string channelId, long fromAccount, string beingOperateAccount, string channel_info)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=603 频道事件-子频道信息更新
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号</param>,
        /// <param name="old_info">更新前的频道信息 之后用API来解决</param>,
        /// <param name="new_info">更新后的频道信息 之后用API来解决</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGuild_ChannelUpdated")]
        public static int EventGuild_ChannelUpdated(int subType, long sendTime, string guildId, string channelId, long fromAccount, string beingOperateAccount, string old_info, string new_info)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=602 频道事件-频道消息表情贴更新
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID，频道的消息ID都是文本型的</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="current_reactions">当前消息被贴表情列表 之后用API来解决</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGuild_Emoji")]
        public static int EventGuild_Emoji(int subType, long sendTime, string msgId, string guildId, string channelId, string fromAccount, string current_reactions)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=601 频道消息
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID，频道的消息ID都是文本型的</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="senderId">发件人ID</param>,
        /// <param name="senderNickName">发件人昵称</param>,
        /// <param name="msg">消息内容</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventGuildMsg")]
        public static int EventGuildMsg(int subType, long sendTime, string msgId, string guildId, string channelId, string senderId, string senderNickName, string msg)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=403 好友事件-戳一戳
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="senderId">发件人ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号(仅子类型为1时可用)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventPoke_Friend")]
        public static int EventPoke_Friend(int subType, long sendTime, long senderId, long fromAccount, long beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=1 私聊消息
        /// </summary>
        /// <param name="subType">子类型，11/来自好友 1/来自在线状态 2/来自群 3/来自讨论组</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="msg">消息内容</param>,
        /// <param name="font">字体</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventPrivateMsg")]
        public static int EventPrivateMsg(int subType, long sendTime, int msgId, long fromAccount, string msg, int font)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=301 请求-好友添加
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="msg">附言</param>,
        /// <param name="responseFlag">反馈标识(处理请求用)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventRequest_AddFriend")]
        public static int EventRequest_AddFriend(int subType, long sendTime, long fromAccount, string msg, string responseFlag)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=302 请求-群添加
        /// </summary>
        /// <param name="subType">子类型，1/他人申请入群 2/自己(即登录号)受邀入群</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="msg">附言</param>,
        /// <param name="responseFlag">反馈标识(处理请求用)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventRequest_AddGroup")]
        public static int EventRequest_AddGroup(int subType, long sendTime, long fromGroup, long fromAccount, string msg, string responseFlag)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=402 好友事件-消息撤回
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID</param>,
        /// <param name="fromAccount">来源帐号</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventRevoke_Friend")]
        public static int EventRevoke_Friend(int subType, long sendTime, int msgId, long fromAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=108 群事件-消息撤回
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息id</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号(被撤回消息的帐号)</param>,
        /// <param name="beingOperateAccount">被操作帐号(使用撤回功能的帐号)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventRevoke_Group")]
        public static int EventRevoke_Group(int subType, long sendTime, int msgId, long fromGroup, long fromAccount, long beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=605 频道事件-消息撤回
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID，频道的消息ID都是文本型的</param>,
        /// <param name="guildId">频道ID</param>,
        /// <param name="channelId">子频道ID</param>,
        /// <param name="fromAccount">来源帐号(被撤回消息的帐号)</param>,
        /// <param name="beingOperateAccount">被操作帐号(使用撤回功能的帐号)，频道的被操作帐号都是文本型的</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventRevoke_Guild")]
        public static int EventRevoke_Guild(int subType, long sendTime, string msgId, string guildId, string channelId, long fromAccount, string beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=1001 OIVA启动
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventStartup")]
        public static int EventStartup()
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=105 群事件-精华消息
        /// </summary>
        /// <param name="subType">子类型，1/增加精华消息 2/删除精华消息</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="msgId">消息ID</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="operatorId">操作员帐号</param>,
        /// <param name="senderId">发送人帐号</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_EssenceNews")]
        public static int EventSystem_EssenceNews(int subType, long sendTime, int msgId, long fromGroup, long operatorId, long senderId)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=101 群事件-管理员变动
        /// </summary>
        /// <param name="subType">子类型，1/被取消管理员 2/被设置管理员</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupAdmin")]
        public static int EventSystem_GroupAdmin(int subType, long sendTime, long fromGroup, long fromAccount, long beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=104 群事件-群禁言
        /// </summary>
        /// <param name="subType">子类型，1/被解禁 2/被禁言</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">操作者帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号(若为全群禁言/解禁，则本参数为 0)</param>,
        /// <param name="duration">禁言时长(单位 秒，仅子类型为2时可用)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupBan")]
        public static int EventSystem_GroupBan(int subType, long sendTime, long fromGroup, long fromAccount, long beingOperateAccount, long duration)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=107 群事件-成员名片更新
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="newCard">新名片</param>,
        /// <param name="oldCard">旧名片</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupBusidCard")]
        public static int EventSystem_GroupBusidCard(int subType, long sendTime, long fromGroup, long fromAccount, string newCard, string oldCard)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=102 群事件-群成员减少
        /// </summary>
        /// <param name="subType">子类型，1/群员离开 2/群员被踢 3/自己被踢(指机器人)</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">操作者帐号(仅子类型为2时存在)</param>,
        /// <param name="beingOperateAccount">被操作帐号</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupMemberDecrease")]
        public static int EventSystem_GroupMemberDecrease(int subType, long sendTime, long fromGroup, long fromAccount, long beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=103 群事件-群成员增加
        /// </summary>
        /// <param name="subType">子类型，1/管理员已同意 2/管理员邀请</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">操作者帐号(即管理员帐号)[此项无值, 详见:https://github.com/Mrs4s/go-cqhttp/issues/721]</param>,
        /// <param name="beingOperateAccount">被操作帐号(即加群的帐号)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupMemberIncrease")]
        public static int EventSystem_GroupMemberIncrease(int subType, long sendTime, long fromGroup, long fromAccount, long beingOperateAccount)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=106 群事件-群内通知
        /// </summary>
        /// <param name="subType">子类型，1/群内戳一戳 2/群内红包运气王提示 3/群成员荣誉变更提示</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromGroup">来源群号</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="beingOperateAccount">被操作帐号(仅子类型为1时可用)</param>,
        /// <param name="honoraryName">群荣誉名称(仅子类型为3时可用)</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_GroupNotice")]
        public static int EventSystem_GroupNotice(int subType, long sendTime, long fromGroup, long fromAccount, long beingOperateAccount, string honoraryName)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// Type=501 其他客户端在线状态变更
        /// </summary>
        /// <param name="subType">子类型，目前固定为1</param>,
        /// <param name="sendTime">发送时间(时间戳)</param>,
        /// <param name="fromAccount">来源帐号</param>,
        /// <param name="appId">客户端ID</param>,
        /// <param name="deviceKind">设备类型</param>,
        /// <param name="deviceName">设备名称</param>,
        /// <param name="online">在线状态</param>
        /// <returns><see cref="int"/></returns>
        [DllExport("_eventSystem_OtherClientOnlineStatusChanges")]
        public static int EventSystem_OtherClientOnlineStatusChanges(int subType, long sendTime, long fromAccount, long appId, string deviceKind, string deviceName, bool online)
        {
            return OIVAConst.消息_忽略;
        }
        /// <summary>
        /// _menuA
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [DllExport("_menuA")]
        public static int MenuA()
        {
            return 0;
        }
        /// <summary>
        /// _menuB
        /// </summary>
        /// <returns><see cref="int"/></returns>
        [DllExport("_menuB")]
        public static int MenuB()
        {
            return 0;
        }
    }
}