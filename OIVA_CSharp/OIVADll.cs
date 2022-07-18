using net.r_eg.Conari;
using net.r_eg.Conari.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace OIVA_CSharp
{
    internal static class OIVAConst
    {
        public const int arr_cbSize = 16;
        public const int arr_count = 4;
        public const int arr_hAlloctor = 0;
        public const int arr_table = 8;
        public const int arr_tableLength = 12;
        public const int CP_936 = 936;
        public const int CP_ACP = 0;
        public const int CP_UTF8 = 65001;
        public const int CREATE_ALWAYS = 2;
        public const int FILE_ATTRIBUTE_NORMAL = 128;
        public const string File_base64 = "base64://";
        public const string File_links = "link://";
        public const string File_local = "file:///";
        public const int GENERIC_READ = -2147483648;
        public const int GENERIC_WRITE = 1073741824;
        public const int HEAP_ZERO_MEMORY = 8;
        public const int ht_cbSize = 28;
        public const int ht_count = 12;
        public const int ht_eArray = 24;
        public const int ht_hAlloctor = 0;
        public const int ht_loadFactor = 20;
        public const int ht_table = 4;
        public const int ht_tableLenth = 8;
        public const int ht_threshold = 16;
        public const int INFINITE = -1;
        public const int JSON_ERROR = -1;
        public const int JSON_INVALIDARG = -2;
        public const int JSON_INVALIDNAME = -4;
        public const int JSON_INVALIDVALUE = -6;
        public const int JSON_MEMORY = -3;
        public const int JSON_NONEXTQUOTE = -7;
        public const int JSON_OBJECTPARENT = -5;
        public const int JSON_OK = 0;
        public const int jv_cbSize = 40;
        public const int jv_doc = 36;
        public const int jv_hashCode = 4;
        public const int jv_key = 8;
        public const int jv_next = 20;
        public const int jv_parent = 28;
        public const int jv_raw = 32;
        public const int jv_type = 24;
        public const int jv_value = 12;
        public const int jvp_isEnded = 3;
        public const int jvp_needName = 1;
        public const int jvp_needValue = 2;
        public const int JVPS_INDEX = 2;
        public const int JVPS_NAME = 1;
        public const int jvstep_cbSize = 12;
        public const int jvstep_flags = 0;
        public const int jvstep_index = 8;
        public const int jvstep_name = 4;
        public const int JVTYPE_ARRAY = 5;
        public const int JVTYPE_BOOL = 3;
        public const int JVTYPE_DOUBLE = 1;
        public const int JVTYPE_LONG = 2;
        public const int JVTYPE_NULL = 0;
        public const int JVTYPE_OBJECT = 6;
        public const int JVTYPE_STRING = 4;
        public const int JVTYPE_UNDEFINED = -1;
        public const int JV解析_忽略前后文本 = 2;
        public const int JV类型_长整数型 = 2;
        public const int JV类型_对象 = 6;
        public const int JV类型_空 = 0;
        public const int JV类型_逻辑型 = 3;
        public const int JV类型_数组 = 5;
        public const int JV类型_双精度型 = 1;
        public const int JV类型_未定义 = -1;
        public const int JV类型_文本型 = 4;
        public const int LCMAP_FULLWIDTH = 8388608;
        public const int LCMAP_HALFWIDTH = 4194304;
        public const int ll_cbSize = 24;
        public const int ll_count = 4;
        public const int ll_current = 12;
        public const int ll_hAlloctor = 0;
        public const int ll_header = 16;
        public const int ll_isNewHeap = 20;
        public const int ll_valType = 8;
        public const int Log_Debug = 0;
        public const int Log_Error = 30;
        public const int Log_Fatal = 40;
        public const int Log_Info = 10;
        public const int Log_InfoRecv = 12;
        public const int Log_InfoSend = 13;
        public const int Log_InfoSuccess = 11;
        public const int Log_Warning = 20;
        public const int nd_cbSize = 8;
        public const int nd_next = 4;
        public const int nd_value = 0;
        public const int OPEN_ALWAYS = 4;
        public const int OPEN_EXISTING = 3;
        public const int STIF_DEFAULT = 0;
        public const int STIF_SUPPORT_HEX = 1;
        public const int zyobj_hAlloctor = 0;
        public const int zyStack_cbSize = 16;
        public const int zyStack_hAlloctor = 0;
        public const int zyStack_table = 4;
        public const int zyStack_tableLength = 8;
        public const int zyStack_top = 12;
        public const int zyStackValue_Size = 8;
        public const int zystr_bufferLen = 8;
        public const int zystr_cbSize = 16;
        public const int zystr_pStr = 4;
        public const int zystr_strLen = 12;
        public const int 表情_K歌 = 140;
        public const int 表情_爱你 = 122;
        public const int 表情_爱情 = 42;
        public const int 表情_爱心 = 66;
        public const int 表情_傲慢 = 23;
        public const int 表情_白眼 = 22;
        public const int 表情_棒棒糖 = 147;
        public const int 表情_抱拳 = 118;
        public const int 表情_爆筋 = 146;
        public const int 表情_鄙视 = 105;
        public const int 表情_闭嘴 = 7;
        public const int 表情_鞭炮 = 137;
        public const int 表情_便便 = 59;
        public const int 表情_不 = 123;
        public const int 表情_擦汗 = 97;
        public const int 表情_彩球 = 164;
        public const int 表情_菜刀 = 112;
        public const int 表情_差劲 = 121;
        public const int 表情_钞票 = 158;
        public const int 表情_车厢 = 154;
        public const int 表情_打伞 = 163;
        public const int 表情_大兵 = 29;
        public const int 表情_大哭 = 9;
        public const int 表情_蛋糕 = 53;
        public const int 表情_刀 = 56;
        public const int 表情_得意 = 4;
        public const int 表情_灯笼 = 138;
        public const int 表情_灯泡 = 160;
        public const int 表情_凋谢 = 64;
        public const int 表情_调皮 = 12;
        public const int 表情_多云 = 156;
        public const int 表情_发财 = 139;
        public const int 表情_发呆 = 3;
        public const int 表情_发抖 = 41;
        public const int 表情_发怒 = 11;
        public const int 表情_饭 = 61;
        public const int 表情_飞机 = 151;
        public const int 表情_飞吻 = 85;
        public const int 表情_奋斗 = 30;
        public const int 表情_风车 = 161;
        public const int 表情_高铁右车头 = 155;
        public const int 表情_高铁左车头 = 153;
        public const int 表情_勾引 = 119;
        public const int 表情_购物 = 141;
        public const int 表情_鼓掌 = 99;
        public const int 表情_哈欠 = 104;
        public const int 表情_害羞 = 6;
        public const int 表情_憨笑 = 28;
        public const int 表情_好 = 124;
        public const int 表情_喝彩 = 144;
        public const int 表情_喝奶 = 148;
        public const int 表情_坏笑 = 101;
        public const int 表情_挥手 = 129;
        public const int 表情_回头 = 127;
        public const int 表情_饥饿 = 24;
        public const int 表情_激动 = 130;
        public const int 表情_街舞 = 131;
        public const int 表情_惊恐 = 26;
        public const int 表情_惊讶 = 0;
        public const int 表情_咖啡 = 60;
        public const int 表情_开车 = 152;
        public const int 表情_磕头 = 126;
        public const int 表情_可爱 = 21;
        public const int 表情_可怜 = 111;
        public const int 表情_抠鼻 = 98;
        public const int 表情_酷 = 16;
        public const int 表情_快哭了 = 107;
        public const int 表情_困 = 25;
        public const int 表情_篮球 = 114;
        public const int 表情_冷汗 = 96;
        public const int 表情_礼物 = 69;
        public const int 表情_流汗 = 27;
        public const int 表情_流泪 = 5;
        public const int 表情_玫瑰 = 63;
        public const int 表情_难过 = 15;
        public const int 表情_闹钟 = 162;
        public const int 表情_啤酒 = 113;
        public const int 表情_瓢虫 = 117;
        public const int 表情_撇嘴 = 1;
        public const int 表情_乒乓 = 115;
        public const int 表情_祈祷 = 145;
        public const int 表情_强 = 76;
        public const int 表情_敲打 = 38;
        public const int 表情_亲亲 = 109;
        public const int 表情_青蛙 = 170;
        public const int 表情_拳头 = 120;
        public const int 表情_弱 = 77;
        public const int 表情_色 = 2;
        public const int 表情_沙发 = 166;
        public const int 表情_闪电 = 54;
        public const int 表情_胜利 = 79;
        public const int 表情_示爱 = 116;
        public const int 表情_手枪 = 169;
        public const int 表情_衰 = 36;
        public const int 表情_帅 = 143;
        public const int 表情_双喜 = 136;
        public const int 表情_睡 = 8;
        public const int 表情_太阳 = 74;
        public const int 表情_跳绳 = 128;
        public const int 表情_跳跳 = 43;
        public const int 表情_偷笑 = 20;
        public const int 表情_吐 = 19;
        public const int 表情_微笑 = 14;
        public const int 表情_委屈 = 106;
        public const int 表情_握手 = 78;
        public const int 表情_西瓜 = 89;
        public const int 表情_下面 = 149;
        public const int 表情_下雨 = 157;
        public const int 表情_吓 = 110;
        public const int 表情_献吻 = 132;
        public const int 表情_香蕉 = 150;
        public const int 表情_心碎 = 67;
        public const int 表情_熊猫 = 159;
        public const int 表情_药 = 168;
        public const int 表情_疑问 = 32;
        public const int 表情_阴险 = 108;
        public const int 表情_拥抱 = 49;
        public const int 表情_邮件 = 142;
        public const int 表情_右哼哼 = 103;
        public const int 表情_右太极 = 134;
        public const int 表情_月亮 = 75;
        public const int 表情_晕 = 34;
        public const int 表情_再见 = 39;
        public const int 表情_炸弹 = 55;
        public const int 表情_折磨 = 35;
        public const int 表情_纸巾 = 167;
        public const int 表情_咒骂 = 31;
        public const int 表情_猪头 = 46;
        public const int 表情_抓狂 = 18;
        public const int 表情_转圈 = 125;
        public const int 表情_足球 = 57;
        public const int 表情_钻戒 = 165;
        public const int 表情_左哼哼 = 102;
        public const int 表情_左太极 = 133;
        public const int 表情_尴尬 = 10;
        public const int 表情_呲牙 = 13;
        public const int 表情_怄火 = 86;
        public const int 表情_糗大了 = 100;
        public const int 表情_骷髅 = 37;
        public const int 请求_拒绝 = 2;
        public const int 请求_群添加 = 1;
        public const int 请求_群邀请 = 2;
        public const int 请求_通过 = 1;
        public const int 消息_忽略 = 0;
        public const int 消息_拦截 = 1;

    }
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
    internal partial class OIVADll : DllApi
    {
        public OIVADll(int AuthCode) : base("OIVA.dll")
        {
            this.AuthCode = AuthCode;
            Va_addLog_func = Bind<Va_addLog_delegate>("Va_addLog");
            Va_canSendImage_func = Bind<Va_canSendImage_delegate>("Va_canSendImage");
            Va_canSendRecord_func = Bind<Va_canSendRecord_delegate>("Va_canSendRecord");
            Va_canSendVoice_func = Bind<Va_canSendVoice_delegate>("Va_canSendVoice");
            Va_checkUrlSafety_func = Bind<Va_checkUrlSafety_delegate>("Va_checkUrlSafety");
            Va_deleteFriend_func = Bind<Va_deleteFriend_delegate>("Va_deleteFriend");
            Va_deleteMsg_func = Bind<Va_deleteMsg_delegate>("Va_deleteMsg");
            Va_deleteUnidirectionalFriend_func = Bind<Va_deleteUnidirectionalFriend_delegate>("Va_deleteUnidirectionalFriend");
            Va_downloadFileCache_func = Bind<Va_downloadFileCache_delegate>("Va_downloadFileCache");
            Va_getAppDirectory_func = Bind<Va_getAppDirectory_delegate>("Va_getAppDirectory");
            Va_getForwardMsg_func = Bind<Va_getForwardMsg_delegate>("Va_getForwardMsg");
            Va_getFriendList_func = Bind<Va_getFriendList_delegate>("Va_getFriendList");
            Va_getGroupEssenceNews_func = Bind<Va_getGroupEssenceNews_delegate>("Va_getGroupEssenceNews");
            Va_getGroupFileDownurl_func = Bind<Va_getGroupFileDownurl_delegate>("Va_getGroupFileDownurl");
            Va_getGroupHistoricalNews_func = Bind<Va_getGroupHistoricalNews_delegate>("Va_getGroupHistoricalNews");
            Va_getGroupHonorInfo_func = Bind<Va_getGroupHonorInfo_delegate>("Va_getGroupHonorInfo");
            Va_getGroupInfo_func = Bind<Va_getGroupInfo_delegate>("Va_getGroupInfo");
            Va_getGroupList_func = Bind<Va_getGroupList_delegate>("Va_getGroupList");
            Va_getGroupMemberInfo_func = Bind<Va_getGroupMemberInfo_delegate>("Va_getGroupMemberInfo");
            Va_getGroupMemberList_func = Bind<Va_getGroupMemberList_delegate>("Va_getGroupMemberList");
            Va_getGroupNotice_func = Bind<Va_getGroupNotice_delegate>("Va_getGroupNotice");
            Va_getGroupRootdirectoryfile_func = Bind<Va_getGroupRootdirectoryfile_delegate>("Va_getGroupRootdirectoryfile");
            Va_getGroupSpaceInfo_func = Bind<Va_getGroupSpaceInfo_delegate>("Va_getGroupSpaceInfo");
            Va_getGroupSubdirectoryfile_func = Bind<Va_getGroupSubdirectoryfile_delegate>("Va_getGroupSubdirectoryfile");
            Va_getGroupSystemMsg_func = Bind<Va_getGroupSystemMsg_delegate>("Va_getGroupSystemMsg");
            Va_getGroupTotalAtRemainingNumber_func = Bind<Va_getGroupTotalAtRemainingNumber_delegate>("Va_getGroupTotalAtRemainingNumber");
            Va_getGuildChannelList_func = Bind<Va_getGuildChannelList_delegate>("Va_getGuildChannelList");
            Va_getGuildList_func = Bind<Va_getGuildList_delegate>("Va_getGuildList");
            Va_getGuildMemberList_func = Bind<Va_getGuildMemberList_delegate>("Va_getGuildMemberList");
            Va_getGuildMemberProfile_func = Bind<Va_getGuildMemberProfile_delegate>("Va_getGuildMemberProfile");
            Va_getGuildMetaByGuest_func = Bind<Va_getGuildMetaByGuest_delegate>("Va_getGuildMetaByGuest");
            Va_getGuildServiceProfile_func = Bind<Va_getGuildServiceProfile_delegate>("Va_getGuildServiceProfile");
            Va_getImageInfo_func = Bind<Va_getImageInfo_delegate>("Va_getImageInfo");
            Va_getLoginNick_func = Bind<Va_getLoginNick_delegate>("Va_getLoginNick");
            Va_getLoginQQ_func = Bind<Va_getLoginQQ_delegate>("Va_getLoginQQ");
            Va_getMessageInfo_func = Bind<Va_getMessageInfo_delegate>("Va_getMessageInfo");
            Va_getModelShow_func = Bind<Va_getModelShow_delegate>("Va_getModelShow");
            Va_getQidianAccountInfo_func = Bind<Va_getQidianAccountInfo_delegate>("Va_getQidianAccountInfo");
            Va_getRecordV2_func = Bind<Va_getRecordV2_delegate>("Va_getRecordV2");
            Va_getRobotInfo_func = Bind<Va_getRobotInfo_delegate>("Va_getRobotInfo");
            Va_getRobotOnlineDevice_func = Bind<Va_getRobotOnlineDevice_delegate>("Va_getRobotOnlineDevice");
            Va_getRunState_func = Bind<Va_getRunState_delegate>("Va_getRunState");
            Va_getRunTime_func = Bind<Va_getRunTime_delegate>("Va_getRunTime");
            Va_getStrangerInfo_func = Bind<Va_getStrangerInfo_delegate>("Va_getStrangerInfo");
            Va_getUnidirectionalFriendList_func = Bind<Va_getUnidirectionalFriendList_delegate>("Va_getUnidirectionalFriendList");
            Va_getUserVipInfo_func = Bind<Va_getUserVipInfo_delegate>("Va_getUserVipInfo");
            Va_getVersion_func = Bind<Va_getVersion_delegate>("Va_getVersion");
            Va_getWordSlices_func = Bind<Va_getWordSlices_delegate>("Va_getWordSlices");
            Va_HandleQuickOperation_func = Bind<Va_HandleQuickOperation_delegate>("Va_HandleQuickOperation");
            Va_ocrImage_func = Bind<Va_ocrImage_delegate>("Va_ocrImage");
            Va_overloadEventFilter_func = Bind<Va_overloadEventFilter_delegate>("Va_overloadEventFilter");
            Va_sendForwardMsg_func = Bind<Va_sendForwardMsg_delegate>("Va_sendForwardMsg");
            Va_sendForwardMsgCom_func = Bind<Va_sendForwardMsgCom_delegate>("Va_sendForwardMsgCom");
            Va_sendForwardMsgGen_func = Bind<Va_sendForwardMsgGen_delegate>("Va_sendForwardMsgGen");
            Va_sendForwardMsgId_func = Bind<Va_sendForwardMsgId_delegate>("Va_sendForwardMsgId");
            Va_sendForwardMsgSim_func = Bind<Va_sendForwardMsgSim_delegate>("Va_sendForwardMsgSim");
            Va_sendGroupForwardMsg_func = Bind<Va_sendGroupForwardMsg_delegate>("Va_sendGroupForwardMsg");
            Va_sendGroupMsg_func = Bind<Va_sendGroupMsg_delegate>("Va_sendGroupMsg");
            Va_sendGroupNotice_func = Bind<Va_sendGroupNotice_delegate>("Va_sendGroupNotice");
            Va_sendGroupTemporaryMsg_func = Bind<Va_sendGroupTemporaryMsg_delegate>("Va_sendGroupTemporaryMsg");
            Va_sendGuildChannelMsg_func = Bind<Va_sendGuildChannelMsg_delegate>("Va_sendGuildChannelMsg");
            Va_sendMsg_func = Bind<Va_sendMsg_delegate>("Va_sendMsg");
            Va_sendPrivateForwardMsg_func = Bind<Va_sendPrivateForwardMsg_delegate>("Va_sendPrivateForwardMsg");
            Va_sendPrivateMsg_func = Bind<Va_sendPrivateMsg_delegate>("Va_sendPrivateMsg");
            Va_setFatal_func = Bind<Va_setFatal_delegate>("Va_setFatal");
            Va_setFriendAddRequest_func = Bind<Va_setFriendAddRequest_delegate>("Va_setFriendAddRequest");
            Va_setGroupAddRequest_func = Bind<Va_setGroupAddRequest_delegate>("Va_setGroupAddRequest");
            Va_setGroupAdmin_func = Bind<Va_setGroupAdmin_delegate>("Va_setGroupAdmin");
            Va_setGroupAnonymousBan_func = Bind<Va_setGroupAnonymousBan_delegate>("Va_setGroupAnonymousBan");
            Va_setGroupAvatar_func = Bind<Va_setGroupAvatar_delegate>("Va_setGroupAvatar");
            Va_setGroupBan_func = Bind<Va_setGroupBan_delegate>("Va_setGroupBan");
            Va_setGroupCard_func = Bind<Va_setGroupCard_delegate>("Va_setGroupCard");
            Va_setGroupEssenceNews_func = Bind<Va_setGroupEssenceNews_delegate>("Va_setGroupEssenceNews");
            Va_setGroupKick_func = Bind<Va_setGroupKick_delegate>("Va_setGroupKick");
            Va_setGroupLeave_func = Bind<Va_setGroupLeave_delegate>("Va_setGroupLeave");
            Va_setGroupNewName_func = Bind<Va_setGroupNewName_delegate>("Va_setGroupNewName");
            Va_setGroupSpecialTitle_func = Bind<Va_setGroupSpecialTitle_delegate>("Va_setGroupSpecialTitle");
            Va_setGroupWholeBan_func = Bind<Va_setGroupWholeBan_delegate>("Va_setGroupWholeBan");
            Va_setModelShow_func = Bind<Va_setModelShow_delegate>("Va_setModelShow");
            Va_setQQProfile_func = Bind<Va_setQQProfile_delegate>("Va_setQQProfile");
            Va_setRestart_func = Bind<Va_setRestart_delegate>("Va_setRestart");
            Va_uploadGroupFile_func = Bind<Va_uploadGroupFile_delegate>("Va_uploadGroupFile");
            Va_uploadPrivateFile_func = Bind<Va_uploadPrivateFile_delegate>("Va_uploadPrivateFile");

        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_addLog_delegate(int AuthCode, int Priority, IntPtr Type, IntPtr Content);
        private readonly Va_addLog_delegate Va_addLog_func;
        /// <summary>
        /// 加入日志
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="Priority">优先级；#Log_ 开头常量</param>,
        /// <param name="Type">日志类型</param>,
        /// <param name="Content">日志内容</param>
        /// <returns><see cref="int"/></returns>
        public int AddLog(int Priority, string Type, string Content)
        {
            using (var Type_i = new AnsiCharPtr(Type))
            {
                using (var Content_i = new AnsiCharPtr(Content))
                {
                    return Va_addLog_func(AuthCode, Priority, Type_i, Content_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool Va_canSendImage_delegate(int AuthCode);
        private readonly Va_canSendImage_delegate Va_canSendImage_func;
        /// <summary>
        /// 是否可以发送图片
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="bool"/></returns>
        public bool CanSendImage()
        {
            return Va_canSendImage_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool Va_canSendRecord_delegate(int AuthCode);
        private readonly Va_canSendRecord_delegate Va_canSendRecord_func;
        /// <summary>
        /// 是否可以发送语音
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="bool"/></returns>
        public bool CanSendRecord()
        {
            return Va_canSendRecord_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_canSendVoice_delegate(int AuthCode);
        private readonly Va_canSendVoice_delegate Va_canSendVoice_func;
        /// <summary>
        /// 是否可以发送语音
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="int"/></returns>
        public int CanSendVoice()
        {
            return Va_canSendVoice_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_checkUrlSafety_delegate(int AuthCode, IntPtr url);
        private readonly Va_checkUrlSafety_delegate Va_checkUrlSafety_func;
        /// <summary>
        /// 查链接安全性
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="url">url</param>
        /// <returns><see cref="int"/></returns>
        public int CheckUrlSafety(string url)
        {
            using (var url_i = new AnsiCharPtr(url))
            {
                return Va_checkUrlSafety_func(AuthCode, url_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_deleteFriend_delegate(int AuthCode, long friend_id);
        private readonly Va_deleteFriend_delegate Va_deleteFriend_func;
        /// <summary>
        /// 删除好友
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="friend_id">目标账号</param>
        /// <returns><see cref="int"/></returns>
        public int DeleteFriend(long friend_id)
        {
            return Va_deleteFriend_func(AuthCode, friend_id);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_deleteMsg_delegate(int AuthCode, int MsgId);
        private readonly Va_deleteMsg_delegate Va_deleteMsg_func;
        /// <summary>
        /// 撤回消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="MsgId">消息ID</param>
        /// <returns><see cref="int"/></returns>
        public int DeleteMsg(int MsgId)
        {
            return Va_deleteMsg_func(AuthCode, MsgId);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_deleteUnidirectionalFriend_delegate(int AuthCode, long user_id);
        private readonly Va_deleteUnidirectionalFriend_delegate Va_deleteUnidirectionalFriend_func;
        /// <summary>
        /// 删除单项好友
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="user_id">目标账号</param>
        /// <returns><see cref="int"/></returns>
        public int DeleteUnidirectionalFriend(long user_id)
        {
            return Va_deleteUnidirectionalFriend_func(AuthCode, user_id);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_downloadFileCache_delegate(int AuthCode, IntPtr Url, int ThreadCount, IntPtr Headers);
        private readonly Va_downloadFileCache_delegate Va_downloadFileCache_func;
        /// <summary>
        /// 下载文件到缓存目录
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="Url">需要下载的文件链接地址</param>,
        /// <param name="ThreadCount">下载线程数</param>,
        /// <param name="Headers">自定义请求头多个用换行符分开(一行一个)</param>
        /// <returns><see cref="string"/></returns>
        public string DownloadFileCache(string Url, int ThreadCount, string Headers)
        {
            using (var Url_i = new AnsiCharPtr(Url))
            {
                using (var Headers_i = new AnsiCharPtr(Headers))
                {
                    return Marshal.PtrToStringAnsi(Va_downloadFileCache_func(AuthCode, Url_i, ThreadCount, Headers_i));
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getAppDirectory_delegate(int AuthCode);
        private readonly Va_getAppDirectory_delegate Va_getAppDirectory_func;
        /// <summary>
        /// 取应用目录(路径以  结尾)
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetAppDirectory()
        {
            return Marshal.PtrToStringAnsi(Va_getAppDirectory_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getForwardMsg_delegate(int AuthCode, int MsgId);
        private readonly Va_getForwardMsg_delegate Va_getForwardMsg_func;
        /// <summary>
        /// 获取合并转发内容
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="MsgId">根据消息ID获取消息内容</param>
        /// <returns><see cref="string"/></returns>
        public string GetForwardMsg(int MsgId)
        {
            return Marshal.PtrToStringAnsi(Va_getForwardMsg_func(AuthCode, MsgId));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getFriendList_delegate(int AuthCode);
        private readonly Va_getFriendList_delegate Va_getFriendList_func;
        /// <summary>
        /// 取好友列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetFriendList()
        {
            return Marshal.PtrToStringAnsi(Va_getFriendList_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupEssenceNews_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupEssenceNews_delegate Va_getGroupEssenceNews_func;
        /// <summary>
        /// 取群精华消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">群号</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupEssenceNews(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupEssenceNews_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupFileDownurl_delegate(int AuthCode, long 群号, IntPtr 文件ID, long Busid);
        private readonly Va_getGroupFileDownurl_delegate Va_getGroupFileDownurl_func;
        /// <summary>
        /// 取群文件链接
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="文件ID">文件ID</param>,
        /// <param name="Busid">文件Busid</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupFileDownurl(long 群号, string 文件ID, long Busid)
        {
            using (var 文件ID_i = new AnsiCharPtr(文件ID))
            {
                return Marshal.PtrToStringAnsi(Va_getGroupFileDownurl_func(AuthCode, 群号, 文件ID_i, Busid));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupHistoricalNews_delegate(int AuthCode, long 群号, int 消息SEQ);
        private readonly Va_getGroupHistoricalNews_delegate Va_getGroupHistoricalNews_func;
        /// <summary>
        /// 取群历史消息记录
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="消息SEQ">起始消息序号, 可通过 取消息信息 获取消息 获得；不提供起始序号将默认获取最新的消息</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupHistoricalNews(long 群号, int 消息SEQ)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupHistoricalNews_func(AuthCode, 群号, 消息SEQ));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupHonorInfo_delegate(int AuthCode, long group_id, IntPtr type);
        private readonly Va_getGroupHonorInfo_delegate Va_getGroupHonorInfo_func;
        /// <summary>
        /// Va_getGroupHonorInfo
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="group_id">目标群</param>,
        /// <param name="type">要获取的群荣誉类型, 可传入 talkative performer legend strong_newbie emotion</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupHonorInfo(long group_id, string type)
        {
            using (var type_i = new AnsiCharPtr(type))
            {
                return Marshal.PtrToStringAnsi(Va_getGroupHonorInfo_func(AuthCode, group_id, type_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupInfo_delegate(int AuthCode, long group_id, bool 无视缓存);
        private readonly Va_getGroupInfo_delegate Va_getGroupInfo_func;
        /// <summary>
        /// 获取群信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="group_id">目标群</param>,
        /// <param name="无视缓存">无视缓存</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupInfo(long group_id, bool 无视缓存)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupInfo_func(AuthCode, group_id, 无视缓存));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupList_delegate(int AuthCode);
        private readonly Va_getGroupList_delegate Va_getGroupList_func;
        /// <summary>
        /// 取群列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupList()
        {
            return Marshal.PtrToStringAnsi(Va_getGroupList_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupMemberInfo_delegate(int AuthCode, long 群号, long 帐号, bool 不使用缓存);
        private readonly Va_getGroupMemberInfo_delegate Va_getGroupMemberInfo_func;
        /// <summary>
        /// 取群成员信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="不使用缓存">默认为"假"，通常忽略本参数，仅在必要时使用</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupMemberInfo(long 群号, long 帐号, bool 不使用缓存)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupMemberInfo_func(AuthCode, 群号, 帐号, 不使用缓存));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupMemberList_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupMemberList_delegate Va_getGroupMemberList_func;
        /// <summary>
        /// 取群成员列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标帐号所在群</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupMemberList(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupMemberList_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupNotice_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupNotice_delegate Va_getGroupNotice_func;
        /// <summary>
        /// 取群公告
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupNotice(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupNotice_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupRootdirectoryfile_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupRootdirectoryfile_delegate Va_getGroupRootdirectoryfile_func;
        /// <summary>
        /// 取群根目录文件
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupRootdirectoryfile(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupRootdirectoryfile_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupSpaceInfo_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupSpaceInfo_delegate Va_getGroupSpaceInfo_func;
        /// <summary>
        /// 取群空间信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupSpaceInfo(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupSpaceInfo_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupSubdirectoryfile_delegate(int AuthCode, long 群号, IntPtr 文件夹ID);
        private readonly Va_getGroupSubdirectoryfile_delegate Va_getGroupSubdirectoryfile_func;
        /// <summary>
        /// 取群子目录文件
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="文件夹ID">文件夹ID</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupSubdirectoryfile(long 群号, string 文件夹ID)
        {
            using (var 文件夹ID_i = new AnsiCharPtr(文件夹ID))
            {
                return Marshal.PtrToStringAnsi(Va_getGroupSubdirectoryfile_func(AuthCode, 群号, 文件夹ID_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupSystemMsg_delegate(int AuthCode);
        private readonly Va_getGroupSystemMsg_delegate Va_getGroupSystemMsg_func;
        /// <summary>
        /// Va_getGroupSystemMsg
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupSystemMsg()
        {
            return Marshal.PtrToStringAnsi(Va_getGroupSystemMsg_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGroupTotalAtRemainingNumber_delegate(int AuthCode, long 群号);
        private readonly Va_getGroupTotalAtRemainingNumber_delegate Va_getGroupTotalAtRemainingNumber_func;
        /// <summary>
        /// 取群剩余艾特全体数
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>
        /// <returns><see cref="string"/></returns>
        public string GetGroupTotalAtRemainingNumber(long 群号)
        {
            return Marshal.PtrToStringAnsi(Va_getGroupTotalAtRemainingNumber_func(AuthCode, 群号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildChannelList_delegate(int AuthCode, IntPtr GuildId, bool 无视缓存);
        private readonly Va_getGuildChannelList_delegate Va_getGuildChannelList_func;
        /// <summary>
        /// 取子频道列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GuildId">频道ID</param>,
        /// <param name="无视缓存">是否无视缓存</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildChannelList(string GuildId, bool 无视缓存)
        {
            using (var GuildId_i = new AnsiCharPtr(GuildId))
            {
                return Marshal.PtrToStringAnsi(Va_getGuildChannelList_func(AuthCode, GuildId_i, 无视缓存));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildList_delegate(int AuthCode);
        private readonly Va_getGuildList_delegate Va_getGuildList_func;
        /// <summary>
        /// 取频道列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildList()
        {
            return Marshal.PtrToStringAnsi(Va_getGuildList_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildMemberList_delegate(int AuthCode, IntPtr GuildId, IntPtr NextToken);
        private readonly Va_getGuildMemberList_delegate Va_getGuildMemberList_func;
        /// <summary>
        /// 取频道成员列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GuildId">频道ID</param>,
        /// <param name="NextToken">翻页Token；为空的情况下, 将返回第一页的数据, 并在返回值附带下一页的Token</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildMemberList(string GuildId, string NextToken)
        {
            using (var GuildId_i = new AnsiCharPtr(GuildId))
            {
                using (var NextToken_i = new AnsiCharPtr(NextToken))
                {
                    return Marshal.PtrToStringAnsi(Va_getGuildMemberList_func(AuthCode, GuildId_i, NextToken_i));
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildMemberProfile_delegate(int AuthCode, IntPtr GuildId, IntPtr UserId);
        private readonly Va_getGuildMemberProfile_delegate Va_getGuildMemberProfile_func;
        /// <summary>
        /// 单独取频道成员信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GuildId">频道ID</param>,
        /// <param name="UserId">用户ID(tiny_id)</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildMemberProfile(string GuildId, string UserId)
        {
            using (var GuildId_i = new AnsiCharPtr(GuildId))
            {
                using (var UserId_i = new AnsiCharPtr(UserId))
                {
                    return Marshal.PtrToStringAnsi(Va_getGuildMemberProfile_func(AuthCode, GuildId_i, UserId_i));
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildMetaByGuest_delegate(int AuthCode, IntPtr GuildId);
        private readonly Va_getGuildMetaByGuest_delegate Va_getGuildMetaByGuest_func;
        /// <summary>
        /// 通过访客取频道元数据
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GuildId">频道ID</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildMetaByGuest(string GuildId)
        {
            using (var GuildId_i = new AnsiCharPtr(GuildId))
            {
                return Marshal.PtrToStringAnsi(Va_getGuildMetaByGuest_func(AuthCode, GuildId_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getGuildServiceProfile_delegate(int AuthCode);
        private readonly Va_getGuildServiceProfile_delegate Va_getGuildServiceProfile_func;
        /// <summary>
        /// 取频道系统内BOT的资料
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetGuildServiceProfile()
        {
            return Marshal.PtrToStringAnsi(Va_getGuildServiceProfile_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getImageInfo_delegate(int AuthCode, IntPtr 图片缓存名);
        private readonly Va_getImageInfo_delegate Va_getImageInfo_func;
        /// <summary>
        /// 取图片信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="图片缓存名">如:0cb08e32204e32c41c73d7fee0633427.image</param>
        /// <returns><see cref="string"/></returns>
        public string GetImageInfo(string 图片缓存名)
        {
            using (var 图片缓存名_i = new AnsiCharPtr(图片缓存名))
            {
                return Marshal.PtrToStringAnsi(Va_getImageInfo_func(AuthCode, 图片缓存名_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getLoginNick_delegate(int AuthCode);
        private readonly Va_getLoginNick_delegate Va_getLoginNick_func;
        /// <summary>
        /// 取登录昵称
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetLoginNick()
        {
            return Marshal.PtrToStringAnsi(Va_getLoginNick_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate long Va_getLoginQQ_delegate(int AuthCode);
        private readonly Va_getLoginQQ_delegate Va_getLoginQQ_func;
        /// <summary>
        /// 取登录账号
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="long"/></returns>
        public long GetLoginQQ()
        {
            return Va_getLoginQQ_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getMessageInfo_delegate(int AuthCode, int MsgId);
        private readonly Va_getMessageInfo_delegate Va_getMessageInfo_func;
        /// <summary>
        /// 取消息信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="MsgId">根据消息ID获取消息内容</param>
        /// <returns><see cref="string"/></returns>
        public string GetMessageInfo(int MsgId)
        {
            return Marshal.PtrToStringAnsi(Va_getMessageInfo_func(AuthCode, MsgId));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getModelShow_delegate(int AuthCode, IntPtr model);
        private readonly Va_getModelShow_delegate Va_getModelShow_func;
        /// <summary>
        /// 获取在线机型
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="model">机型名称</param>
        /// <returns><see cref="string"/></returns>
        public string GetModelShow(string model)
        {
            using (var model_i = new AnsiCharPtr(model))
            {
                return Marshal.PtrToStringAnsi(Va_getModelShow_func(AuthCode, model_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getQidianAccountInfo_delegate(int AuthCode);
        private readonly Va_getQidianAccountInfo_delegate Va_getQidianAccountInfo_func;
        /// <summary>
        /// Va_getQidianAccountInfo
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetQidianAccountInfo()
        {
            return Marshal.PtrToStringAnsi(Va_getQidianAccountInfo_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getRecordV2_delegate(int AuthCode, IntPtr 文件名, IntPtr 指定格式);
        private readonly Va_getRecordV2_delegate Va_getRecordV2_func;
        /// <summary>
        /// 接收语音
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="文件名">收到消息中的语音文件名(file)</param>,
        /// <param name="指定格式">应用所需的语音文件格式，目前支持 mp3,amr,wma,m4a,spx,ogg,wav,flac</param>
        /// <returns><see cref="string"/></returns>
        public string GetRecordV2(string 文件名, string 指定格式)
        {
            using (var 文件名_i = new AnsiCharPtr(文件名))
            {
                using (var 指定格式_i = new AnsiCharPtr(指定格式))
                {
                    return Marshal.PtrToStringAnsi(Va_getRecordV2_func(AuthCode, 文件名_i, 指定格式_i));
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getRobotInfo_delegate(int AuthCode);
        private readonly Va_getRobotInfo_delegate Va_getRobotInfo_func;
        /// <summary>
        /// 取登录号信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetRobotInfo()
        {
            return Marshal.PtrToStringAnsi(Va_getRobotInfo_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getRobotOnlineDevice_delegate(int AuthCode, bool 无视缓存);
        private readonly Va_getRobotOnlineDevice_delegate Va_getRobotOnlineDevice_func;
        /// <summary>
        /// 取Bot在线设备
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="无视缓存">默认为假</param>
        /// <returns><see cref="string"/></returns>
        public string GetRobotOnlineDevice(bool 无视缓存)
        {
            return Marshal.PtrToStringAnsi(Va_getRobotOnlineDevice_func(AuthCode, 无视缓存));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getRunState_delegate(int AuthCode);
        private readonly Va_getRunState_delegate Va_getRunState_func;
        /// <summary>
        /// 取运行状态
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetRunState()
        {
            return Marshal.PtrToStringAnsi(Va_getRunState_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate long Va_getRunTime_delegate(int AuthCode);
        private readonly Va_getRunTime_delegate Va_getRunTime_func;
        /// <summary>
        /// 取已登录时长
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="long"/></returns>
        public long GetRunTime()
        {
            return Va_getRunTime_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getStrangerInfo_delegate(int AuthCode, long 账号, bool 不使用缓存);
        private readonly Va_getStrangerInfo_delegate Va_getStrangerInfo_func;
        /// <summary>
        /// 取陌生人信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="账号">目标QQ</param>,
        /// <param name="不使用缓存">是否不使用缓存（使用缓存可能更新不及时，但响应更快）</param>
        /// <returns><see cref="string"/></returns>
        public string GetStrangerInfo(long 账号, bool 不使用缓存)
        {
            return Marshal.PtrToStringAnsi(Va_getStrangerInfo_func(AuthCode, 账号, 不使用缓存));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getUnidirectionalFriendList_delegate(int AuthCode);
        private readonly Va_getUnidirectionalFriendList_delegate Va_getUnidirectionalFriendList_func;
        /// <summary>
        /// 取单项好友列表
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetUnidirectionalFriendList()
        {
            return Marshal.PtrToStringAnsi(Va_getUnidirectionalFriendList_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getUserVipInfo_delegate(int AuthCode, long 账号);
        private readonly Va_getUserVipInfo_delegate Va_getUserVipInfo_func;
        /// <summary>
        /// 取用户VIP信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="账号">目标QQ</param>
        /// <returns><see cref="string"/></returns>
        public string GetUserVipInfo(long 账号)
        {
            return Marshal.PtrToStringAnsi(Va_getUserVipInfo_func(AuthCode, 账号));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getVersion_delegate(int AuthCode);
        private readonly Va_getVersion_delegate Va_getVersion_func;
        /// <summary>
        /// 取版本信息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="string"/></returns>
        public string GetVersion()
        {
            return Marshal.PtrToStringAnsi(Va_getVersion_func(AuthCode));
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_getWordSlices_delegate(int AuthCode, IntPtr content);
        private readonly Va_getWordSlices_delegate Va_getWordSlices_func;
        /// <summary>
        /// 取中文分词
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="content">欲被分词的文本</param>
        /// <returns><see cref="string"/></returns>
        public string GetWordSlices(string content)
        {
            using (var content_i = new AnsiCharPtr(content))
            {
                return Marshal.PtrToStringAnsi(Va_getWordSlices_func(AuthCode, content_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_HandleQuickOperation_delegate(int AuthCode, IntPtr context, IntPtr operation);
        private readonly Va_HandleQuickOperation_delegate Va_HandleQuickOperation_func;
        /// <summary>
        /// Va_HandleQuickOperation
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="context">事件数据对象, 可做精简, 如去掉 message 等无用字段</param>,
        /// <param name="operation">快速操作对象, 例如 {"ban": true, "reply": "请不要说脏话"}</param>
        /// <returns><see cref="int"/></returns>
        public int HandleQuickOperation(string context, string operation)
        {
            using (var context_i = new AnsiCharPtr(context))
            {
                using (var operation_i = new AnsiCharPtr(operation))
                {
                    return Va_HandleQuickOperation_func(AuthCode, context_i, operation_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_ocrImage_delegate(int AuthCode, IntPtr imageId);
        private readonly Va_ocrImage_delegate Va_ocrImage_func;
        /// <summary>
        /// Va_ocrImage
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="imageId">图片ID</param>
        /// <returns><see cref="string"/></returns>
        public string OcrImage(string imageId)
        {
            using (var imageId_i = new AnsiCharPtr(imageId))
            {
                return Marshal.PtrToStringAnsi(Va_ocrImage_func(AuthCode, imageId_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool Va_overloadEventFilter_delegate(int AuthCode);
        private readonly Va_overloadEventFilter_delegate Va_overloadEventFilter_func;
        /// <summary>
        /// 重载事件过滤器
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>
        /// <returns><see cref="bool"/></returns>
        public bool OverloadEventFilter()
        {
            return Va_overloadEventFilter_func(AuthCode);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendForwardMsg_delegate(int AuthCode, int MsgType, long AimsId, IntPtr Messages);
        private readonly Va_sendForwardMsg_delegate Va_sendForwardMsg_func;
        /// <summary>
        /// 发送合并转发消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="MsgType">1为好友；2为群组；</param>,
        /// <param name="AimsId">目标ID；若发送群消息则填写群号反之填写QQ帐号</param>,
        /// <param name="Messages">自定义转发消息, 具体看</param>
        /// <returns><see cref="int"/></returns>
        public int SendForwardMsg(int MsgType, long AimsId, string Messages)
        {
            using (var Messages_i = new AnsiCharPtr(Messages))
            {
                return Va_sendForwardMsg_func(AuthCode, MsgType, AimsId, Messages_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_sendForwardMsgCom_delegate(IntPtr Name, IntPtr Uin, IntPtr Content, IntPtr Seq, IntPtr Time);
        private readonly Va_sendForwardMsgCom_delegate Va_sendForwardMsgCom_func;
        /// <summary>
        /// _置自定义消息_复杂
        /// </summary>
        /// <param name="Name">发送者显示名字</param>,
        /// <param name="Uin">发送者QQ号</param>,
        /// <param name="Content">消息内容</param>,
        /// <param name="Seq">具体消息</param>,
        /// <param name="Time">发送时间戳</param>
        /// <returns><see cref="string"/></returns>
        public string SendForwardMsgCom(string Name, string Uin, string Content, string Seq, string Time)
        {
            using (var Name_i = new AnsiCharPtr(Name))
            {
                using (var Uin_i = new AnsiCharPtr(Uin))
                {
                    using (var Content_i = new AnsiCharPtr(Content))
                    {
                        using (var Seq_i = new AnsiCharPtr(Seq))
                        {
                            using (var Time_i = new AnsiCharPtr(Time))
                            {
                                return Marshal.PtrToStringAnsi(Va_sendForwardMsgCom_func(Name_i, Uin_i, Content_i, Seq_i, Time_i));
                            }
                        }
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_sendForwardMsgGen_delegate(IntPtr Name, IntPtr Uin, IntPtr Type, IntPtr Text);
        private readonly Va_sendForwardMsgGen_delegate Va_sendForwardMsgGen_func;
        /// <summary>
        /// _置自定义消息_一般
        /// </summary>
        /// <param name="Name">发送者显示名字</param>,
        /// <param name="Uin">发送者QQ号</param>,
        /// <param name="Type">消息类型</param>,
        /// <param name="Text">消息内容/表情ID</param>
        /// <returns><see cref="string"/></returns>
        public string SendForwardMsgGen(string Name, string Uin, string Type, string Text)
        {
            using (var Name_i = new AnsiCharPtr(Name))
            {
                using (var Uin_i = new AnsiCharPtr(Uin))
                {
                    using (var Type_i = new AnsiCharPtr(Type))
                    {
                        using (var Text_i = new AnsiCharPtr(Text))
                        {
                            return Marshal.PtrToStringAnsi(Va_sendForwardMsgGen_func(Name_i, Uin_i, Type_i, Text_i));
                        }
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_sendForwardMsgId_delegate(IntPtr MsgId);
        private readonly Va_sendForwardMsgId_delegate Va_sendForwardMsgId_func;
        /// <summary>
        /// _置消息ID
        /// </summary>
        /// <param name="MsgId">转发消息id</param>
        /// <returns><see cref="string"/></returns>
        public string SendForwardMsgId(string MsgId)
        {
            using (var MsgId_i = new AnsiCharPtr(MsgId))
            {
                return Marshal.PtrToStringAnsi(Va_sendForwardMsgId_func(MsgId_i));
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_sendForwardMsgSim_delegate(IntPtr Name, IntPtr Uin, IntPtr Content);
        private readonly Va_sendForwardMsgSim_delegate Va_sendForwardMsgSim_func;
        /// <summary>
        /// _置自定义消息_简单
        /// </summary>
        /// <param name="Name">发送者显示名字</param>,
        /// <param name="Uin">发送者QQ号</param>,
        /// <param name="Content">消息内容</param>
        /// <returns><see cref="string"/></returns>
        public string SendForwardMsgSim(string Name, string Uin, string Content)
        {
            using (var Name_i = new AnsiCharPtr(Name))
            {
                using (var Uin_i = new AnsiCharPtr(Uin))
                {
                    using (var Content_i = new AnsiCharPtr(Content))
                    {
                        return Marshal.PtrToStringAnsi(Va_sendForwardMsgSim_func(Name_i, Uin_i, Content_i));
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendGroupForwardMsg_delegate(int AuthCode, long GroupId, IntPtr Messages);
        private readonly Va_sendGroupForwardMsg_delegate Va_sendGroupForwardMsg_func;
        /// <summary>
        /// 发送合并转发消息【群】
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GroupId">群号</param>,
        /// <param name="Messages">自定义转发消息, 具体看</param>
        /// <returns><see cref="int"/></returns>
        public int SendGroupForwardMsg(long GroupId, string Messages)
        {
            using (var Messages_i = new AnsiCharPtr(Messages))
            {
                return Va_sendGroupForwardMsg_func(AuthCode, GroupId, Messages_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendGroupMsg_delegate(int AuthCode, long GroupId, IntPtr msg, bool 不解析CQ码);
        private readonly Va_sendGroupMsg_delegate Va_sendGroupMsg_func;
        /// <summary>
        /// 发送群消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GroupId">目标群号</param>,
        /// <param name="msg">要发送的群消息</param>,
        /// <param name="不解析CQ码">可空；消息内容是否作为纯文本发送(即不解析CQ码)</param>
        /// <returns><see cref="int"/></returns>
        public int SendGroupMsg(long GroupId, string msg, bool 不解析CQ码)
        {
            using (var msg_i = new AnsiCharPtr(msg))
            {
                return Va_sendGroupMsg_func(AuthCode, GroupId, msg_i, 不解析CQ码);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendGroupNotice_delegate(int AuthCode, long GroupId, IntPtr Notice, IntPtr Image);
        private readonly Va_sendGroupNotice_delegate Va_sendGroupNotice_func;
        /// <summary>
        /// 发群公告
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GroupId">群号</param>,
        /// <param name="Notice">公告内容</param>,
        /// <param name="Image">公告图片如:/abc.png</param>
        /// <returns><see cref="int"/></returns>
        public int SendGroupNotice(long GroupId, string Notice, string Image)
        {
            using (var Notice_i = new AnsiCharPtr(Notice))
            {
                using (var Image_i = new AnsiCharPtr(Image))
                {
                    return Va_sendGroupNotice_func(AuthCode, GroupId, Notice_i, Image_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendGroupTemporaryMsg_delegate(int AuthCode, long QQId, long GroupId, IntPtr msg, bool 不解析CQ码);
        private readonly Va_sendGroupTemporaryMsg_delegate Va_sendGroupTemporaryMsg_func;
        /// <summary>
        /// Va_sendGroupTemporaryMsg
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="QQId">目标账号</param>,
        /// <param name="GroupId">目标群号</param>,
        /// <param name="msg">要发送的群消息</param>,
        /// <param name="不解析CQ码">可空；消息内容是否作为纯文本发送(即不解析CQ码)</param>
        /// <returns><see cref="int"/></returns>
        public int SendGroupTemporaryMsg(long QQId, long GroupId, string msg, bool 不解析CQ码)
        {
            using (var msg_i = new AnsiCharPtr(msg))
            {
                return Va_sendGroupTemporaryMsg_func(AuthCode, QQId, GroupId, msg_i, 不解析CQ码);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr Va_sendGuildChannelMsg_delegate(int AuthCode, IntPtr GuildId, IntPtr ChannelId, IntPtr Message);
        private readonly Va_sendGuildChannelMsg_delegate Va_sendGuildChannelMsg_func;
        /// <summary>
        /// 发子频道消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="GuildId">频道ID</param>,
        /// <param name="ChannelId">子频道ID</param>,
        /// <param name="Message">消息, 与原有消息类型相同</param>
        /// <returns><see cref="string"/></returns>
        public string SendGuildChannelMsg(string GuildId, string ChannelId, string Message)
        {
            using (var GuildId_i = new AnsiCharPtr(GuildId))
            {
                using (var ChannelId_i = new AnsiCharPtr(ChannelId))
                {
                    using (var Message_i = new AnsiCharPtr(Message))
                    {
                        return Marshal.PtrToStringAnsi(Va_sendGuildChannelMsg_func(AuthCode, GuildId_i, ChannelId_i, Message_i));
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendMsg_delegate(int AuthCode, int MsgType, long AimsId, IntPtr Msg, bool 不解析CQ码);
        private readonly Va_sendMsg_delegate Va_sendMsg_func;
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="MsgType">1为好友；2为群组；</param>,
        /// <param name="AimsId">目标ID；若发送群消息则填写群号反之填写QQ账号</param>,
        /// <param name="Msg">要发送的内容</param>,
        /// <param name="不解析CQ码">可空；消息内容是否作为纯文本发送(即不解析CQ码)；</param>
        /// <returns><see cref="int"/></returns>
        public int SendMsg(int MsgType, long AimsId, string Msg, bool 不解析CQ码)
        {
            using (var Msg_i = new AnsiCharPtr(Msg))
            {
                return Va_sendMsg_func(AuthCode, MsgType, AimsId, Msg_i, 不解析CQ码);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendPrivateForwardMsg_delegate(int AuthCode, long UserId, IntPtr Messages);
        private readonly Va_sendPrivateForwardMsg_delegate Va_sendPrivateForwardMsg_func;
        /// <summary>
        /// 发送合并转发消息【私】
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="UserId">QQ帐号</param>,
        /// <param name="Messages">自定义转发消息, 具体看</param>
        /// <returns><see cref="int"/></returns>
        public int SendPrivateForwardMsg(long UserId, string Messages)
        {
            using (var Messages_i = new AnsiCharPtr(Messages))
            {
                return Va_sendPrivateForwardMsg_func(AuthCode, UserId, Messages_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_sendPrivateMsg_delegate(int AuthCode, long QQId, IntPtr msg, bool 不解析CQ码);
        private readonly Va_sendPrivateMsg_delegate Va_sendPrivateMsg_func;
        /// <summary>
        /// 发送私聊消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="QQId">目标帐号</param>,
        /// <param name="msg">要发送的群消息</param>,
        /// <param name="不解析CQ码">可空；消息内容是否作为纯文本发送(即不解析CQ码)</param>
        /// <returns><see cref="int"/></returns>
        public int SendPrivateMsg(long QQId, string msg, bool 不解析CQ码)
        {
            using (var msg_i = new AnsiCharPtr(msg))
            {
                return Va_sendPrivateMsg_func(AuthCode, QQId, msg_i, 不解析CQ码);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setFatal_delegate(int AuthCode, IntPtr Content);
        private readonly Va_setFatal_delegate Va_setFatal_func;
        /// <summary>
        /// 加入致命错误日志
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="Content">日志内容</param>
        /// <returns><see cref="int"/></returns>
        public int SetFatal(string Content)
        {
            using (var Content_i = new AnsiCharPtr(Content))
            {
                return Va_setFatal_func(AuthCode, Content_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setFriendAddRequest_delegate(int AuthCode, IntPtr 请求反馈标识, int 反馈类型, IntPtr 好友备注);
        private readonly Va_setFriendAddRequest_delegate Va_setFriendAddRequest_func;
        /// <summary>
        /// 置好友添加请求
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数。</param>,
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝。</param>,
        /// <param name="好友备注">添加后的好友备注（仅在同意时有效）</param>
        /// <returns><see cref="int"/></returns>
        public int SetFriendAddRequest(string 请求反馈标识, int 反馈类型, string 好友备注)
        {
            using (var 请求反馈标识_i = new AnsiCharPtr(请求反馈标识))
            {
                using (var 好友备注_i = new AnsiCharPtr(好友备注))
                {
                    return Va_setFriendAddRequest_func(AuthCode, 请求反馈标识_i, 反馈类型, 好友备注_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupAddRequest_delegate(int AuthCode, IntPtr 请求反馈标识, int 请求类型, int 反馈类型, IntPtr 拒绝理由);
        private readonly Va_setGroupAddRequest_delegate Va_setGroupAddRequest_func;
        /// <summary>
        /// 置群添加请求
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="请求反馈标识">请求事件收到的“反馈标识”参数。</param>,
        /// <param name="请求类型">根据请求事件的子类型区分 #请求_群添加 或 #请求_群邀请。</param>,
        /// <param name="反馈类型">#请求_通过 或 #请求_拒绝。</param>,
        /// <param name="拒绝理由">拒绝理由（仅在拒绝时有效）</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupAddRequest(string 请求反馈标识, int 请求类型, int 反馈类型, string 拒绝理由)
        {
            using (var 请求反馈标识_i = new AnsiCharPtr(请求反馈标识))
            {
                using (var 拒绝理由_i = new AnsiCharPtr(拒绝理由))
                {
                    return Va_setGroupAddRequest_func(AuthCode, 请求反馈标识_i, 请求类型, 反馈类型, 拒绝理由_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupAdmin_delegate(int AuthCode, long 群号, long 帐号, bool 成为管理员);
        private readonly Va_setGroupAdmin_delegate Va_setGroupAdmin_func;
        /// <summary>
        /// 置群管理员
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="成为管理员">真/设置管理员 假/取消管理员</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupAdmin(long 群号, long 帐号, bool 成为管理员)
        {
            return Va_setGroupAdmin_func(AuthCode, 群号, 帐号, 成为管理员);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupAnonymousBan_delegate(int AuthCode, long 群号, IntPtr 匿名, long 禁言时间);
        private readonly Va_setGroupAnonymousBan_delegate Va_setGroupAnonymousBan_func;
        /// <summary>
        /// 置匿名群员禁言
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="匿名">群消息事件收到的“匿名”参数</param>,
        /// <param name="禁言时间">禁言的时间，单位为秒。不支持解禁</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupAnonymousBan(long 群号, string 匿名, long 禁言时间)
        {
            using (var 匿名_i = new AnsiCharPtr(匿名))
            {
                return Va_setGroupAnonymousBan_func(AuthCode, 群号, 匿名_i, 禁言时间);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupAvatar_delegate(int AuthCode, long 群号, IntPtr 图片, bool 使用缓存);
        private readonly Va_setGroupAvatar_delegate Va_setGroupAvatar_func;
        /// <summary>
        /// 置群头像
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="图片">图片绝对路径；本地文件：C:Users.png 或URL：https://www.baidu.com/1.png 或Base64编码后的图片</param>,
        /// <param name="使用缓存">表示是否使用已缓存的文件</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupAvatar(long 群号, string 图片, bool 使用缓存)
        {
            using (var 图片_i = new AnsiCharPtr(图片))
            {
                return Va_setGroupAvatar_func(AuthCode, 群号, 图片_i, 使用缓存);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupBan_delegate(int AuthCode, long 群号, long 帐号, long 禁言时间);
        private readonly Va_setGroupBan_delegate Va_setGroupBan_func;
        /// <summary>
        /// 置群员禁言
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="禁言时间">禁言的时间，单位为秒。如果要解禁，这里填写0</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupBan(long 群号, long 帐号, long 禁言时间)
        {
            return Va_setGroupBan_func(AuthCode, 群号, 帐号, 禁言时间);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupCard_delegate(int AuthCode, long 群号, long 帐号, IntPtr 名片);
        private readonly Va_setGroupCard_delegate Va_setGroupCard_func;
        /// <summary>
        /// 置群员名片
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="名片">新群名片,为空则不设设置名片</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupCard(long 群号, long 帐号, string 名片)
        {
            using (var 名片_i = new AnsiCharPtr(名片))
            {
                return Va_setGroupCard_func(AuthCode, 群号, 帐号, 名片_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupEssenceNews_delegate(int AuthCode, int 消息ID, bool 设为精华消息);
        private readonly Va_setGroupEssenceNews_delegate Va_setGroupEssenceNews_func;
        /// <summary>
        /// 置群精华消息
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="消息ID">消息ID</param>,
        /// <param name="设为精华消息">可空；默认为真；真为设置精华消息，假为移除</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupEssenceNews(int 消息ID, bool 设为精华消息)
        {
            return Va_setGroupEssenceNews_func(AuthCode, 消息ID, 设为精华消息);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupKick_delegate(int AuthCode, long 群号, long 帐号, bool 拒绝再加群);
        private readonly Va_setGroupKick_delegate Va_setGroupKick_func;
        /// <summary>
        /// 置群员移除
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="拒绝再加群">如果为真，则“不再接收此人加群申请”，请慎用。留空为假</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupKick(long 群号, long 帐号, bool 拒绝再加群)
        {
            return Va_setGroupKick_func(AuthCode, 群号, 帐号, 拒绝再加群);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupLeave_delegate(int AuthCode, long 群号, bool 是否解散);
        private readonly Va_setGroupLeave_delegate Va_setGroupLeave_func;
        /// <summary>
        /// 置群退出
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="是否解散">默认为假 真/解散本群(群主) 假/退出本群(管理、群成员)</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupLeave(long 群号, bool 是否解散)
        {
            return Va_setGroupLeave_func(AuthCode, 群号, 是否解散);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupNewName_delegate(int AuthCode, long 群号, IntPtr 群名称);
        private readonly Va_setGroupNewName_delegate Va_setGroupNewName_func;
        /// <summary>
        /// 置群新名称
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="群名称">新的群名称</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupNewName(long 群号, string 群名称)
        {
            using (var 群名称_i = new AnsiCharPtr(群名称))
            {
                return Va_setGroupNewName_func(AuthCode, 群号, 群名称_i);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupSpecialTitle_delegate(int AuthCode, long 群号, long 帐号, IntPtr 头衔, long 过期时间);
        private readonly Va_setGroupSpecialTitle_delegate Va_setGroupSpecialTitle_func;
        /// <summary>
        /// 置群成员专属头衔
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="帐号">目标帐号</param>,
        /// <param name="头衔">如果要删除，这里填空</param>,
        /// <param name="过期时间">专属头衔有效期，单位为秒。如果永久有效，这里填写-1</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupSpecialTitle(long 群号, long 帐号, string 头衔, long 过期时间)
        {
            using (var 头衔_i = new AnsiCharPtr(头衔))
            {
                return Va_setGroupSpecialTitle_func(AuthCode, 群号, 帐号, 头衔_i, 过期时间);
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setGroupWholeBan_delegate(int AuthCode, long 群号, bool 开启禁言);
        private readonly Va_setGroupWholeBan_delegate Va_setGroupWholeBan_func;
        /// <summary>
        /// 置全群禁言
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="群号">目标群</param>,
        /// <param name="开启禁言">真/开启 假/关闭</param>
        /// <returns><see cref="int"/></returns>
        public int SetGroupWholeBan(long 群号, bool 开启禁言)
        {
            return Va_setGroupWholeBan_func(AuthCode, 群号, 开启禁言);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setModelShow_delegate(int AuthCode, IntPtr model, IntPtr model_show);
        private readonly Va_setModelShow_delegate Va_setModelShow_func;
        /// <summary>
        /// 设置在线机型
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="model">机型名称</param>,
        /// <param name="model_show">自定义文字</param>
        /// <returns><see cref="int"/></returns>
        public int SetModelShow(string model, string model_show)
        {
            using (var model_i = new AnsiCharPtr(model))
            {
                using (var model_show_i = new AnsiCharPtr(model_show))
                {
                    return Va_setModelShow_func(AuthCode, model_i, model_show_i);
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_setQQProfile_delegate(int AuthCode, IntPtr nickname, IntPtr company, IntPtr email, IntPtr college, IntPtr personalNote);
        private readonly Va_setQQProfile_delegate Va_setQQProfile_func;
        /// <summary>
        /// Va_setQQProfile
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="nickname">昵称；</param>,
        /// <param name="company">公司；</param>,
        /// <param name="email">邮箱；</param>,
        /// <param name="college">学院；</param>,
        /// <param name="personalNote">个人笔记；</param>
        /// <returns><see cref="int"/></returns>
        public int SetQQProfile(string nickname, string company, string email, string college, string personalNote)
        {
            using (var nickname_i = new AnsiCharPtr(nickname))
            {
                using (var company_i = new AnsiCharPtr(company))
                {
                    using (var email_i = new AnsiCharPtr(email))
                    {
                        using (var college_i = new AnsiCharPtr(college))
                        {
                            using (var personalNote_i = new AnsiCharPtr(personalNote))
                            {
                                return Va_setQQProfile_func(AuthCode, nickname_i, company_i, email_i, college_i, personalNote_i);
                            }
                        }
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool Va_setRestart_delegate(int AuthCode, int delay);
        private readonly Va_setRestart_delegate Va_setRestart_func;
        /// <summary>
        /// 重启GOCQ
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="delay">要延迟的毫秒数, 默认0, 如果默认情况下无法重启, 可以尝试设置延迟为 2000 左右</param>
        /// <returns><see cref="bool"/></returns>
        public bool SetRestart(int delay)
        {
            return Va_setRestart_func(AuthCode, delay);
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_uploadGroupFile_delegate(int AuthCode, long group_id, IntPtr file, IntPtr name, IntPtr folder);
        private readonly Va_uploadGroupFile_delegate Va_uploadGroupFile_func;
        /// <summary>
        /// 上传群文件
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="group_id">群号</param>,
        /// <param name="file">本地文件路径</param>,
        /// <param name="name">储存名称</param>,
        /// <param name="folder">父目录ID</param>
        /// <returns><see cref="int"/></returns>
        public int UploadGroupFile(long group_id, string file, string name, string folder)
        {
            using (var file_i = new AnsiCharPtr(file))
            {
                using (var name_i = new AnsiCharPtr(name))
                {
                    using (var folder_i = new AnsiCharPtr(folder))
                    {
                        return Va_uploadGroupFile_func(AuthCode, group_id, file_i, name_i, folder_i);
                    }
                }
            }
        }
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int Va_uploadPrivateFile_delegate(int AuthCode, long QQID, IntPtr file, IntPtr name);
        private readonly Va_uploadPrivateFile_delegate Va_uploadPrivateFile_func;
        /// <summary>
        /// 发送私聊文件
        /// </summary>
        /// <param name="AuthCode">AuthCode</param>,
        /// <param name="QQID">QQ号</param>,
        /// <param name="file">本地文件路径</param>,
        /// <param name="name">发送文件名称</param>
        /// <returns><see cref="int"/></returns>
        public int UploadPrivateFile(long QQID, string file, string name)
        {
            using (var file_i = new AnsiCharPtr(file))
            {
                using (var name_i = new AnsiCharPtr(name))
                {
                    return Va_uploadPrivateFile_func(AuthCode, QQID, file_i, name_i);
                }
            }
        }

    }
}