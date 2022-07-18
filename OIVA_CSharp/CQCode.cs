//说明：本文件翻译自OIVA官方的易语言SDK
//怎么翻译的？
//    易语言SDK相关内容复制过来，开启Copilot，一顿Tab就好了
//    完全没过脑子，都是AI补全的，可能会有些问题
//    如果真的有什么问题，请自行修改或建议反馈给作者或Github仓库提交pr
//https://github.com/LazuliKao/OIVA_CSharpSDK/tree/main/OIVA_CSharp
namespace OIVA_CSharp
{
    internal static class CQCode
    {
        //.子程序 CQ码_At, 文本型, 公开, @某人(at)
        //.参数 帐号, 长整数型, , -1 为全体
        //.参数 昵称, 文本型, 可空, 可空; 当在群中找不到此QQ号的名称时才会生效
        //.参数 At后不加空格, 逻辑型, 可空, 可空; 默认为假 At后添加空格, 可使At更规范美观. 如果不需要添加空格, 请置本参数为真
        //.局部变量 par, 文本型

        //par ＝ “,qq=” ＋ iif(帐号 ＝ -1, “all”, str (帐号))
        //.if (not (IsMissing (昵称)))
        //    par ＝ par ＋ “,name=” ＋ 昵称
        //.如果真结束
        //return (“[CQ: at” ＋ par ＋ “]” ＋ iif(At后不加空格, “”, “ ”))
        public static string At(long 帐号, string 昵称 = null, bool At后不加空格 = false)
        {
            string par = ",qq=" + (帐号 == -1 ? "all" : 帐号.ToString());
            if (昵称 is null)
                par += ",name=" + 昵称;
            return $"[CQ:at,{par}]" + (At后不加空格 ? "" : " ");
        }

        //.子程序 CQ码_At_子频道, 文本型, 公开, 该CQ码正在测试，可能不会生效
        //.参数 帐号, 文本型, , all 为全体
        //.参数 昵称, 文本型, 可空, 可空; 当在群中找不到此QQ号的名称时才会生效
        //.参数 At后不加空格, 逻辑型, 可空, 可空; 默认为假 At后添加空格, 可使At更规范美观. 如果不需要添加空格, 请置本参数为真
        //.局部变量 par, 文本型

        //par ＝ “,qq=” ＋ 帐号
        //.if (not (IsMissing (昵称)))
        //    par ＝ par ＋ “,name=” ＋ 昵称
        //.如果真结束
        //par ＝ par ＋ iif(At后不加空格, “”, “ ”)
        //return (“[CQ: at” ＋ par ＋ “]”)

        public static string At_子频道(long 帐号, string 昵称 = null, bool At后不加空格 = false)
        {
            string par = ",qq=" + 帐号;
            if (昵称 is null)
                par += ",name=" + 昵称;
            par += (At后不加空格 ? "" : " ");
            return $"[CQ:at,{par}]";
        }

        //.子程序 CQ码_cardimage, 文本型, 公开, 一种xml的图片消息(装逼大图), xml 接口的消息都存在风控风险, 请自行兼容发送失败后的处理
        //.参数 file, 文本型, , 支持http和本地文件；同CQ图片
        //.参数 minwidth, 整数型, 可空, 可空; 默认不填为400, 最小width
        //.参数 minheight, 整数型, 可空, 可空; 默认不填为400，最小height
        //.参数 maxwidth, 整数型, 可空, 可空; 默认不填为500，最大width
        //.参数 maxheight, 整数型, 可空, 可空; 默认不填为1000，最大height
        //.参数 source, 文本型, 可空, 可空; 分享来源的名称，可以留空
        //.参数 icon, 文本型, 可空, 可空; 分享来源的icon图标url，可以留空
        //.局部变量 par, 文本型

        //.判断开始(left (file, 4) ＝ “http”)
        //    par ＝ “,file=” ＋ file
        //.默认
        //    par ＝ “, file = file:///” ＋ CQ码_转义 (file)
        //.判断结束
        //.if (not (IsMissing (minwidth)))
        //    par ＝ par ＋ “,minwidth=” ＋ str(minwidth)
        //.如果真结束
        //.if (not (IsMissing (minheight)))
        //    par ＝ par ＋ “,minheight=” ＋ str(minheight)
        //.如果真结束
        //.if (not (IsMissing (maxwidth)))
        //    par ＝ par ＋ “,maxwidth=” ＋ str(maxwidth)
        //.如果真结束
        //.if (not (IsMissing (maxheight)))
        //    par ＝ par ＋ “,maxheight=” ＋ str(maxheight)
        //.如果真结束
        //.if (not (IsMissing (source)))
        //    par ＝ par ＋ “,source=” ＋ str(source)
        //.如果真结束
        //.if (not (IsMissing (icon)))
        //    par ＝ par ＋ “,icon=” ＋ str(icon)
        //.如果真结束
        //' file ＝ “file:///” ＋ 子文本替换 (file, “/”, “\”, , , 真)
        //' file ＝ 编码_URL编码 (file, 真, 真)
        //return (“[CQ: cardimage” ＋ par ＋ “]”)

        public static string CQ码_cardimage(string file, int minwidth = 400, int minheight = 400, int maxwidth = 500, int maxheight = 1000, string source = null, string icon = null)
        {
            string par = ",file=" + file;
            if (minwidth != 400)
                par += ",minwidth=" + minwidth;
            if (minheight != 400)
                par += ",minheight=" + minheight;
            if (maxwidth != 500)
                par += ",maxwidth=" + maxwidth;
            if (maxheight != 1000)
                par += ",maxheight=" + maxheight;
            if (source != null)
                par += ",source=" + source;
            if (icon != null)
                par += ",icon=" + icon;
            return $"[CQ:cardimage{par}]";
        }

        //.子程序 CQ码_文本转语音, 文本型, 公开, 文本转语音; 注意:通过TX的TTS接口, 采用的音源与登录帐号的性别有关;只能发送群聊
        //.参数 欲转换内容, 文本型, , 欲转换内容, 如:你是单身狗

        //' 返回 (“[CQ:tts,text=” ＋ 到文本 (编码_Ansi到Utf8 (欲转换内容)) ＋ “]”)
        //return (“[CQ: tts, text=” ＋ 欲转换内容 ＋ “]”)

        public static string CQ码_tts(string text)
        {
            return $"[CQ:tts,text={text}]";
        }

        //.子程序 CQ码_红包, 文本型, 公开, 仅用于收红包
        //.参数 title, 文本型, , 祝福语/口令，如:恭喜发财

        //return (“[CQ: redbag, title=” ＋ title ＋ “]”)

        public static string CQ码_红包(string title)
        {
            return $"[CQ:redbag,title={title}]";
        }

        //.子程序 CQ码_短视频, 文本型, 公开, 短视频消息；依赖ffmpeg；教程：https://t.hk.uy/YXJ
        //.参数 视频路径, 文本型, , 绝对路径, 支持http和本地文件；同CQ图片
        //.参数 视频封面, 文本型, 可空, 可空; 支持http, file和base64发送, 格式必须为jpg;本地文件的中文文件夹/文件需要转UTF8
        //.参数 线程数, 文本型, 可空, 可空; 通过网络下载视频时的线程数, 默认单线程. (在资源不支持并发时会自动处理);只能填写2或者3
        //.局部变量 par, 文本型

        //.判断开始(left (视频路径, 4) ＝ “http”)
        //    par ＝ “,file=” ＋ 视频路径
        //.默认
        //    par ＝ “, file = file:///” ＋ CQ码_转义 (视频路径)
        //.判断结束
        //.if (not (IsMissing (视频封面)))
        //    par ＝ par ＋ “,cover=” ＋ 视频封面
        //.如果真结束
        //.if (not (IsMissing (线程数)))
        //    par ＝ par ＋ “,c=” ＋ 线程数
        //.如果真结束
        //return (“[CQ: video” ＋ par ＋ “]”)

        public static string CQ码_短视频(string file, string cover = null, string c = null)
        {
            string par = ",file=" + file;
            if (cover != null)
                par += ",cover=" + cover;
            if (c != null)
                par += ",c=" + c;
            return $"[CQ:video{par}]";
        }

        //.子程序 CQ码_XML_消息, 文本型, 公开, XML 消息
        //.参数 XML内容, 文本型, , XML中的value部分
        //.参数 resid, 整数型, 可空, 可空;
        //.局部变量 par, 文本型

        //' par ＝ “,data=” ＋ 到文本 (编码_Ansi到Utf8 (XML内容))
        //par ＝ “,data=” ＋ CQ码_转义(XML内容)
        //.if (not (IsMissing (resid)))
        //    par ＝ par ＋ str(resid)
        //.如果真结束
        //return (“[CQ: xml” ＋ par ＋ “]”)
        //' 返回 (“[CQ:xml,data=” ＋ 到文本 (编码_Ansi到Utf8 (XML内容)) ＋ 选择 (是否为空 (resid), “]”, “,resid=” ＋ 到文本 (resid) ＋ “]”))

        public static string CQ码_XML_消息(string xml, int resid = 0)
        {
            string par = ",data=" + CQ码_转义(xml);
            if (resid != 0)
                par += ",resid=" + resid;
            return $"[CQ:xml{par}]";
        }
        //.子程序 CQ码_JSON_消息, 文本型, 公开, JSON 消息
        //.参数 json, 文本型, , JSON内容
        //.参数 resid, 整数型, 可空, 可空; 默认为0, 走小程序通道, 填了走富文本通道发送
        //.局部变量 par, 文本型

        //' 到文本 (编码_Ansi到Utf8 (json))
        //par ＝ “,data=” ＋ CQ码_转义(json)
        //.if (not (IsMissing (resid)))
        //    par ＝ “,resid=” ＋ str(resid)
        //.如果真结束
        //return (“[CQ: json” ＋ par ＋ “]”)

        public static string CQ码_JSON_消息(string json, int resid = 0)
        {
            string par = ",data=" + CQ码_转义(json);
            if (resid != 0)
                par += ",resid=" + resid;
            return $"[CQ:json{par}]";
        }
        //.子程序 CQ码_戳一戳, 文本型, 公开, 仅群聊; 发送戳一戳消息无法撤回, 返回的 message id 恒定为 0
        //.参数 帐号, 长整数型, , 需要戳的成员

        //return (“[CQ: poke, qq=” ＋ str(帐号) ＋ “]”)

        public static string CQ码_戳一戳(long qq)
        {
            return $"[CQ:poke,qq={qq}]";
        }
        //.子程序 CQ码_合并转发, 文本型, 公开, 合并转发；未测试
        //.参数 消息ID, 文本型, , 需要通过 Va.取合并转发内容 API获取转发的具体内容

        //return (“[CQ: forward, id=” ＋ 消息ID ＋ “]”)

        public static string CQ码_合并转发(string id)
        {
            return $"[CQ:forward,id={id}]";
        }
        //.子程序 CQ码_回复, 文本型, 公开
        //.参数 消息ID, 整数型, 可空, 可空; 优先级:高, 回复时所引用的消息id, 必须为本群消息.
        //.参数 内容, 文本型, 可空, 可空; 优先级:低, 自定义回复的信息
        //.参数 帐号, 长整数型, 可空, 可空; 优先级:低, 自定义回复时自定义QQ, 如果使用自定义信息必须指定.
        //.参数 时间, 长整数型, 可空, 可空; 优先级:低, 自定义回复时时间, 格式为Unix时间
        //.参数 seq, 长整数型, 可空, 可空; 优先级:低, 自定义回复时的起始消息序号, 可通过 va_取消息 获得
        //.局部变量 par, 文本型

        //.if (not (IsMissing (消息ID)))
        //    par ＝ par ＋ “,id=” ＋ str (消息ID)
        //.如果真结束
        //.if (not (IsMissing (内容)))
        //    par ＝ par ＋ “text=” ＋ 内容
        //.如果真结束
        //.if (not (IsMissing (帐号)))
        //    par ＝ par ＋ “,qq=” ＋ str (帐号)
        //.如果真结束
        //.if (not (IsMissing (时间)))
        //    par ＝ par ＋ “,time=” ＋ str (时间)
        //.如果真结束
        //.if (not (IsMissing (seq)))
        //    par ＝ par ＋ “,seq=” ＋ str (seq)
        //.如果真结束
        //return (“[CQ:reply” ＋ par ＋ “]”)

        public static string CQ码_回复(string id, string content = null, long qq = 0, long time = 0, long seq = 0)
        {
            string par = "";
            if (id != null)
                par += $",id={id}";
            if (content != null)
                par += $",text={content}";
            if (qq != 0)
                par += $",qq={qq}";
            if (time != 0)
                par += $",time={time}";
            if (seq != 0)
                par += $",seq={seq}";
            return $"[CQ:reply{par}]";
        }
        //.子程序 CQ码_礼物, 文本型, 公开, 仅群聊;仅支持免费礼物, 发送群礼物消息 无法撤回, 返回的 message id 恒定为 0
        //.参数 帐号, 长整数型, , 接收礼物的成员
        //.参数 礼物ID, 整数型, , 礼物的类型；0甜 Wink；1快乐肥宅水；2幸运手链；3卡布奇诺；4猫咪手表；5绒绒手套6；彩虹糖果；7坚强；8告白话筒；9牵你的手；10可爱猫咪；11神秘面具；12我超忙的；13爱心口罩

        //return (“[CQ:gift,qq=” ＋ str (帐号) ＋ “,id=” ＋ str (礼物ID) ＋ “]”)

        public static string CQ码_礼物(long qq, int id)
        {
            return $"[CQ:gift,qq={qq},id={id}]";
        }
        //.子程序 CQ码_emoji, 文本型, 公开, emoji表情(emoji)
        //.参数 表情ID, 文本型, , emoji的unicode编号,参考：https://t.hk.uy/Zag

        //return (“[CQ:emoji,id=” ＋ 表情ID ＋ “]”)

        public static string CQ码_emoji(string id)
        {
            return $"[CQ:emoji,id={id}]";
        }
        //.子程序 CQ码_窗口抖动, 文本型, 公开, 该 CQcode 暂未被 GOCQ 支持

        //return (“[CQ:shake]”)

        public static string CQ码_窗口抖动()
        {
            return "[CQ:shake]";
        }
        //.子程序 CQ码_匿名发消息, 文本型, 公开, 仅支持群(该 CQcode 暂未被 GOCQ 支持)
        //.参数 不强制, 逻辑型, 可空, 可空;表示无法匿名时是否继续发送, 默认假

        //return (“[CQ:anonymous,ignore=” ＋ iif (不强制, “1”, “0”) ＋ “]”)
        public static string CQ码_匿名发消息(bool ignore = false)
        {
            return $"[CQ:anonymous,ignore={(ignore ? 1 : 0)}]";
        }

        //.子程序 CQ码_音乐, 文本型, 公开, 发送音乐
        //.参数 音乐ID, 长整数型, , 音乐的歌曲数字ID
        //.参数 类型, 文本型, , 可空;目前支持 qq/QQ音乐 163/网易云音乐 xm/虾米音乐

        //return (“[CQ:music,type=” ＋ 类型 ＋ “,id=” ＋ str (音乐ID) ＋ “]”)
        public static string CQ码_音乐(string id, string type = "qq")
        {
            return $"[CQ:music,type={type},id={id}]";
        }
        //.子程序 CQ码_音乐自定义分享, 文本型, 公开, 发送音乐自定义分享(music)
        //.参数 分享链接, 文本型, , 点击分享后进入的音乐页面（如歌曲介绍页）
        //.参数 音频链接, 文本型, , 音乐的音频链接（如.mp3链接）
        //.参数 标题, 文本型, , 音乐的标题，建议12字以内
        //.参数 描述, 文本型, , 可选, 音乐的简介，建议30字以内
        //.参数 图片链接, 文本型, , 可选, 音乐的封面图片链接，留空则为默认图片
        //.局部变量 para, 文本型

        //para ＝ “,url=” ＋ 分享链接
        //para ＝ para ＋ “,audio=” ＋ 音频链接
        //para ＝ para ＋ “,title=” ＋ 标题
        //para ＝ para ＋ “,content=” ＋ 描述
        //para ＝ para ＋ “,image=” ＋ 图片链接
        //return (“[CQ:music,type=custom” ＋ para ＋ “]”)  ' //type是固定的
        public static string CQ码_音乐自定义分享(string url, string audio, string title, string content, string image = "")
        {
            var para = $",url={url},audio={audio},title={title},content={content},image={image}";
            return $"[CQ:music,type=custom{para}]";
        }
        //.子程序 CQ码_名片分享, 文本型, 公开, 推荐好友/群(该 CQcode 暂未被 GOCQ 支持)
        //.参数 类型, 文本型, , 目前支持 qq/好友分享 group/群分享
        //.参数 帐号, 长整数型, , 被推荐的 QQ （群）号

        //return (“[CQ:contact,type=” ＋ CQ码_转义 (类型) ＋ “,id=” ＋ str (帐号) ＋ “]”)
        public static string CQ码_名片分享(string type, long id)
        {
            return $"[CQ:contact,type={type},id={id}]";
        }
        //.子程序 CQ码_链接分享, 文本型, 公开, 发送链接分享(share)
        //.参数 链接, 文本型, , URL
        //.参数 标题, 文本型, , 分享的标题，建议12字以内
        //.参数 内容, 文本型, 可空, 可空;分享简介，建议30字以内
        //.参数 图片链接, 文本型, 可空, 可空;图片链接，空为默认图片
        //.局部变量 para, 文本型

        //para ＝ “,url=” ＋ CQ码_转义 (链接)
        //para ＝ para ＋ “,title=” ＋ CQ码_转义 (标题)
        //.if (not (IsMissing (内容)))
        //    para ＝ para ＋ “,content=” ＋ CQ码_转义 (内容)
        //.如果真结束
        //.if (not (IsMissing (图片链接)))
        //    para ＝ para ＋ “,image=” ＋ CQ码_转义 (图片链接)
        //.如果真结束
        //return (“[CQ:share” ＋ para ＋ “]”)
        public static string CQ码_链接分享(string url, string title, string content = "", string image = "")
        {
            var para = $",url={url},title={title}";
            if (!string.IsNullOrEmpty(content))
                para += $",content={content}";
            if (!string.IsNullOrEmpty(image))
                para += $",image={image}";
            return $"[CQ:share{para}]";
        }
        //.子程序 CQ码_位置分享, 文本型, 公开, 该 CQcode 暂未被 GOCQ 支持
        //.参数 纬度, 文本型
        //.参数 经度, 文本型
        //.参数 标题, 文本型, 可空, 可选
        //.参数 内容, 文本型, 可空, 可选
        //.局部变量 para, 文本型

        //para ＝ “,lat=” ＋ str (纬度) ＋ “,lon=” ＋ str (经度)
        //.if (not (IsMissing (标题)))
        //    para ＝ para ＋ “,title=” ＋ 标题
        //.如果真结束
        //.if (not (IsMissing (内容)))
        //    para ＝ para ＋ “,content=” ＋ 内容
        //.如果真结束
        //.' if (放大倍数 ＞ 0)
        //    ' para ＝ para ＋ “,zoom=” ＋ 到文本 (放大倍数)
        //.如果真结束
        //' para ＝ para ＋ “,title=” ＋ CQ码_转义 (地点名称, 真) ＋ “,content=” ＋ CQ码_转义 (地址, 真)
        //return (“[CQ:location” ＋ para ＋ “]”)
        public static string CQ码_位置分享(string lat, string lon, string title = "", string content = "")
        {
            var para = $",lat={lat},lon={lon}";
            if (!string.IsNullOrEmpty(title))
                para += $",title={title}";
            if (!string.IsNullOrEmpty(content))
                para += $",content={content}";
            return $"[CQ:location{para}]";
        }
        //.子程序 CQ码_图片, 文本型, 公开, 发送图片(image)
        //.参数 本地路径, 文本型, 可空, [二选一]图片文件名. 如 data\image\1.jpg 则填写 1.jpg
        //.参数 图片类型, 文本型, 可空, 目前支持 flash/闪照 show/秀图 默认普通图片
        //.参数 图片子类型, 整数型, 可空, 可空;图片子类型, 默认0, 只出现在群聊;0/正常图片 1/表情包 在客户端会被分类到表情包图片并缩放显示 2/热图 3/斗图 4/智图? 7/贴图 8/自拍 9/贴图广告? 10/有待测试 13/热搜图
        //.参数 网络链接, 文本型, 可空, [二选一]图片 URL正常图片 
        //.参数 使用缓存, 逻辑型, 可空, 只在通过网络 URL 发送时有效, 表示是否使用已缓存的文件, 默认为真
        //.参数 秀图ID, 整数型, 可空, 发送秀图时的特效ID, 默认40000普通 40001/幻影 40002/抖动 40003/生日 40004/爱你 40005/征友
        //.参数 线程数, 整数型, 可空, 通过网络下载图片时的线程数, 默认单线程. (在资源不支持并发时会自动处理)
        //.局部变量 para, 文本型

        //.if (IsMissing (本地路径) 且 IsMissing (网络链接))
        //    return (“图片路径与图片URL二选一”)
        //.如果真结束

        //.if (IsMissing (使用缓存))
        //    使用缓存 ＝ 真  ' //默认值
        //.如果真结束
        //.if (本地路径 ≠ “”)
        //    para ＝ para ＋ “,file=” ＋ CQ码_转义 (“file:///” ＋ 本地路径)
        //.如果真结束
        //.if (网络链接 ≠ “”)
        //    para ＝ para ＋ “,url=” ＋ 本地路径
        //.如果真结束
        //.if (图片类型 ≠ “”)
        //    para ＝ para ＋ “,type=” ＋ 图片类型
        //.如果真结束
        //.if (not (IsMissing (图片子类型)))
        //    para ＝ para ＋ “,subType=” ＋ str (图片子类型)
        //.如果真结束
        //.判断开始 (使用缓存)
        //    para ＝ para ＋ “,cache=1”
        //.默认
        //    para ＝ para ＋ “,cache=0”
        //.判断结束
        //.if (not (IsMissing (秀图ID)))
        //    para ＝ para ＋ “,id=” ＋ str (秀图ID)
        //.如果真结束
        //.if (not (IsMissing (线程数)))
        //    para ＝ para ＋ “,c=” ＋ str (线程数)
        //.如果真结束
        //return (“[CQ:image” ＋ para ＋ “]”)
        public static string CQ码_图片(string 本地路径, string 网络链接, string 图片类型, int 图片子类型, string 秀图ID, int 线程数, bool 使用缓存)
        {
            string para = "";
            if (本地路径 == "" && 网络链接 == "")
                return "图片路径与图片URL二选一";
            if (本地路径 != "")
                para += $",file={本地路径}";
            if (网络链接 != "")
                para += $",url={网络链接}";
            if (图片类型 != "")
                para += $",type={图片类型}";
            if (图片子类型 != 0)
                para += $",subType={图片子类型}";
            if (秀图ID != "")
                para += $",id={秀图ID}";
            if (线程数 != 0)
                para += $",c={线程数}";
            if (使用缓存)
                para += $",cache=1";
            else
                para += $",cache=0";
            return $"[CQ:image{para}]";
        }
        //.子程序 CQ码_语音, 文本型, 公开, 发送语音(record);需要管理员权限运行FFmpeg，所以你要以管理员权限运行QQ机器人的框架；在没有ffmpeg的情况下仅支持amr；ffmpeg安装教程：教程：https://docs.go-cqhttp.org/guide/quick_start.html#%E5%AE%89%E8%A3%85-ffmpeg
        //.参数 file, 文本型, , 支持URL链接或和本地文件路径
        //.参数 magic, 逻辑型, 可空, 变声, 可选, 真为变声，默认为假
        //.参数 cache, 逻辑型, 可空, 只在通过网络 URL 发送时有效, 表示是否使用已缓存的文件, 默认 真
        //.参数 proxy, 逻辑型, 可空, 只在通过网络 URL 发送时有效, 表示是否通过代理下载文件 ( 需通过环境变量或配置文件配置代理 ) , 默认 真
        //.参数 timeout, 整数型, 可空, 只在通过网络 URL 发送时有效, 单位秒, 表示下载网络文件的超时时间 , 默认不超时
        //.局部变量 para, 文本型

        //.判断开始 (left (file, 4) ＝ “http”)  ' //判断是否为链接
        //    para ＝ “,url=” ＋ file
        //.默认
        //    para ＝ “,file=” ＋ “file:///” ＋ CQ码_转义 (file)
        //.判断结束
        //para ＝ para ＋ “,magic=” ＋ iif (magic, “1”, “0”)

        //.if (IsMissing (cache))
        //    cache ＝ 真
        //.如果真结束
        //para ＝ para ＋ “,cache=” ＋ iif (cache, “1”, “0”)

        //.if (IsMissing (proxy))
        //    proxy ＝ 真
        //.如果真结束
        //para ＝ para ＋ “,proxy=” ＋ iif (proxy, “1”, “0”)

        //.if (not (IsMissing (timeout)))
        //    para ＝ para ＋ “,timeout” ＋ str (timeout)
        //.如果真结束
        //return (“[CQ:record” ＋ para ＋ “]”)
        public static string CQ码_语音(string file, bool magic, bool cache = true, bool proxy = true, int? timeout = null)
        {
            string para;
            if (file.StartsWith("http"))
                para = $",url={file}";
            else
                para = $",file={file}";
            para += $",magic={(magic ? "1" : "0")}";
            para += $",cache={(cache ? "1" : "0")}";
            para += $",proxy={(proxy ? "1" : "0")}";
            if (!(timeout is null))
                para += $",timeout={timeout}";
            return $"[CQ:record{para}]";
        }
        //.子程序 CQ码_猜拳魔法表情, 文本型, 公开, 发送猜拳魔法表情(rps):有效值0-2
        //.参数 猜拳, 整数型, , 0/石头 1/剪刀 2/布

        //.if (猜拳 ＜ 0 或 猜拳 ＞ 2)
        //    return (“##猜拳数值不正确##”)
        //.如果真结束
        //return (“[CQ:rps,value=” ＋ str (猜拳) ＋ “]”)
        public static string CQ码_猜拳魔法表情(int rps)
        {
            if (rps < 0 || rps > 2)
                return "##猜拳数值不正确##";
            return $"[CQ:rps,value={rps}]";
        }
        //.子程序 CQ码_掷骰子魔法表情, 文本型, 公开, 该 CQcode 暂未被 GOCQ 支持

        //return (“[CQ:dice]”)
        public static string CQ码_掷骰子魔法表情()
        {
            return "[CQ:dice]";
        }
        //.子程序 CQ码_转义, 文本型, 公开, 将CQ码符号转义为实体字符串
        //.参数 欲转义的消息, 文本型
        //.局部变量 newMsg, 文本型

        //newMsg ＝ 欲转义的消息

        //newMsg ＝ RpSubText (newMsg, “,”, “&#44;”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “&”, “&amp;”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “[”, “&#91;”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “]”, “&#93;”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “#”, “%23”, , , 真)
        //return (newMsg)
        public static string CQ码_转义(string msg)
        {
            string newMsg = msg;
            newMsg = newMsg.Replace(",", "%2C");
            newMsg = newMsg.Replace("&", "&amp;");
            newMsg = newMsg.Replace("[", "%5B");
            newMsg = newMsg.Replace("]", "%5D");
            newMsg = newMsg.Replace("#", "%23");
            return newMsg;
        }
        //.子程序 CQ码_反转义, 文本型, 公开, 将实体字符串转义为CQ码符号
        //.参数 欲转义的消息, 文本型
        //.局部变量 newMsg, 文本型

        //newMsg ＝ 欲转义的消息

        //newMsg ＝ RpSubText (newMsg, “&#91;”, “[”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “&#93;”, “]”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “&#44;”, “,”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “&amp;”, “&”, , , 真)
        //newMsg ＝ RpSubText (newMsg, “#”, “%23”, , , 真)
        //return (newMsg)
        public static string CQ码_反转义(string msg)
        {
            string newMsg = msg;
            newMsg = newMsg.Replace("%5B", "[");
            newMsg = newMsg.Replace("%5D", "]");
            newMsg = newMsg.Replace("%2C", ",");
            newMsg = newMsg.Replace("%23", "#");
            newMsg = newMsg.Replace("&amp;", "&");
            return newMsg;
        }
        //.子程序 CQ码_解析_回复消息ID, 长整数型, 公开, 返回cq码内的回复消息ID
        //.参数 message, 文本型, , [CQ:reply,id=-1985300826][CQ:at,qq=2727756774] [CQ:at,qq=2727756774]  这是回复内容

        //return (ToLong (文本_取出中间文本 (message, “[CQ:reply,id=”, “]”)))
        public static long CQ码_解析_回复消息ID(string message)
        {
            return long.Parse(Text_取出中间文本(message, "[CQ:reply,id=", "]"));
        }
        //.子程序 CQ码_解析_回复消息_At对象, 长整数型, 公开, 取出被@对象的QQ
        //.参数 message, 文本型, , [CQ:reply,id=-1985300826][CQ:at,qq=2727756774] [CQ:at,qq=2727756774]  这是回复内容

        //return (ToLong (文本_取出中间文本 (message, “[CQ:at,qq=”, “]”)))
        public static long CQ码_解析_回复消息_At对象(string message)
        {
            return long.Parse(Text_取出中间文本(message, "[CQ:at,qq=", "]"));
        }

        public static string Text_取出中间文本(string message, string start, string end)
        {
            int startIndex = message.IndexOf(start);
            int endIndex = message.LastIndexOf(end);
            if (startIndex == -1 || endIndex == -1)
            {
                return "";
            }
            return message.Substring(startIndex + start.Length, endIndex - startIndex - start.Length);
        }
    }
}
